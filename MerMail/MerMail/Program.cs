using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;
using System.Data.SQLite;

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
        public static SQLiteConnection sqlCon;
        private static void initMermailDB()
        {
            if (System.IO.Directory.Exists(appdata + "/mermail/") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "/mermail/");
            }
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata + "/mermail/mermail.db";
            conStr.Version = 3;

            sqlCon = new SQLiteConnection(conStr.ConnectionString);

            sqlCon.Open();

            SQLiteCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS users ( id INTEGER PRIMARY KEY AUTOINCREMENT, mailaddress VARCHAR(255) NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null )";
            cmd.ExecuteNonQuery();
        }
        public struct mailaccount
        {
            public int id;
            public string mailaddress;
            public string password;
            public string pop_hostname;
            public int pop_port;
            public bool pop_ssl;
            public mailaccount(int _id, string _mailaddress, string _password, string _pop_hostname, int _pop_port, bool _pop_ssl)
            {
                id = _id;
                mailaddress = _mailaddress;
                password = _password;
                pop_hostname = _pop_hostname;
                pop_port = _pop_port;
                pop_ssl = _pop_ssl;
            }

        }
        public static int insertUser(string mailaddr, string password, string pop_hostname, int pop_port, bool pop_ssl)
        {
            string countQuery = "SELECT COUNT(*) FROM users WHERE mailaddress=@_mailaddress";
            SQLiteCommand countCmd = sqlCon.CreateCommand();
            countCmd.CommandText = countQuery;
            countCmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
            int count = Convert.ToInt32(countCmd.ExecuteScalar());
            int id;
            if (count == 0)
            {

                string sqlquery = "INSERT INTO users (mailaddress,password,pop_hostname,pop_port,pop_ssl) ";
                sqlquery += "VALUES (@_mailaddress,@_password,@_pop_hostname,@_pop_port,@_pop_ssl)";

                SQLiteCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = sqlquery;
                cmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
                cmd.Parameters.AddWithValue("@_password", password);
                cmd.Parameters.AddWithValue("@_pop_hostname", pop_hostname);
                cmd.Parameters.AddWithValue("@_pop_port", pop_port);
                int popSSL = 0;
                if (pop_ssl == true) popSSL = 1;

                cmd.Parameters.AddWithValue("@_pop_ssl", popSSL);

                int rtn = cmd.ExecuteNonQuery();

                string getIDQuery = "select last_insert_rowid()";
                SQLiteCommand getIDCmd = sqlCon.CreateCommand();
                getIDCmd.CommandText = getIDQuery;
                id = Convert.ToInt32(getIDCmd.ExecuteScalar());
            }
            else
            {
                string sqlquery = "UPDATE users SET mailaddress=@_mailaddress,password=@_password,pop_hostname=@_pop_hostname,pop_port=@_pop_port,pop_ssl=@_pop_ssl ";
                sqlquery += "WHERE mailaddress=@_mailaddress";

                SQLiteCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = sqlquery;
                cmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
                cmd.Parameters.AddWithValue("@_password", password);
                cmd.Parameters.AddWithValue("@_pop_hostname", pop_hostname);
                cmd.Parameters.AddWithValue("@_pop_port", pop_port);
                int popSSL = 0;
                if (pop_ssl == true) popSSL = 1;

                cmd.Parameters.AddWithValue("@_pop_ssl", popSSL);

                int rtn = cmd.ExecuteNonQuery();

                string getIDQuery = "SELECT id FROM users WHERE mailaddress=@_mailaddress";
                SQLiteCommand getIDCmd = sqlCon.CreateCommand();
                getIDCmd.CommandText = getIDQuery;
                getIDCmd.Parameters.AddWithValue("@_mailaddress", mailaddr);
                id = Convert.ToInt32(getIDCmd.ExecuteScalar());
            }
            return id;
        }
        public static List<mailaccount> getAccounts()
        {
            string sqlquery = "SELECT * FROM users";
            SQLiteCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = sqlquery;
            SQLiteDataAdapter sqladapt = new SQLiteDataAdapter(cmd);
            System.Data.DataSet sqlset = new System.Data.DataSet();
            System.Data.DataTable tbl = new System.Data.DataTable();
            sqladapt.Fill(tbl);
            List<mailaccount> rtn = new List<mailaccount>();
            foreach (System.Data.DataRow row in tbl.Rows)
            {
                mailaccount tmp = new mailaccount(Convert.ToInt16(row.ItemArray[0]), Convert.ToString(row.ItemArray[1]), Convert.ToString(row.ItemArray[2]), Convert.ToString(row.ItemArray[3]), Convert.ToInt16(row.ItemArray[4]), Convert.ToBoolean(row.ItemArray[5]));
                rtn.Add(tmp);
            }
            return rtn;

        }
        public static List<OpenPop.Mime.Message> FetchAllMessages()
        {
            int messageCount = popClient.GetMessageCount();

            List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

            for (int i = messageCount; i > 0; i--)
            {
                allMessages.Add(popClient.GetMessage(i));
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
        }
    }
}
