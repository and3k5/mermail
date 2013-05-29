namespace MerMail
{
    partial class decryptForm
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
            this.useSymmetric = new System.Windows.Forms.CheckBox();
            this.symmetricTextBox = new System.Windows.Forms.TextBox();
            this.symmetricAsymmetricEncrypted = new System.Windows.Forms.CheckBox();
            this.symmetricFileRadio = new System.Windows.Forms.RadioButton();
            this.loadSymmetricFromFileBtn = new System.Windows.Forms.Button();
            this.symmetricTextRadio = new System.Windows.Forms.RadioButton();
            this.groupSymmetric = new System.Windows.Forms.GroupBox();
            this.loadAsymmetricFromFileBtn = new System.Windows.Forms.Button();
            this.asymmetricGroup = new System.Windows.Forms.GroupBox();
            this.asymmetricFileRadio = new System.Windows.Forms.RadioButton();
            this.asymmetricTextRadio = new System.Windows.Forms.RadioButton();
            this.asymmetricTextBox = new System.Windows.Forms.TextBox();
            this.groupSymmetric.SuspendLayout();
            this.asymmetricGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // useSymmetric
            // 
            this.useSymmetric.AutoSize = true;
            this.useSymmetric.Location = new System.Drawing.Point(12, 12);
            this.useSymmetric.Name = "useSymmetric";
            this.useSymmetric.Size = new System.Drawing.Size(114, 17);
            this.useSymmetric.TabIndex = 0;
            this.useSymmetric.Text = "Use symmetric key";
            this.useSymmetric.UseVisualStyleBackColor = true;
            this.useSymmetric.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // symmetricTextBox
            // 
            this.symmetricTextBox.Location = new System.Drawing.Point(36, 111);
            this.symmetricTextBox.Multiline = true;
            this.symmetricTextBox.Name = "symmetricTextBox";
            this.symmetricTextBox.Size = new System.Drawing.Size(195, 56);
            this.symmetricTextBox.TabIndex = 2;
            // 
            // symmetricAsymmetricEncrypted
            // 
            this.symmetricAsymmetricEncrypted.AutoSize = true;
            this.symmetricAsymmetricEncrypted.Location = new System.Drawing.Point(23, 173);
            this.symmetricAsymmetricEncrypted.Name = "symmetricAsymmetricEncrypted";
            this.symmetricAsymmetricEncrypted.Size = new System.Drawing.Size(209, 17);
            this.symmetricAsymmetricEncrypted.TabIndex = 3;
            this.symmetricAsymmetricEncrypted.Text = "Symmetric key is asymmetric encrypted";
            this.symmetricAsymmetricEncrypted.UseVisualStyleBackColor = true;
            // 
            // symmetricFileRadio
            // 
            this.symmetricFileRadio.AutoSize = true;
            this.symmetricFileRadio.Location = new System.Drawing.Point(23, 32);
            this.symmetricFileRadio.Name = "symmetricFileRadio";
            this.symmetricFileRadio.Size = new System.Drawing.Size(41, 17);
            this.symmetricFileRadio.TabIndex = 4;
            this.symmetricFileRadio.TabStop = true;
            this.symmetricFileRadio.Text = "File";
            this.symmetricFileRadio.UseVisualStyleBackColor = true;
            // 
            // loadSymmetricFromFileBtn
            // 
            this.loadSymmetricFromFileBtn.Location = new System.Drawing.Point(36, 55);
            this.loadSymmetricFromFileBtn.Name = "loadSymmetricFromFileBtn";
            this.loadSymmetricFromFileBtn.Size = new System.Drawing.Size(195, 23);
            this.loadSymmetricFromFileBtn.TabIndex = 5;
            this.loadSymmetricFromFileBtn.Text = "Load symmetric key from file";
            this.loadSymmetricFromFileBtn.UseVisualStyleBackColor = true;
            this.loadSymmetricFromFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // symmetricTextRadio
            // 
            this.symmetricTextRadio.AutoSize = true;
            this.symmetricTextRadio.Location = new System.Drawing.Point(23, 88);
            this.symmetricTextRadio.Name = "symmetricTextRadio";
            this.symmetricTextRadio.Size = new System.Drawing.Size(46, 17);
            this.symmetricTextRadio.TabIndex = 6;
            this.symmetricTextRadio.TabStop = true;
            this.symmetricTextRadio.Text = "Text";
            this.symmetricTextRadio.UseVisualStyleBackColor = true;
            // 
            // groupSymmetric
            // 
            this.groupSymmetric.Controls.Add(this.asymmetricGroup);
            this.groupSymmetric.Controls.Add(this.symmetricAsymmetricEncrypted);
            this.groupSymmetric.Controls.Add(this.symmetricTextRadio);
            this.groupSymmetric.Controls.Add(this.symmetricTextBox);
            this.groupSymmetric.Controls.Add(this.loadSymmetricFromFileBtn);
            this.groupSymmetric.Controls.Add(this.symmetricFileRadio);
            this.groupSymmetric.Location = new System.Drawing.Point(24, 35);
            this.groupSymmetric.Name = "groupSymmetric";
            this.groupSymmetric.Size = new System.Drawing.Size(299, 401);
            this.groupSymmetric.TabIndex = 7;
            this.groupSymmetric.TabStop = false;
            this.groupSymmetric.Text = "Symmetric options";
            // 
            // loadAsymmetricFromFileBtn
            // 
            this.loadAsymmetricFromFileBtn.Location = new System.Drawing.Point(31, 45);
            this.loadAsymmetricFromFileBtn.Name = "loadAsymmetricFromFileBtn";
            this.loadAsymmetricFromFileBtn.Size = new System.Drawing.Size(195, 23);
            this.loadAsymmetricFromFileBtn.TabIndex = 7;
            this.loadAsymmetricFromFileBtn.Text = "Load asymmetric key from file";
            this.loadAsymmetricFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // asymmetricGroup
            // 
            this.asymmetricGroup.Controls.Add(this.asymmetricTextBox);
            this.asymmetricGroup.Controls.Add(this.asymmetricTextRadio);
            this.asymmetricGroup.Controls.Add(this.asymmetricFileRadio);
            this.asymmetricGroup.Controls.Add(this.loadAsymmetricFromFileBtn);
            this.asymmetricGroup.Location = new System.Drawing.Point(23, 196);
            this.asymmetricGroup.Name = "asymmetricGroup";
            this.asymmetricGroup.Size = new System.Drawing.Size(250, 172);
            this.asymmetricGroup.TabIndex = 8;
            this.asymmetricGroup.TabStop = false;
            this.asymmetricGroup.Text = "Asymmetric options";
            // 
            // asymmetricFileRadio
            // 
            this.asymmetricFileRadio.AutoSize = true;
            this.asymmetricFileRadio.Location = new System.Drawing.Point(16, 22);
            this.asymmetricFileRadio.Name = "asymmetricFileRadio";
            this.asymmetricFileRadio.Size = new System.Drawing.Size(41, 17);
            this.asymmetricFileRadio.TabIndex = 8;
            this.asymmetricFileRadio.TabStop = true;
            this.asymmetricFileRadio.Text = "File";
            this.asymmetricFileRadio.UseVisualStyleBackColor = true;
            // 
            // asymmetricTextRadio
            // 
            this.asymmetricTextRadio.AutoSize = true;
            this.asymmetricTextRadio.Location = new System.Drawing.Point(16, 74);
            this.asymmetricTextRadio.Name = "asymmetricTextRadio";
            this.asymmetricTextRadio.Size = new System.Drawing.Size(46, 17);
            this.asymmetricTextRadio.TabIndex = 9;
            this.asymmetricTextRadio.TabStop = true;
            this.asymmetricTextRadio.Text = "Text";
            this.asymmetricTextRadio.UseVisualStyleBackColor = true;
            // 
            // asymmetricTextBox
            // 
            this.asymmetricTextBox.Location = new System.Drawing.Point(31, 97);
            this.asymmetricTextBox.Multiline = true;
            this.asymmetricTextBox.Name = "asymmetricTextBox";
            this.asymmetricTextBox.Size = new System.Drawing.Size(195, 56);
            this.asymmetricTextBox.TabIndex = 10;
            // 
            // decryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 448);
            this.Controls.Add(this.groupSymmetric);
            this.Controls.Add(this.useSymmetric);
            this.Name = "decryptForm";
            this.Text = "decryptForm";
            this.Load += new System.EventHandler(this.decryptForm_Load);
            this.groupSymmetric.ResumeLayout(false);
            this.groupSymmetric.PerformLayout();
            this.asymmetricGroup.ResumeLayout(false);
            this.asymmetricGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useSymmetric;
        private System.Windows.Forms.TextBox symmetricTextBox;
        private System.Windows.Forms.CheckBox symmetricAsymmetricEncrypted;
        private System.Windows.Forms.RadioButton symmetricFileRadio;
        private System.Windows.Forms.Button loadSymmetricFromFileBtn;
        private System.Windows.Forms.RadioButton symmetricTextRadio;
        private System.Windows.Forms.GroupBox groupSymmetric;
        private System.Windows.Forms.GroupBox asymmetricGroup;
        private System.Windows.Forms.TextBox asymmetricTextBox;
        private System.Windows.Forms.RadioButton asymmetricTextRadio;
        private System.Windows.Forms.RadioButton asymmetricFileRadio;
        private System.Windows.Forms.Button loadAsymmetricFromFileBtn;
    }
}