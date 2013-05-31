namespace MerMail
{
    partial class Mailform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mailform));
            this.mailBox = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label_hFrom = new System.Windows.Forms.Label();
            this.label_Hsubject = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_subject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mailBox
            // 
            this.mailBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mailBox.FormattingEnabled = true;
            this.mailBox.ItemHeight = 16;
            this.mailBox.Location = new System.Drawing.Point(12, 27);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(124, 468);
            this.mailBox.TabIndex = 5;
            this.mailBox.SelectedIndexChanged += new System.EventHandler(this.mailBox_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(142, 76);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(573, 416);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // label_hFrom
            // 
            this.label_hFrom.AutoSize = true;
            this.label_hFrom.Location = new System.Drawing.Point(142, 27);
            this.label_hFrom.Name = "label_hFrom";
            this.label_hFrom.Size = new System.Drawing.Size(33, 13);
            this.label_hFrom.TabIndex = 8;
            this.label_hFrom.Text = "From:";
            // 
            // label_Hsubject
            // 
            this.label_Hsubject.AutoSize = true;
            this.label_Hsubject.Location = new System.Drawing.Point(142, 45);
            this.label_Hsubject.Name = "label_Hsubject";
            this.label_Hsubject.Size = new System.Drawing.Size(46, 13);
            this.label_Hsubject.TabIndex = 9;
            this.label_Hsubject.Text = "Subject:";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(181, 27);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(18, 13);
            this.label_from.TabIndex = 10;
            this.label_from.Text = "@";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(194, 45);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(18, 13);
            this.label_subject.TabIndex = 11;
            this.label_subject.Text = "@";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.mailsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mailsToolStripMenuItem
            // 
            this.mailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMailToolStripMenuItem1,
            this.updateMailsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.mailsToolStripMenuItem.Name = "mailsToolStripMenuItem";
            this.mailsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.mailsToolStripMenuItem.Text = "Mail";
            // 
            // sendMailToolStripMenuItem1
            // 
            this.sendMailToolStripMenuItem1.Name = "sendMailToolStripMenuItem1";
            this.sendMailToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sendMailToolStripMenuItem1.Text = "New mail";
            this.sendMailToolStripMenuItem1.Click += new System.EventHandler(this.sendMailToolStripMenuItem1_Click);
            // 
            // updateMailsToolStripMenuItem1
            // 
            this.updateMailsToolStripMenuItem1.Name = "updateMailsToolStripMenuItem1";
            this.updateMailsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updateMailsToolStripMenuItem1.Text = "Check mails";
            this.updateMailsToolStripMenuItem1.Click += new System.EventHandler(this.updateMailsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Encryption";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem2.Text = "Decrypt current mail";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.currentMailToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 50;
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Mailform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 523);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_Hsubject);
            this.Controls.Add(this.label_hFrom);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Mailform";
            this.Text = "Mer Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mailBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label_hFrom;
        private System.Windows.Forms.Label label_Hsubject;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

