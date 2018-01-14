namespace EmailClientATM
{
    partial class CreateMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMessageForm));
            this.SendButton = new System.Windows.Forms.Button();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.subjTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.AttachmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(516, 260);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(68, 13);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(523, 20);
            this.toTextBox.TabIndex = 2;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(18, 13);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(18, 46);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(43, 13);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject";
            // 
            // subjTextBox
            // 
            this.subjTextBox.Location = new System.Drawing.Point(68, 46);
            this.subjTextBox.Name = "subjTextBox";
            this.subjTextBox.Size = new System.Drawing.Size(523, 20);
            this.subjTextBox.TabIndex = 5;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(68, 73);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(523, 181);
            this.contentTextBox.TabIndex = 6;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(18, 73);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 7;
            this.ContentLabel.Text = "Content";
            // 
            // AttachmentButton
            // 
            this.AttachmentButton.Location = new System.Drawing.Point(68, 259);
            this.AttachmentButton.Name = "AttachmentButton";
            this.AttachmentButton.Size = new System.Drawing.Size(75, 23);
            this.AttachmentButton.TabIndex = 8;
            this.AttachmentButton.Text = "Attachment";
            this.AttachmentButton.UseVisualStyleBackColor = true;
            this.AttachmentButton.Click += new System.EventHandler(this.AttachmentButton_Click);
            // 
            // CreateMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 295);
            this.Controls.Add(this.AttachmentButton);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.subjTextBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateMessageForm";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.CreateMessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox subjTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Button AttachmentButton;
    }
}