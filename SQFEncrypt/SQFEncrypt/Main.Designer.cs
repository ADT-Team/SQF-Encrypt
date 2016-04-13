namespace SQFEncrypt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.FileInputBox = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptNumBox = new System.Windows.Forms.TextBox();
            this.PvarNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.GenPvarBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.GenToStringBtn = new System.Windows.Forms.Button();
            this.CopyToClipboardCheck = new System.Windows.Forms.CheckBox();
            this.stripComments = new System.Windows.Forms.CheckBox();
            this.saveFileCheck = new System.Windows.Forms.CheckBox();
            this.overwriteCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File:";
            // 
            // FileInputBox
            // 
            this.FileInputBox.Location = new System.Drawing.Point(13, 30);
            this.FileInputBox.Name = "FileInputBox";
            this.FileInputBox.Size = new System.Drawing.Size(405, 20);
            this.FileInputBox.TabIndex = 1;
            this.FileInputBox.TextChanged += new System.EventHandler(this.FileInputBox_TextChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(425, 30);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(90, 22);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypt Number:";
            // 
            // EncryptNumBox
            // 
            this.EncryptNumBox.Location = new System.Drawing.Point(12, 69);
            this.EncryptNumBox.Name = "EncryptNumBox";
            this.EncryptNumBox.Size = new System.Drawing.Size(86, 20);
            this.EncryptNumBox.TabIndex = 4;
            this.EncryptNumBox.TextChanged += new System.EventHandler(this.EncryptNumBox_TextChanged);
            // 
            // PvarNameBox
            // 
            this.PvarNameBox.Location = new System.Drawing.Point(123, 69);
            this.PvarNameBox.Name = "PvarNameBox";
            this.PvarNameBox.Size = new System.Drawing.Size(392, 20);
            this.PvarNameBox.TabIndex = 5;
            this.PvarNameBox.TextChanged += new System.EventHandler(this.PvarNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public Variable Name:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 95);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(503, 183);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // GenPvarBtn
            // 
            this.GenPvarBtn.Location = new System.Drawing.Point(12, 285);
            this.GenPvarBtn.Name = "GenPvarBtn";
            this.GenPvarBtn.Size = new System.Drawing.Size(99, 51);
            this.GenPvarBtn.TabIndex = 8;
            this.GenPvarBtn.Text = "Generate Public Variable Code";
            this.GenPvarBtn.UseVisualStyleBackColor = true;
            this.GenPvarBtn.Click += new System.EventHandler(this.GeneratePVarbtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(416, 285);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(99, 51);
            this.EncryptBtn.TabIndex = 9;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // GenToStringBtn
            // 
            this.GenToStringBtn.Location = new System.Drawing.Point(117, 284);
            this.GenToStringBtn.Name = "GenToStringBtn";
            this.GenToStringBtn.Size = new System.Drawing.Size(99, 51);
            this.GenToStringBtn.TabIndex = 10;
            this.GenToStringBtn.Text = "Generate toString statement";
            this.GenToStringBtn.UseVisualStyleBackColor = true;
            this.GenToStringBtn.Click += new System.EventHandler(this.GenToStringBtn_Click);
            // 
            // CopyToClipboardCheck
            // 
            this.CopyToClipboardCheck.AutoSize = true;
            this.CopyToClipboardCheck.Location = new System.Drawing.Point(222, 285);
            this.CopyToClipboardCheck.Name = "CopyToClipboardCheck";
            this.CopyToClipboardCheck.Size = new System.Drawing.Size(169, 17);
            this.CopyToClipboardCheck.TabIndex = 11;
            this.CopyToClipboardCheck.Text = "Copy To Clipboard On Encrypt";
            this.CopyToClipboardCheck.UseVisualStyleBackColor = true;
            // 
            // stripComments
            // 
            this.stripComments.AutoSize = true;
            this.stripComments.Location = new System.Drawing.Point(222, 318);
            this.stripComments.Name = "stripComments";
            this.stripComments.Size = new System.Drawing.Size(153, 17);
            this.stripComments.TabIndex = 12;
            this.stripComments.Text = "Strip Comments From Code";
            this.stripComments.UseVisualStyleBackColor = true;
            // 
            // saveFileCheck
            // 
            this.saveFileCheck.AutoSize = true;
            this.saveFileCheck.Location = new System.Drawing.Point(222, 302);
            this.saveFileCheck.Name = "saveFileCheck";
            this.saveFileCheck.Size = new System.Drawing.Size(89, 17);
            this.saveFileCheck.TabIndex = 13;
            this.saveFileCheck.Text = "Save To  File";
            this.saveFileCheck.UseVisualStyleBackColor = true;
            // 
            // overwriteCheck
            // 
            this.overwriteCheck.AutoSize = true;
            this.overwriteCheck.Location = new System.Drawing.Point(317, 302);
            this.overwriteCheck.Name = "overwriteCheck";
            this.overwriteCheck.Size = new System.Drawing.Size(71, 17);
            this.overwriteCheck.TabIndex = 14;
            this.overwriteCheck.Text = "Overwrite";
            this.overwriteCheck.UseVisualStyleBackColor = true;
            this.overwriteCheck.CheckedChanged += new System.EventHandler(this.overwriteCheck_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.overwriteCheck);
            this.Controls.Add(this.saveFileCheck);
            this.Controls.Add(this.stripComments);
            this.Controls.Add(this.CopyToClipboardCheck);
            this.Controls.Add(this.GenToStringBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.GenPvarBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PvarNameBox);
            this.Controls.Add(this.EncryptNumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.FileInputBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "SQF Encrypt - By Shix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileInputBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptNumBox;
        private System.Windows.Forms.TextBox PvarNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button GenPvarBtn;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button GenToStringBtn;
        private System.Windows.Forms.CheckBox CopyToClipboardCheck;
        private System.Windows.Forms.CheckBox stripComments;
        private System.Windows.Forms.CheckBox saveFileCheck;
        private System.Windows.Forms.CheckBox overwriteCheck;
    }
}

