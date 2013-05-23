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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                mailBox.Items.Clear();
                List<OpenPop.Mime.Message> result = MerMail.Program.FetchAllMessages(HostNameBox.Text, Convert.ToInt32(PortBox.Text), useSslCheckbox.Checked, UserBox.Text, PassBox.Text);
                //mailBox.Items.
                foreach (OpenPop.Mime.Message mail in result) {
                    mailBox.Items.Add(mail.Headers.Subject);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..." + err.Message);
            }
        }

    }
}
