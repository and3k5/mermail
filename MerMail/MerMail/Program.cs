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
            //Application.Run(new ); //later
            initMermailDB();
            Application.Run(new Form1());
            MessageBox.Show("Nu lukkes Loginform - sqlCon afbrydes");
            sqlCon.Close();
        }
        public readonly static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static SQLiteConnection sqlCon;
        public static void initMermailDB()
        {
            if (System.IO.Directory.Exists(appdata+"/mermail/") == false)
            {
                System.IO.Directory.CreateDirectory(appdata+"/mermail/");
            }
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata+"/mermail/mermail.db";
            conStr.Version = 3;

            sqlCon = new SQLiteConnection(conStr.ConnectionString);

            sqlCon.Open();

            SQLiteCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS users ( id INTEGER PRIMARY KEY AUTOINCREMENT, mailaddress VARCHAR(255) NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null )";
            cmd.ExecuteNonQuery();
            //sqlCon.Close();
            //con.CreateFile("%appdata%/.mermail/mermail.db");




        }
        public static int insertUser(string mailaddr, string password, string pop_hostname, int pop_port, bool pop_ssl)
        {
            //SQLiteTransaction transact;
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

            //transact = sqlCon.BeginTransaction();
            int rtn=cmd.ExecuteNonQuery();
            MessageBox.Show(rtn.ToString());
            return 0;
            
            //cmd.CommandText = "CREATE TABLE IF NOT EXISTS users ( id INTEGER PRIMARY KEY AUTOINCREMENT, mailaddress VARCHAR(255) NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null )";
            //cmd.ExecuteNonQuery();
        }
        public static List<OpenPop.Mime.Message> FetchAllMessages(string Hostname, int port, bool usessl, string username, string password)
        {
            using(OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client())
            {
                //connection
                client.Connect(Hostname, port, usessl);

                // authenticate
                client.Authenticate(username, password);

                int messageCount = client.GetMessageCount();

                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                }
                return allMessages;
            }
        }
        public static void AuthenticateLog(string Hostname, int port, bool usessl, string username, string password) 
        {
            try
            {
                OpenPop.Pop3.Pop3Client authclient = new OpenPop.Pop3.Pop3Client();

                authclient.Connect(Hostname, port, usessl);

                authclient.Authenticate(username, password);

                //MessageBox.Show("con:"+authclient.Connected);
                
                if (authclient.Connected.Equals(true))
                {
                    Form.ActiveForm.Close();
                    //Form.ActiveForm.Hide();
                    //Form1 nform = new Form1();
                    //nform.ShowDialog();
                    //Application.Exit();
                }
                else
                {
                    MessageBox.Show("Authentication failed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..."+err);
            }
        }
    }
}
