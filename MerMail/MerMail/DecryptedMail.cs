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
    public partial class DecryptedMail : Form
    {
        public MerMail.Program.email currentMail;
        public DecryptedMail(MerMail.Program.email mail)
        {
            currentMail = mail;
            InitializeComponent();
        }

        private void DecryptedMail_Load(object sender, EventArgs e)
        {
            label_from.Text = currentMail.sender;
            label_subject.Text = currentMail.subject;

            webBrowser1.Navigate("about:blank");
            HtmlDocument document = webBrowser1.Document;
            document.Write(String.Empty);
            webBrowser1.DocumentText = currentMail.body;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
