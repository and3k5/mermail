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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void About_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = !pictureBox2.Visible;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            pictureBox2.Location = new Point(r.Next(0, this.Width - pictureBox2.Width), r.Next(0, this.Height - pictureBox2.Height));

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/and3k5/mermail");
        }
    }
}
