using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.ComponentModel;
using System.IO;


namespace MerMail
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initMermailDB(); // Initialize SQLite database connections
            Application.Run(new Form1());
            sqlCon.Close(); // Closes the connection when program exits
        }

        /* Structures for our program */

        // Our structure of a mailaccount
        public struct mailaccount
        {
            public string mailaddress;
            public string password;
            public string pop_hostname;
            public int pop_port;
            public bool pop_ssl;
            public string smtp_hostname;
            public int smtp_port;
            public bool smtp_ssl;
            public string encryption_key; // symmetric key for encryption of message bodies
            public mailaccount(string _mailaddress, string _password, string _pop_hostname, int _pop_port, bool _pop_ssl, string _smtp_hostname, int _smtp_port, bool _smtp_ssl, string _encryption_key)
            {
                mailaddress = _mailaddress;
                password = _password;
                pop_hostname = _pop_hostname;
                pop_port = _pop_port;
                pop_ssl = _pop_ssl;
                smtp_hostname = _smtp_hostname;
                smtp_port = _smtp_port;
                smtp_ssl = _smtp_ssl;
                encryption_key = _encryption_key;
            }

        }

        // Our structure of an email
        public struct email
        {
            public string sender; // from
            public string subject;
            public string body;
            public string date;
            public string to;

            // This is the constructor for viewing an email
            public email(string _sender, string _subject, string _body, string _date)
            {
                sender = _sender;
                subject = _subject;
                body = _body;
                date = _date;
                to = "";
            }

            // This is the constructor for sending an email
            public email(string _to, string _subject, string _body)
            {
                sender = "";
                subject = _subject;
                body = _body;
                date = "";
                to = _to;
            }
        }

        // Our file structure
        // This is made for the encryption process
        // We called it MFile because File is a property of System.IO
        public struct MFile
        {
            public string fullpath;
            public string filename;
            public string data;
            public bool valid;
            public MFile(string f, string fn, string d, bool v)
            {
                fullpath = f;
                filename = fn;
                data = d;
                valid = v;
            }
        }

        /* Global variables */

        // We made the popClient global, so we dont have to make a new one
        // every time we have to connect to the server. Might be as good as
        // if we used it local.
        // The popClient has to reconnect to the server to get new mails.
        // (Limitations of the POP3 standard)
        private static OpenPop.Pop3.Pop3Client popClient = new OpenPop.Pop3.Pop3Client();
        
        // if the popClient has authenticated successfully
        public static bool popauth; 
        
        // The appdata path of the user
        public readonly static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
        // SQLite connection for our user database
        private static SQLiteConnection sqlCon;
        
        // SQLite connection for our email database, when the user is logged in
        // Seperate database file for each user
        private static SQLiteConnection msgSqlCon;

        // The current user which is logged in. Is used for FetchAllMessages.
        // This is a defined struct we have made
        private static mailaccount currentUser;

        /* Initializing */ 

        // Initalize the SQLite database connections
        private static void initMermailDB()
        {
            // sqlCon - the user database

            // Create the path
            if (System.IO.Directory.Exists(appdata + "/mermail/") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "/mermail/");
            }

            // connection string
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata + "/mermail/mermail.db";
            conStr.Version = 3;
            sqlCon = new SQLiteConnection(conStr.ConnectionString);
            sqlCon.Open();

            // make table (if it doesn't exist)
            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS users (mailaddress VARCHAR(255) PRIMARY KEY NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null,smtp_hostname VARCHAR(255) not null, smtp_port INTEGER not null,smtp_ssl BOOLEAN not null,encryption_key TEXT not null)", sqlCon);
            cmd.ExecuteNonQuery();

            // create folder for msgSqlCon if it doesn't exist
            if (System.IO.Directory.Exists(appdata + "/mermail/userdata") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "/mermail/userdata/");
            }
        }

        // Make md5 string with one line
        // This saves a lot of sweat
        private static string genMd5(string input)
        {
            // MD5 part is copied from MSDN
            if (input == null)
            {
                input = "";
            }
            MD5 hasher = MD5.Create();
            byte[] data = hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /* File functions */
        
        // saveFile
        // To avoid making these 10 lines too many times
        public static bool saveFile(string filename, string title, string typename, string filetype, string data)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = filename;
            saveDialog.Title = title;
            saveDialog.Filter = string.Format("{0}|{1}", typename, filetype);
            DialogResult rtn = saveDialog.ShowDialog();
            if (rtn == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveDialog.FileName, false);
                    if (data != null)
                    { streamWriter.Write(data); }
                    streamWriter.Close();
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Overload of saveFile:
        // If we put an int at the end, it returns the path of the saved file
        // The int is used anyway..
        public static string saveFile(string filename, string title, string typename, string filetype, string data, int withFileName,string startPath)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = filename;
            saveDialog.Title = title;
            if (startPath != null)
            {
                saveDialog.InitialDirectory = startPath;
            }
            saveDialog.Filter = string.Format("{0}|{1}", typename, filetype);
            DialogResult rtn = saveDialog.ShowDialog();
            if (rtn == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveDialog.FileName, false);
                    if (data != null)
                    { streamWriter.Write(data); }
                    streamWriter.Close();
                    if (withFileName==1) {
                        return saveDialog.FileName;
                    }else{
                        return new FileInfo(saveDialog.FileName).DirectoryName;
                    }
                }
                catch (Exception Ex)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        // openFile
        // Also made to avoid making these 10 lines too many times
        public static MFile openFile(string filename, string title, string typename, string filetype)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.FileName = filename;
            openDialog.Title = title;
            openDialog.Filter = string.Format("{0}|{1}", typename, filetype);
            string data = null;
            bool valid = false;
            DialogResult rtn = openDialog.ShowDialog();
            if (rtn == DialogResult.OK)
            {
                if (File.Exists(openDialog.FileName))
                {
                    StreamReader streamReader = new StreamReader(openDialog.FileName, true);
                    data = streamReader.ReadToEnd();
                    streamReader.Close();
                    valid = true;
                }
            }
            return new MFile(openDialog.FileName, openDialog.SafeFileName, data, valid);
        }

        /* SQLite functions */

        // Insert user to database
        // This is only called, if the user could connect and authenticate to the server
        public static int insertUser(string mailaddr, string password, string pop_hostname, int pop_port, bool pop_ssl, string smtp_hostname, int smtp_port, bool smtp_ssl)
        {
            // Now that we have encryption, we have to know if the user really exists.
            // If we generate a new key, the data, we already have, is invalid
            bool userExist = false;
            string sqlCountQuery="SELECT COUNT(*) FROM users WHERE mailaddress=@_mailaddr";
            SQLiteCommand sqlCountCMD = new SQLiteCommand(sqlCountQuery, sqlCon);
            sqlCountCMD.Parameters.AddWithValue("@_mailaddr", mailaddr);
            int count=Convert.ToInt16(sqlCountCMD.ExecuteScalar());
            string user_key = "";
            if (count > 0)
            {
                userExist = true;
                string getKeyQuery = "SELECT encryption_key FROM users WHERE mailaddress=@_mailaddr";
                SQLiteCommand getKeyCMD = new SQLiteCommand(getKeyQuery, sqlCon);
                getKeyCMD.Parameters.AddWithValue("@_mailaddr", mailaddr);
                user_key = Convert.ToString(getKeyCMD.ExecuteScalar());
            }

            // Insert/replace the user in the user database
            string insertQuery = "INSERT OR REPLACE INTO users (mailaddress,password,pop_hostname,pop_port,pop_ssl,smtp_hostname,smtp_port,smtp_ssl,encryption_key) ";
            insertQuery += "VALUES (@_mailaddress,@_password,@_pop_hostname,@_pop_port,@_pop_ssl,@_smtp_hostname,@_smtp_port,@_smtp_ssl,@_encryption_key)";
            SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, sqlCon);
            insertCmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
            insertCmd.Parameters.AddWithValue("@_password", password);
            insertCmd.Parameters.AddWithValue("@_pop_hostname", pop_hostname);
            insertCmd.Parameters.AddWithValue("@_pop_port", pop_port);
            insertCmd.Parameters.AddWithValue("@_pop_ssl", Convert.ToInt16(pop_ssl));
            insertCmd.Parameters.AddWithValue("@_smtp_hostname", smtp_hostname);
            insertCmd.Parameters.AddWithValue("@_smtp_port", smtp_port);
            insertCmd.Parameters.AddWithValue("@_smtp_ssl", Convert.ToInt16(smtp_ssl));
            if (!userExist)
            {
                // If the user didn't exist before, make a key to him/her
                user_key = MerMail.Symmetric.generateKey();
            }
            insertCmd.Parameters.AddWithValue("@_encryption_key", user_key);
            insertCmd.ExecuteNonQuery();

            // Now, we define the currentUser global, so that we know who the 
            // current user is
            currentUser = new mailaccount(mailaddr,password,pop_hostname,pop_port,pop_ssl,smtp_hostname,smtp_port,smtp_ssl,user_key);

            // Is used for making a name of the message database file for the user
            string userMD5 = genMd5(mailaddr);

            // set up SQLite connection for message database
            // (the separate-per-user database)
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata + "/mermail/userdata/"+ userMD5 + ".db";
            conStr.Version = 3;
            msgSqlCon = new SQLiteConnection(conStr.ConnectionString);
            msgSqlCon.Open();
            SQLiteCommand crCMD = new SQLiteCommand("CREATE TABLE IF NOT EXISTS messagetable (id CHAR(32) PRIMARY KEY NOT NULL,sender TEXT NOT NULL, subject TEXT, body TEXT, date DATETIME NOT NULL)", msgSqlCon);
            crCMD.ExecuteNonQuery();
            
            return 0;
        }

        // This is used in the Login form
        // These accounts are automatically stored in the database, when
        // connection is succesful (by InsertUser)
        public static List<mailaccount> getAccounts()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT mailaddress,password,pop_hostname,pop_port,pop_ssl,smtp_hostname,smtp_port,smtp_ssl FROM users", sqlCon);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<mailaccount> rtn = new List<mailaccount>();
            while (reader.Read())
            {
                mailaccount tmp = new mailaccount(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt16(6), reader.GetBoolean(7),"");
                rtn.Add(tmp);
            }
            return rtn;
        }
        
        public static void FetchAllMessages(object sender, DoWorkEventArgs e)
        {
            
            // Add messages from pop3 server to message database
            try
            {
                // Makes a new POP3 session
                // POP3 does not allow to check for new mails
                // * facepalm *
                popClient.Disconnect();
                popClient.Connect(currentUser.pop_hostname, currentUser.pop_port, currentUser.pop_ssl);
                popClient.Authenticate(currentUser.mailaddress, currentUser.password);
            }
            catch (SystemException err)
            {
                MessageBox.Show("Kunne ikke genoprette en forbindelse"+Environment.NewLine+err.Message);
            }
            
            // gets messagecount
            int messageCount = popClient.GetMessageCount();

            // progress of process
            int progress = 0;
            
            // the progress value when it was sent to the progressbar
            int lastProgress = 0; 

            for (int i = messageCount; i > 0; i--)
            {
                OpenPop.Mime.Message msg = popClient.GetMessage(i);

                // We don't like the fact about messageId is optional,
                // so we make our own messageID by a md5 of
                //  - the sender's email
                //  - the tick value (ticks since 1. January year 1)
                //  - md5 of messageID (if it doesnt present then = md5 of "")
                //  - subject of the mail
                string id = genMd5(string.Format("{0}_{1}_{2}_{3}", msg.Headers.From.MailAddress.Address, msg.Headers.DateSent.Ticks.ToString(), genMd5(msg.Headers.MessageId), msg.Headers.Subject));
                string from = msg.Headers.From.MailAddress.Address;
                string subject = msg.Headers.Subject;
                string body = "";

                // We prefer multipart if it's available
                if (msg.MessagePart.IsMultiPart)
                {
                    body = msg.FindFirstHtmlVersion().GetBodyAsText();
                }
                else
                {
                    body = msg.FindFirstPlainTextVersion().GetBodyAsText();
                }

                // Date sent to SQLite DateTime format
                DateTime sent_o = msg.Headers.DateSent;
                string sent = string.Format("{0:d4}-{1:d2}-{2:d2} {3:d2}:{4:d2}:{5:d2}", sent_o.Year, sent_o.Month, sent_o.Day, sent_o.Hour, sent_o.Minute, sent_o.Second);

                // Insert it (or not, if it already exists) to the SQLite database
                SQLiteCommand crCMD = new SQLiteCommand("INSERT OR IGNORE INTO messagetable (id,sender,subject,body,date) VALUES (@_id,@_sender,@_subject,@_body,datetime(strftime('%Y-%m-%d %H:%M:%S',@_sent)))", msgSqlCon);

                crCMD.Parameters.AddWithValue("@_id", id);
                crCMD.Parameters.AddWithValue("@_sender", from);
                crCMD.Parameters.AddWithValue("@_subject", subject);
                crCMD.Parameters.AddWithValue("@_body", MerMail.Symmetric.EncryptString(currentUser.encryption_key,body));
                crCMD.Parameters.AddWithValue("@_sent", sent);

                crCMD.ExecuteNonQuery();

                // calculate the progress percentage
                progress = (i * 100) / (messageCount);
                if (progress > lastProgress + 10)
                {
                    // if the progress is 10 percent higher than lastprogress,
                    // then report it to the progressBar, and set lastprogress
                    // to the progress percentage right now
                    (sender as BackgroundWorker).ReportProgress(progress);
                    lastProgress = progress;
                }
            }
        }

        // Get mails from the SQLite database
        // Used to put mails into the listBox
        public static void ImportMails(object sender, DoWorkEventArgs e)
        {
            // get from database
            List<email> allMessages = new List<email>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT sender,subject,body,date FROM messagetable ORDER BY date DESC", msgSqlCon);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email tmp = new email(reader.GetString(0), reader.GetString(1), MerMail.Symmetric.DecryptString(currentUser.encryption_key, reader.GetString(2)), reader.GetString(3));
                allMessages.Add(tmp);
            }
            e.Result = allMessages;
        }

        // The general function to decrypt a mail, depending on settings
        // Uses asymmetric.cs and symmetric.cs functions
        public static email decryptMail(email mail, bool useSymmetric, string symmetricKey, bool useAsymmetric, MerMail.Asymmetric.Key privatekey)
        {
            // We are maybe going to modify contents in the mail, so we store it
            email rtn = mail;

            // We are maybe going to decrypt the symmetric key, so we store it too
            string symKey = symmetricKey; 

            // We symmetricly decrypt the message body (if chosen)
            if (useSymmetric)
            {
                // we asymmetricly decrypt the symmetric key (if chosen)
                if (useAsymmetric)
                {
                    symKey = MerMail.Asymmetric.DecryptString(symmetricKey, privatekey);
                }
                rtn.body = MerMail.Symmetric.DecryptString(symKey, rtn.body);
            }
            return rtn;
        }

        // The general function to encrypt a mail, depending on settings
        // Uses asymmetric.cs and symmetric.cs functions
        public static email encryptMail(email mail, bool useSymmetric, string symmetricKey, bool useAsymmetric, MerMail.Asymmetric.Key public_key)
        {
            // We are maybe going to modify contents in the mail, so we store it
            email rtn = mail;

            // We are maybe going to encrypt the symmetric key, so we store it too
            string symKey = symmetricKey;

            // We'll make it easy for the user to know, if the symmetric key
            // is encrypted or not
            string symKeyName = "symmetric_raw.txt";
            string diagTitle = "Save symmetric key to file";

            // We symmetricly encrypt the message body (if chosen)
            if (useSymmetric)
            {
                // We'll encrypt the message, while we still know the symmetric key
                rtn.body = MerMail.Symmetric.EncryptString(symKey, rtn.body);

                // We asymmetricly encrypt the symmetric key (if chosen)
                if (useAsymmetric)
                {
                    symKey = MerMail.Asymmetric.EncryptString(symmetricKey, public_key);

                    // Now, we know that the symmetric key is encrypted, so we're
                    // going to tell the user that we encrypted it
                    symKeyName = "symmetric_encrypted.txt";
                    diagTitle = "Save encrypted symmetric key to file";
                }
            }

            // Can be saved to any filetype (but we like .txt)
            MerMail.Program.saveFile(symKeyName, diagTitle, "Any (*.*)", "*.*", symKey);
            
            return rtn;
        }
        
        // The function to connect to the pop3 client server;
        public static bool AuthenticateLog(string Hostname, int port, bool usessl, string username, string password)
        {
            // As far as we know, this is succesful yet,
            // but if it fails in a try catch phrase,
            // we set popauth to false (so we know that
            // we're not logged in)
            popauth = true;

            try
            {
                // If the popClient already is connected = disconnect
                if (popClient.Connected.Equals(true))
                {
                    popClient.Disconnect();
                }

                // Connect to the server
                popClient.Connect(Hostname, port, usessl);

                // If we're connected, try to authenticate
                if (popClient.Connected.Equals(true))
                {
                    popClient.Authenticate(username, password);
                }
                else
                {
                    // Connection failed: set popauth to false
                    MessageBox.Show("Kunne ikke oprette forbindelse til serveren");
                    popauth = false;
                }
            }
            catch (OpenPop.Pop3.Exceptions.InvalidLoginException err)
            {
                // Known Exception: Invalid login
                popauth = false;
                MessageBox.Show("Serveren accepterede ikke login");
            }
            catch (Exception err)
            {
                // Unknown exception
                popauth = false;
                MessageBox.Show("Der skete en ukendt fejl..." + err);
            }
            return popauth;
        }

        // Function to send a mail
        public static void SendMail(string to,string subject,string body)
        {
            using (SmtpClient smtpClient = new SmtpClient(currentUser.smtp_hostname))
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(currentUser.mailaddress);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                // smtp settings is stored in currentUser
                smtpClient.Port = currentUser.smtp_port;
                smtpClient.Credentials = new System.Net.NetworkCredential(currentUser.mailaddress, currentUser.password);
                smtpClient.EnableSsl = currentUser.smtp_ssl;

                smtpClient.Send(mail);
            }
        }

        // This is our function to show the login form before 
        // Form1.cs (the form with the inbox)
        // Our program first starts Form1.cs first, but requires
        // the login form to show first, inside the Form1.cs
        public static void login()
        {
            // Show the login form
            Login flogin = new Login();
            DialogResult res = flogin.ShowDialog();

            if (res == DialogResult.OK && popauth == true)
            {
                flogin.Close();
            }
            else if (res == DialogResult.None)
            {
                Application.Exit();
            }
            else if (popauth == false && res == DialogResult.OK)
            {

            }
            else if (res == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        // Logout function
        // Simply, we just closes all connections and restarts 
        // the whole application
        // It also detaches the debugger :)
        public static void logout()
        {
            popClient.Disconnect();
            msgSqlCon.Close();
            Application.Restart();
        }
    }
}
