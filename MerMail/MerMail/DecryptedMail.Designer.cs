namespace MerMail
{
    partial class DecryptedMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptedMail));
            this.label_subject = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_Hsubject = new System.Windows.Forms.Label();
            this.label_hFrom = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(69, 29);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(18, 13);
            this.label_subject.TabIndex = 16;
            this.label_subject.Text = "@";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(69, 11);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(18, 13);
            this.label_from.TabIndex = 15;
            this.label_from.Text = "@";
            // 
            // label_Hsubject
            // 
            this.label_Hsubject.AutoSize = true;
            this.label_Hsubject.Location = new System.Drawing.Point(9, 29);
            this.label_Hsubject.Name = "label_Hsubject";
            this.label_Hsubject.Size = new System.Drawing.Size(46, 13);
            this.label_Hsubject.TabIndex = 14;
            this.label_Hsubject.Text = "Subject:";
            // 
            // label_hFrom
            // 
            this.label_hFrom.AutoSize = true;
            this.label_hFrom.Location = new System.Drawing.Point(9, 11);
            this.label_hFrom.Name = "label_hFrom";
            this.label_hFrom.Size = new System.Drawing.Size(33, 13);
            this.label_hFrom.TabIndex = 13;
            this.label_hFrom.Text = "From:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(414, 218);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecryptedMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_Hsubject);
            this.Controls.Add(this.label_hFrom);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptedMail";
            this.Text = "DecryptedMail";
            this.Load += new System.EventHandler(this.DecryptedMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_Hsubject;
        private System.Windows.Forms.Label label_hFrom;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}