using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerMail;

namespace MerMail
{
    public partial class decryptForm : Form
    {
        public decryptForm()
        {
            InitializeComponent();

        }
        
        public string SymmetricKey;
        public Asymmetric.Key private_key;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupSymmetric.Enabled = useSymmetric.Checked;
        }

        private void decryptForm_Load(object sender, EventArgs e)
        {
            groupSymmetric.Enabled = useSymmetric.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
