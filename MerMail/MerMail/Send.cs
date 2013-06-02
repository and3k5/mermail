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
    public partial class Send : Form
    {
        //makes the tooltips
        ToolTip TBtip = new ToolTip();
        ToolTip SubjectTip = new ToolTip();
        ToolTip MailTip = new ToolTip();

        public Send()
        {
            InitializeComponent();
            
            //show and injects the data
            TBtip.ShowAlways = true;
            TBtip.SetToolTip(TB, "Send mail To");
            SubjectTip.ShowAlways = true;
            SubjectTip.SetToolTip(Subjectbox, "What is the subject");
            MailTip.ShowAlways = true;
            MailTip.SetToolTip(BodyBox, "Type Your Mail here");
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            //Makes the mail
            MerMail.Program.email mail = new MerMail.Program.email(TB.Text, Subjectbox.Text, BodyBox.Text);
            if (useEncryption.Checked)
            {
                try
                {
                    //encypts the body id checkbox is checked
                    mail = MerMail.Program.encryptMail(mail, useSymmetric, SymmetricKey, useAsymmetric, public_key);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Fejl ved encryptering:" + Environment.NewLine + err.Message);
                    return;
                }
            }
            //sends the mail
            MerMail.Program.SendMail(mail.to, mail.subject, mail.body);
            this.Close();
        }

        private void Send_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            encSetBtn.Enabled = useEncryption.Checked;
        }
        //sets some public/global values
        public bool useSymmetric = false;
        public bool useAsymmetric = false;
        public MerMail.Asymmetric.Key public_key = new MerMail.Asymmetric.Key();
        public string SymmetricKey = "";
        private void encSetBtn_Click(object sender, EventArgs e)
        {
            //shows the encryption form
            encryptForm encForm = new encryptForm();
            if (encForm.ShowDialog() == DialogResult.OK)
            {
                useSymmetric = encForm.rtnUseSymmetric;
                useAsymmetric = encForm.rtnUseAsymmetric;
                public_key = encForm.public_key;
                SymmetricKey = encForm.SymmetricKey;
            }
        }
    }
}
