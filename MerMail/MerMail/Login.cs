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
        private List<MerMail.Program.mailaccount> accounts;
        private void Login_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            accounts = MerMail.Program.getAccounts();
            comboBox1.Items.Clear();
            foreach (MerMail.Program.mailaccount acc in accounts)
            {
                comboBox1.Items.Add(acc.mailaddress);
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool auth = MerMail.Program.AuthenticateLog(HostNameBox.Text, Convert.ToInt32(PortBox.Text), useSslCheckbox.Checked, UserBox.Text, PassBox.Text);
                if (auth)
                {
                    MerMail.Program.insertUser(UserBox.Text, PassBox.Text, HostNameBox.Text, Convert.ToInt16(PortBox.Text), useSslCheckbox.Checked);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..." + err.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MerMail.Program.mailaccount selectedAccount = accounts.ToArray()[(sender as ComboBox).SelectedIndex];
            HostNameBox.Text = selectedAccount.pop_hostname;
            PortBox.Text = selectedAccount.pop_port.ToString();
            useSslCheckbox.Checked = selectedAccount.pop_ssl;
            UserBox.Text = selectedAccount.mailaddress;
            PassBox.Text = selectedAccount.password;
        }
    }
}
