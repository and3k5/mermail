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
            MerMail.Program.login();
        }

        List<OpenPop.Mime.Message> result;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (MerMail.Program.popauth)
                {
                    mailBox.Items.Clear();
                    result = MerMail.Program.FetchAllMessages();
                    // List subjects in listbox
                    foreach (OpenPop.Mime.Message mail in result)
                    {
                        mailBox.Items.Add(mail.Headers.Subject);
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
            OpenPop.Mime.Message currentMail = result.ToArray()[mailBox.SelectedIndex];
            // Goodmorning IE
            webBrowser1.Navigate("about:blank");
            HtmlDocument document = webBrowser1.Document;
            document.Write(String.Empty);
            // Is MediaType multipart or not?
            switch (currentMail.MessagePart.ContentType.MediaType)
            {
                default:
                    webBrowser1.DocumentText = currentMail.FindFirstPlainTextVersion().GetBodyAsText();
                    break;
                case "multipart/alternative":
                    webBrowser1.DocumentText = currentMail.FindFirstHtmlVersion().GetBodyAsText();
                    break;
            }
        }

    }
}
