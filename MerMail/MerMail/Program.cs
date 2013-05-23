using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;

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
            Application.Run(new Form1());
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
