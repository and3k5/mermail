using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MerMail.Program.email> result;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            MerMail.Program.login();
            try
            {
                if (MerMail.Program.popauth)
                {
                    mailBox.Items.Clear();
                    result = new List<MerMail.Program.email>();
                    result = MerMail.Program.FetchAllMessages();
                    // List subjects in listbox
                    foreach (MerMail.Program.email mail in result)
                    {
                        mailBox.Items.Add(mail.subject);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..." + err.Message);
            }
        }

        private void mailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MerMail.Program.email currentMail = result.ToArray()[mailBox.SelectedIndex];
            // Goodmorning IE
            webBrowser1.Navigate("about:blank");
            HtmlDocument document = webBrowser1.Document;
            document.Write(String.Empty);
            webBrowser1.DocumentText = currentMail.body;
            label_from.Text = currentMail.sender;
            label_subject.Text = currentMail.subject;
            // Is MediaType multipart or not?
            /*switch (currentMail.MessagePart.ContentType.MediaType)
            {
                default:
                    webBrowser1.DocumentText = currentMail.FindFirstPlainTextVersion().GetBodyAsText();
                    break;
                case "multipart/alternative":
                    webBrowser1.DocumentText = currentMail.FindFirstHtmlVersion().GetBodyAsText();
                    break;
            }*/
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MerMail.Program.logout();
        }

    }
}
