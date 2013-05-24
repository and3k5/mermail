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
            // LETS GET THIS PYJAMAS PARTY STARTED!
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ); //later
            initMermailDB();
            Application.Run(new Login());
        }
        public readonly static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static void initMermailDB()
        {
            if (System.IO.Directory.Exists(appdata+"/mermail/") == false)
            {
                System.IO.Directory.CreateDirectory(appdata+"/mermail/");
            }
            SQLiteConnectionStringBuilder conStr = new SQLiteConnectionStringBuilder();
            conStr.DataSource = appdata+"/mermail/mermail.db";
            conStr.Version = 3;

            SQLiteConnection sqlCon = new SQLiteConnection(conStr.ConnectionString);

            sqlCon.Open();

            SQLiteCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS users ( id INTEGER PRIMARY KEY AUTOINCREMENT, mailaddress VARCHAR(255) NOT NULL, password VARCHAR(255) NOT NULL, pop_hostname VARCHAR(255) not null, pop_port INTEGER not null, pop_ssl BOOLEAN not null )";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            //con.CreateFile("%appdata%/.mermail/mermail.db");




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
    }
}
