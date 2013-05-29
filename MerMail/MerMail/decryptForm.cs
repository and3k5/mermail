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
    public partial class decryptForm : Form
    {
        public decryptForm()
        {
            InitializeComponent();

        }
        //public MerMail.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox1.Checked;
        }

        private void decryptForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
