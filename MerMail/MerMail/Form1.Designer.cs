﻿namespace MerMail
{
    partial class Form1
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
            this.mailBox = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label_hFrom = new System.Windows.Forms.Label();
            this.label_Hsubject = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_subject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mailBox
            // 
            this.mailBox.FormattingEnabled = true;
            this.mailBox.Location = new System.Drawing.Point(12, 27);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(124, 329);
            this.mailBox.TabIndex = 5;
            this.mailBox.SelectedIndexChanged += new System.EventHandler(this.mailBox_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(169, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(414, 218);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // label_hFrom
            // 
            this.label_hFrom.AutoSize = true;
            this.label_hFrom.Location = new System.Drawing.Point(166, 27);
            this.label_hFrom.Name = "label_hFrom";
            this.label_hFrom.Size = new System.Drawing.Size(33, 13);
            this.label_hFrom.TabIndex = 8;
            this.label_hFrom.Text = "From:";
            // 
            // label_Hsubject
            // 
            this.label_Hsubject.AutoSize = true;
            this.label_Hsubject.Location = new System.Drawing.Point(166, 45);
            this.label_Hsubject.Name = "label_Hsubject";
            this.label_Hsubject.Size = new System.Drawing.Size(46, 13);
            this.label_Hsubject.TabIndex = 9;
            this.label_Hsubject.Text = "Subject:";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(226, 27);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(18, 13);
            this.label_from.TabIndex = 10;
            this.label_from.Text = "@";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(226, 45);
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
            this.encryptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
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
            this.updateMailsToolStripMenuItem1,
            this.sendMailToolStripMenuItem1});
            this.mailsToolStripMenuItem.Name = "mailsToolStripMenuItem";
            this.mailsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.mailsToolStripMenuItem.Text = "Mail";
            // 
            // updateMailsToolStripMenuItem1
            // 
            this.updateMailsToolStripMenuItem1.Name = "updateMailsToolStripMenuItem1";
            this.updateMailsToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.updateMailsToolStripMenuItem1.Text = "Update mails";
            this.updateMailsToolStripMenuItem1.Click += new System.EventHandler(this.updateMailsToolStripMenuItem1_Click);
            // 
            // sendMailToolStripMenuItem1
            // 
            this.sendMailToolStripMenuItem1.Name = "sendMailToolStripMenuItem1";
            this.sendMailToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.sendMailToolStripMenuItem1.Text = "Send mail";
            this.sendMailToolStripMenuItem1.Click += new System.EventHandler(this.sendMailToolStripMenuItem1_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptToolStripMenuItem,
            this.encryptToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentMailToolStripMenuItem});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // currentMailToolStripMenuItem
            // 
            this.currentMailToolStripMenuItem.Name = "currentMailToolStripMenuItem";
            this.currentMailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.currentMailToolStripMenuItem.Text = "Current Mail";
            this.currentMailToolStripMenuItem.Click += new System.EventHandler(this.currentMailToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripMenuItem});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // newMailToolStripMenuItem
            // 
            this.newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            this.newMailToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newMailToolStripMenuItem.Text = "New Mail";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_Hsubject);
            this.Controls.Add(this.label_hFrom);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMailToolStripMenuItem;
    }
}

