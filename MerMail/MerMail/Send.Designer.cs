namespace MerMail
{
    partial class Send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send));
            this.TB = new System.Windows.Forms.TextBox();
            this.BodyBox = new System.Windows.Forms.RichTextBox();
            this.Subjectbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.useEncryption = new System.Windows.Forms.CheckBox();
            this.encSetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(64, 15);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(583, 20);
            this.TB.TabIndex = 0;
            // 
            // BodyBox
            // 
            this.BodyBox.Location = new System.Drawing.Point(12, 64);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(635, 359);
            this.BodyBox.TabIndex = 1;
            this.BodyBox.Text = "";
            // 
            // Subjectbox
            // 
            this.Subjectbox.Location = new System.Drawing.Point(64, 38);
            this.Subjectbox.Name = "Subjectbox";
            this.Subjectbox.Size = new System.Drawing.Size(583, 20);
            this.Subjectbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject:";
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(509, 429);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(138, 27);
            this.Sendbtn.TabIndex = 5;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // useEncryption
            // 
            this.useEncryption.AutoSize = true;
            this.useEncryption.Location = new System.Drawing.Point(241, 435);
            this.useEncryption.Name = "useEncryption";
            this.useEncryption.Size = new System.Drawing.Size(102, 17);
            this.useEncryption.TabIndex = 6;
            this.useEncryption.Text = "Encrypt this mail";
            this.useEncryption.UseVisualStyleBackColor = true;
            this.useEncryption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // encSetBtn
            // 
            this.encSetBtn.Enabled = false;
            this.encSetBtn.Location = new System.Drawing.Point(349, 431);
            this.encSetBtn.Name = "encSetBtn";
            this.encSetBtn.Size = new System.Drawing.Size(113, 23);
            this.encSetBtn.TabIndex = 7;
            this.encSetBtn.Text = "Encryption settings..";
            this.encSetBtn.UseVisualStyleBackColor = true;
            this.encSetBtn.Click += new System.EventHandler(this.encSetBtn_Click);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.encSetBtn);
            this.Controls.Add(this.useEncryption);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subjectbox);
            this.Controls.Add(this.BodyBox);
            this.Controls.Add(this.TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Send";
            this.Text = "Send";
            this.Load += new System.EventHandler(this.Send_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.RichTextBox BodyBox;
        private System.Windows.Forms.TextBox Subjectbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.CheckBox useEncryption;
        private System.Windows.Forms.Button encSetBtn;
    }
}