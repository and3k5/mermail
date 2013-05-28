namespace MerMail
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
            this.SuspendLayout();
            // 
            // mailBox
            // 
            this.mailBox.FormattingEnabled = true;
            this.mailBox.Location = new System.Drawing.Point(12, 12);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(124, 329);
            this.mailBox.TabIndex = 5;
            this.mailBox.SelectedIndexChanged += new System.EventHandler(this.mailBox_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(169, 59);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(414, 218);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // label_hFrom
            // 
            this.label_hFrom.AutoSize = true;
            this.label_hFrom.Location = new System.Drawing.Point(166, 12);
            this.label_hFrom.Name = "label_hFrom";
            this.label_hFrom.Size = new System.Drawing.Size(33, 13);
            this.label_hFrom.TabIndex = 8;
            this.label_hFrom.Text = "From:";
            // 
            // label_Hsubject
            // 
            this.label_Hsubject.AutoSize = true;
            this.label_Hsubject.Location = new System.Drawing.Point(166, 30);
            this.label_Hsubject.Name = "label_Hsubject";
            this.label_Hsubject.Size = new System.Drawing.Size(46, 13);
            this.label_Hsubject.TabIndex = 9;
            this.label_Hsubject.Text = "Subject:";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(226, 12);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(18, 13);
            this.label_from.TabIndex = 10;
            this.label_from.Text = "@";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(226, 30);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(18, 13);
            this.label_subject.TabIndex = 11;
            this.label_subject.Text = "@";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_Hsubject);
            this.Controls.Add(this.label_hFrom);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.mailBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

