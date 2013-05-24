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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MerMail.Program.AuthenticateLog(HostNameBox.Text, Convert.ToInt32(PortBox.Text), useSslCheckbox.Checked, UserBox.Text, PassBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..." + err.Message);
            }
        }
    }
}
