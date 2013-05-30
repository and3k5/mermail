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
    public partial class encryptForm : Form
    {
        public encryptForm()
        {
            InitializeComponent();
        }

        public bool rtnUseSymmetric = false;
        public bool rtnUseAsymmetric = false;
        public bool validSymmetric = false;
        public bool validAsymmetric = false;
        public string SymmetricKey = null;
        public Asymmetric.Key public_key;

        private void updateControls()
        {
            groupSymmetric.Enabled = useSymmetric.Checked;
            groupAsymmetric.Enabled = symmetricAsymmetricEncrypted.Checked;
            rtnUseSymmetric = useSymmetric.Checked;
            rtnUseAsymmetric = symmetricAsymmetricEncrypted.Checked;

            if (rtnUseSymmetric)
            {
                if (symmetricTextRadio.Checked)
                {
                    if ((symmetricTextBox.TextLength == (128 / 8)) || (symmetricTextBox.TextLength == (192 / 8)))
                    {
                        symmetricTextBox.BackColor = Color.Green;
                        SymmetricKey = symmetricTextBox.Text;
                        validSymmetric = true;
                    }
                    else
                    {
                        symmetricTextBox.BackColor = Color.Red;
                    }
                }
            }
            symmetricStatusLabel.Text = "Symmetric key: ";
            if (validSymmetric)
            {
                symmetricStatusLabel.Text += "OK";
                symmetricStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                symmetricStatusLabel.Text += "NOT OK";
                symmetricStatusLabel.ForeColor = Color.Red;
            }
            asymmetricStatusLabel.Text = "Asymmetric key: ";
            if (validAsymmetric)
            {
                asymmetricStatusLabel.Text += "OK";
                asymmetricStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                asymmetricStatusLabel.Text += "NOT OK";
                asymmetricStatusLabel.ForeColor = Color.Red;
            }
        }

        private void encryptForm_Load(object sender, EventArgs e)
        {
            updateControls();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateControls();
        }

        private void decryptForm_Load(object sender, EventArgs e)
        {
            updateControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            symmetricFileRadio.Checked = true;

            MerMail.Program.MFile file = MerMail.Program.openFile("", "Open symmetric key", "Any (*.*)", "*.*");
            if (file.valid)
            {
                SymmetricKey = file.data;
                symKeyFilename.Text = file.filename;
                validSymmetric = true;
            }
            else
            {
                validSymmetric = false;
            }
            updateControls();
        }

        private void symmetricAsymmetricEncrypted_CheckedChanged(object sender, EventArgs e)
        {
            updateControls();
        }

        private void loadAsymmetricFromFileBtn_Click(object sender, EventArgs e)
        {
            asymmetricFileRadio.Checked = true;
            MerMail.Program.MFile file = MerMail.Program.openFile("publickey.pke", "Open public key", "Private key (*.pke)", "*.pke");
            if (file.valid)
            {
                bool succes = true;
                try
                {
                    public_key = MerMail.Asymmetric.parseKeyXML(file.data);
                }
                catch (Exception err)
                {
                    succes = false;
                }
                if (succes)
                {
                    asymKeyFilename.Text = file.filename;
                    validAsymmetric = true;
                }
                else
                {
                    validAsymmetric = false;
                }
            }
            else
            {
                validAsymmetric = false;
            }
            updateControls();
        }

        private void symmetricTextBox_TextChanged(object sender, EventArgs e)
        {
            symmetricTextRadio.Checked = true;

            updateControls();
        }

        private void asymmetricTextBox_TextChanged(object sender, EventArgs e)
        {
            asymmetricTextRadio.Checked = true;
            updateControls();
        }

        private void symmetricTextBox_Enter(object sender, EventArgs e)
        {
            symmetricTextRadio.Checked = true;
            updateControls();
        }

        private void asymmetricTextBox_Enter(object sender, EventArgs e)
        {
            asymmetricTextRadio.Checked = true;
            updateControls();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string pubKey=MerMail.Asymmetric.generateKeys(Convert.ToInt16(bytestrengthNum.Value));
            if (pubKey != null)
            {
                bool succes = true;
                try
                {
                    public_key = MerMail.Asymmetric.parseKeyXML(System.IO.File.OpenText(pubKey).ReadToEnd());
                }
                catch (Exception err)
                {
                    succes = false;
                }
                if (succes)
                {
                    asymKeyFilename.Text = new System.IO.FileInfo(pubKey).Name;
                    validAsymmetric = true;
                }
                else
                {
                    validAsymmetric = false;
                }
            }
            updateControls();
        }
    }
}
