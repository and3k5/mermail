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
        //Makes the tooltips
        ToolTip PopHostNTP = new ToolTip();
        ToolTip PopPortTP = new ToolTip();
        ToolTip PopSSLTP = new ToolTip();
        ToolTip SmtpHostNTP = new ToolTip();
        ToolTip SmtpPortTP = new ToolTip();
        ToolTip SmtpSSLTP = new ToolTip();
        ToolTip UserTP = new ToolTip();
        ToolTip PassTP = new ToolTip();
        ToolTip ComboTP = new ToolTip();
        ToolTip loginbtnTP = new ToolTip();
        public Login()
        {
            InitializeComponent();
            #region tooltips
            //Makes tooltips visible and defines what is shown in the tooltip
            PopHostNTP.ShowAlways = true;
            PopPortTP.ShowAlways = true;
            PopSSLTP.ShowAlways = true;
            SmtpHostNTP.ShowAlways = true;
            SmtpPortTP.ShowAlways = true;
            SmtpSSLTP.ShowAlways = true;
            UserTP.ShowAlways = true;
            PassTP.ShowAlways = true;
            ComboTP.ShowAlways = true;
            loginbtnTP.ShowAlways = true;
            PopHostNTP.SetToolTip(HostNameBox,"POP servername");
            PopPortTP.SetToolTip(PortBox, "POP Port NR");
            PopSSLTP.SetToolTip(useSslCheckbox, "Use POP SSL?");
            SmtpHostNTP.SetToolTip(SmtpName, "SMTP servername");
            SmtpPortTP.SetToolTip(SmtpPort, "SMTP port");
            SmtpSSLTP.SetToolTip(usesmtpssl, "Use SMTP SSL?");
            UserTP.SetToolTip(UserBox, "Email or username to the POP- and SMTP-server");
            PassTP.SetToolTip(PassBox, "Password");
            ComboTP.SetToolTip(comboBox1, "Previus users on this pc");
            loginbtnTP.SetToolTip(loginBtn, "Login");
            #endregion
        }
        private List<MerMail.Program.mailaccount> accounts;
        private void Login_Load(object sender, EventArgs e)
        {
            //makes shortcut to call a function from program.cs
            accounts = MerMail.Program.getAccounts();
            
            //clear the combobox
            comboBox1.Items.Clear();
            
            //adds the users to the combobox
            foreach (MerMail.Program.mailaccount acc in accounts)
            {
                comboBox1.Items.Add(acc.mailaddress);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the user can be connectec with to the mailserver
                bool auth = MerMail.Program.AuthenticateLog(HostNameBox.Text, Convert.ToInt32(PortBox.Text), useSslCheckbox.Checked, UserBox.Text, PassBox.Text);
                if (auth)
                {
                    //if it connects add it to the databse over users
                    MerMail.Program.insertUser(UserBox.Text, PassBox.Text, HostNameBox.Text, Convert.ToInt16(PortBox.Text), useSslCheckbox.Checked,SmtpName.Text,Convert.ToInt16(SmtpPort.Text),usesmtpssl.Checked);
                    
                    //changes the dialogresult
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
            //when you change user from the combobox then it fills in the data to the fields (username, hostname, etc..)
            MerMail.Program.mailaccount selectedAccount = accounts.ToArray()[(sender as ComboBox).SelectedIndex];
            HostNameBox.Text = selectedAccount.pop_hostname;
            PortBox.Text = selectedAccount.pop_port.ToString();
            useSslCheckbox.Checked = selectedAccount.pop_ssl;
            UserBox.Text = selectedAccount.mailaddress;
            PassBox.Text = selectedAccount.password;
            SmtpName.Text = selectedAccount.smtp_hostname;
            SmtpPort.Text = selectedAccount.smtp_port.ToString();
        }
    }
}
