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
    public partial class Mailform : Form
    {
        public Mailform()
        {
            InitializeComponent();
            // Worker from POP3 to SQLite
            sqlMailworker = new BackgroundWorker();

            sqlMailworker.WorkerReportsProgress = true;

            sqlMailworker.DoWork += new DoWorkEventHandler(MerMail.Program.FetchAllMessages);
            sqlMailworker.ProgressChanged += new ProgressChangedEventHandler(workerProgress);
            sqlMailworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(workerDone);

            // Worker from SQLite to GUI
            outputWorker = new BackgroundWorker();

            outputWorker.DoWork += new DoWorkEventHandler(MerMail.Program.ImportMails);
            outputWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(showMails);

        }

        List<MerMail.Program.email> result;
        private BackgroundWorker sqlMailworker;
        private BackgroundWorker outputWorker;
        private void GetMailsFromServer()
        {
            if (!sqlMailworker.IsBusy)
            {
                toolStripStatusLabel1.Text = "Downloading mails..";
                toolStripProgressBar1.Visible = true;
                sqlMailworker.RunWorkerAsync();
            }
        }
        private void getMailsFromSql()
        {
            if (!outputWorker.IsBusy)
            {
                outputWorker.RunWorkerAsync();
            }
        }
        private void workerProgress(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }
        private void showMails(object sender, RunWorkerCompletedEventArgs e)
        {
            result = (List<MerMail.Program.email>)e.Result;
            mailBox.Items.Clear();
            foreach (MerMail.Program.email mail in result)
            {
                mailBox.Items.Add(mail.subject);
            }
            toolStripStatusLabel1.Text = "Mails collected..";
            mailBox.SetSelected(0, true);

        }
        private void workerDone(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Downloading mails complete..";
            toolStripProgressBar1.Visible = false;
            getMailsFromSql();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            MerMail.Program.login();
            timer();
            try
            {
                if (MerMail.Program.popauth)
                {
                    GetMailsFromServer();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Der skete en fejl..." + err.Message);
            }
        }

        static Timer RMT = new Timer();
        public void timer()
        {
            RMT.Tick += new EventHandler(TimerEvent);
            RMT.Interval = 300000;
            RMT.Start();
        }

        private void TimerEvent(object myobj, EventArgs timereventargs)
        {
            RMT.Stop();
            GetMailsFromServer(); 
            RMT.Enabled = true;
        }
        private MerMail.Program.email currentMail;
        private void mailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mailBox.SelectedIndex == -1) return;
            currentMail = result.ToArray()[mailBox.SelectedIndex];
            // Goodmorning IE
            webBrowser1.Navigate("about:blank");
            HtmlDocument document = webBrowser1.Document;
            document.Write(String.Empty);
            webBrowser1.DocumentText = currentMail.body;
            label_from.Text = currentMail.sender;
            label_subject.Text = currentMail.subject;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MerMail.Program.logout();
        }

        private void updateMailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetMailsFromServer(); 
        }

        private void sendMailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Send newsend = new Send();
            newsend.ShowDialog();
        }

        private void currentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decryptForm decForm = new decryptForm();
            if (decForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MerMail.Program.email decryptedMail = MerMail.Program.decryptMail(currentMail,decForm.rtnUseSymmetric,decForm.SymmetricKey,decForm.rtnUseAsymmetric,decForm.private_key);
                    DecryptedMail decMailForm = new DecryptedMail(decryptedMail);
                    decMailForm.Show();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Fejl ved decryptering:" + Environment.NewLine + err.Message);
                }
                //decForm.private_key
                //decForm.private
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog() ;
        }

    }
}
