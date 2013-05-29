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
        ToolTip TBtip = new ToolTip();
        ToolTip SubjectTip = new ToolTip();
        ToolTip MailTip = new ToolTip();

        public Send()
        {
            InitializeComponent();
            
            TBtip.ShowAlways = true;
            TBtip.SetToolTip(TB, "Send mail To");
            
            SubjectTip.ShowAlways = true;
            SubjectTip.SetToolTip(Subjectbox, "What is the subject");
            
            MailTip.ShowAlways = true;
            MailTip.SetToolTip(BodyBox, "Type Your Mail here");
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            MerMail.Program.SendMail(TB.Text, Subjectbox.Text, BodyBox.Text);
            this.Close();
        }

        private void Send_Load(object sender, EventArgs e)
        {
            
        }
    }
}
