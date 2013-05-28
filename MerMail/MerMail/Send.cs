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
        public Send()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            MerMail.Program.SendMail(TB.Text, Subjectbox.Text, BodyBox.Text);
        }
    }
}
