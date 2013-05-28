using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;


namespace MerMail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initMermailDB();
            Application.Run(new Form1());
            sqlCon.Close();
        }

        public static bool popauth;
        private static OpenPop.Pop3.Pop3Client popClient = new OpenPop.Pop3.Pop3Client();
        public readonly static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static SQLiteConnection sqlCon; // used for user database
        private static SQLiteConnection msgSqlCon; // used for storing emails 
        private static void initMermailDB()
        {
            // sqlCon - user database
            if (System.IO.Directory.Exists(appdata + "/mermail/") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "/mermail/");
            }
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata + "/mermail/mermail.db";
            conStr.Version = 3;
            sqlCon = new SQLiteConnection(conStr.ConnectionString);
            sqlCon.Open();

            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS users (mailaddress VARCHAR(255) PRIMARY KEY NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null )", sqlCon);
            cmd.ExecuteNonQuery();

            // msgSqlCon
            if (System.IO.Directory.Exists(appdata + "/mermail/userdata") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "/mermail/userdata/");
            }
        }
        public struct mailaccount
        {
            public string mailaddress;
            public string password;
            public string pop_hostname;
            public int pop_port;
            public bool pop_ssl;
            public mailaccount(string _mailaddress, string _password, string _pop_hostname, int _pop_port, bool _pop_ssl)
            {
                mailaddress = _mailaddress;
                password = _password;
                pop_hostname = _pop_hostname;
                pop_port = _pop_port;
                pop_ssl = _pop_ssl;
            }

        }
        public struct email
        {
            public string sender;
            public string subject;
            public string body;
            public string date;
            public email(string _sender, string _subject, string _body, string _date)
            {
                sender = _sender;
                subject = _subject;
                body = _body;
                date = _date;
            }

        }
        public static int insertUser(string mailaddr, string password, string pop_hostname, int pop_port, bool pop_ssl)
        {
            // Insert user to the table if it doesn't exist
            string insertQuery = "INSERT OR IGNORE INTO users (mailaddress,password,pop_hostname,pop_port,pop_ssl) ";
            insertQuery += "VALUES (@_mailaddress,@_password,@_pop_hostname,@_pop_port,@_pop_ssl)";
            SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, sqlCon);
            insertCmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
            insertCmd.Parameters.AddWithValue("@_password", password);
            insertCmd.Parameters.AddWithValue("@_pop_hostname", pop_hostname);
            insertCmd.Parameters.AddWithValue("@_pop_port", pop_port);
            insertCmd.Parameters.AddWithValue("@_pop_ssl", Convert.ToInt16(pop_ssl));
            insertCmd.ExecuteNonQuery();

            // Is used for making a name of the message database file for the user
            string userMD5 = genMd5(mailaddr);

            // set up SQLite connection for message database
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata + "/mermail/userdata/"+ userMD5 + ".db";
            conStr.Version = 3;
            msgSqlCon = new SQLiteConnection(conStr.ConnectionString);
            msgSqlCon.Open();
            SQLiteCommand crCMD = new SQLiteCommand("CREATE TABLE IF NOT EXISTS messagetable (id CHAR(32) PRIMARY KEY NOT NULL,sender TEXT NOT NULL, subject TEXT, body TEXT, date DATETIME NOT NULL)", msgSqlCon);
            crCMD.ExecuteNonQuery();
            
            return 0;
        }
        public static List<mailaccount> getAccounts()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users", sqlCon);
            SQLiteDataAdapter sqladapt = new SQLiteDataAdapter(cmd);
            System.Data.DataSet sqlset = new System.Data.DataSet();
            System.Data.DataTable tbl = new System.Data.DataTable();
            sqladapt.Fill(tbl);
            List<mailaccount> rtn = new List<mailaccount>();
            foreach (System.Data.DataRow row in tbl.Rows)
            {
                mailaccount tmp = new mailaccount(Convert.ToString(row.ItemArray[0]), Convert.ToString(row.ItemArray[1]), Convert.ToString(row.ItemArray[2]), Convert.ToInt16(row.ItemArray[3]), Convert.ToBoolean(row.ItemArray[4]));
                rtn.Add(tmp);
            }
            return rtn;

        }
        private static string genMd5(string input)
        {
            // MD5 part is copied from MSDN
            MD5 hasher = MD5.Create();
            byte[] data = hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static List<email> FetchAllMessages()
        {
            // add messages to db
            int messageCount = popClient.GetMessageCount();

            for (int i = messageCount; i > 0; i--)
            {
                OpenPop.Mime.Message msg = popClient.GetMessage(i);
                string id = genMd5(string.Format("{0}_{1}_{2}_{3}", msg.Headers.From.MailAddress.Address, msg.Headers.DateSent.Ticks.ToString(), genMd5(msg.Headers.MessageId), msg.Headers.Subject));
                string from = msg.Headers.From.MailAddress.Address;
                string subject = msg.Headers.Subject;
                string body = "";
                switch (msg.MessagePart.ContentType.MediaType)
                {
                    default:
                        body = msg.FindFirstPlainTextVersion().GetBodyAsText();
                        break;
                    case "multipart/alternative":
                        body = msg.FindFirstHtmlVersion().GetBodyAsText();
                        break;
                }
                // select strftime('%s','now');
                // YYYY-MM-DD HH:MM:SS;
                DateTime sent_o = msg.Headers.DateSent;
                string sent = string.Format("{0:d4}-{1:d2}-{2:d2} {3:d2}:{4:d2}:{5:d2}", sent_o.Year, sent_o.Month, sent_o.Day, sent_o.Hour, sent_o.Minute, sent_o.Second);
                //MessageBox.Show(sent);

                SQLiteCommand crCMD = new SQLiteCommand("INSERT OR IGNORE INTO messagetable (id,sender,subject,body,date) VALUES (@_id,@_sender,@_subject,@_body,datetime(strftime('%Y-%m-%d %H:%M:%S',@_sent)))", msgSqlCon);

                crCMD.Parameters.AddWithValue("@_id", id);
                crCMD.Parameters.AddWithValue("@_sender", from);
                crCMD.Parameters.AddWithValue("@_subject", subject);
                crCMD.Parameters.AddWithValue("@_body", body);
                crCMD.Parameters.AddWithValue("@_sent", sent);

                crCMD.ExecuteNonQuery();

                //sent.
                //System.Net.Mail.MailAddress
                
                //allMessages.Add(msg);
            }

            // get from database
            List<email> allMessages = new List<email>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT sender,subject,body,date FROM messagetable", msgSqlCon);
            SQLiteDataAdapter sqladapt = new SQLiteDataAdapter(cmd);
            System.Data.DataSet sqlset = new System.Data.DataSet();
            System.Data.DataTable tbl = new System.Data.DataTable();
            sqladapt.Fill(tbl);
            
            foreach (System.Data.DataRow row in tbl.Rows)
            {
                //mailaccount tmp = new mailaccount(Convert.ToInt16(row.ItemArray[0]), Convert.ToString(row.ItemArray[1]), Convert.ToString(row.ItemArray[2]), Convert.ToString(row.ItemArray[3]), Convert.ToInt16(row.ItemArray[4]), Convert.ToBoolean(row.ItemArray[5]));
                email tmp = new email(Convert.ToString(row.ItemArray[0]), Convert.ToString(row.ItemArray[1]), Convert.ToString(row.ItemArray[2]), Convert.ToString(row.ItemArray[3]));
                allMessages.Add(tmp);
            }

            return allMessages;
        }
        public static bool AuthenticateLog(string Hostname, int port, bool usessl, string username, string password)
        {
            popauth = true;
            try
            {
                if (popClient.Connected.Equals(true))
                {
                    popClient.Disconnect();
                }
                popClient.Connect(Hostname, port, usessl);

                if (popClient.Connected.Equals(true))
                {
                    popClient.Authenticate(username, password);
                }
                else
                {
                    MessageBox.Show("Kunne ikke oprette forbindelse til serveren");
                    popauth = false;
                }
            }
            catch (OpenPop.Pop3.Exceptions.InvalidLoginException err)
            {
                popauth = false;
                MessageBox.Show("Serveren accepterede ikke login");
            }
            catch (Exception err)
            {
                popauth = false;
                MessageBox.Show("Der skete en ukendt fejl..." + err);
            }
            return popauth;
        }

        public static void login()
        {
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

        public static void logout()
        {
            popClient.Disconnect();
            msgSqlCon.Close();
            Application.Restart();
        }
    }
}
