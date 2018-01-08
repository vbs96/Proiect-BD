namespace EmailClientATM
{
    partial class MainForm
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
            this.InboxButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ImportantButton = new System.Windows.Forms.Button();
            this.SpamButton = new System.Windows.Forms.Button();
            this.TrashButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InboxButton
            // 
            this.InboxButton.Location = new System.Drawing.Point(39, 26);
            this.InboxButton.Name = "InboxButton";
            this.InboxButton.Size = new System.Drawing.Size(160, 46);
            this.InboxButton.TabIndex = 0;
            this.InboxButton.Text = "Inbox";
            this.InboxButton.UseVisualStyleBackColor = true;
            this.InboxButton.Click += new System.EventHandler(this.InboxButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(39, 78);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(160, 48);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // ImportantButton
            // 
            this.ImportantButton.Location = new System.Drawing.Point(39, 132);
            this.ImportantButton.Name = "ImportantButton";
            this.ImportantButton.Size = new System.Drawing.Size(160, 53);
            this.ImportantButton.TabIndex = 2;
            this.ImportantButton.Text = "Important";
            this.ImportantButton.UseVisualStyleBackColor = true;
            this.ImportantButton.Click += new System.EventHandler(this.ImportantButton_Click);
            // 
            // SpamButton
            // 
            this.SpamButton.Location = new System.Drawing.Point(39, 191);
            this.SpamButton.Name = "SpamButton";
            this.SpamButton.Size = new System.Drawing.Size(160, 48);
            this.SpamButton.TabIndex = 3;
            this.SpamButton.Text = "Spam";
            this.SpamButton.UseVisualStyleBackColor = true;
            this.SpamButton.Click += new System.EventHandler(this.SpamButton_Click);
            // 
            // TrashButton
            // 
            this.TrashButton.Location = new System.Drawing.Point(39, 245);
            this.TrashButton.Name = "TrashButton";
            this.TrashButton.Size = new System.Drawing.Size(160, 42);
            this.TrashButton.TabIndex = 4;
            this.TrashButton.Text = "Trash";
            this.TrashButton.UseVisualStyleBackColor = true;
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(168, 293);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(75, 23);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 325);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.TrashButton);
            this.Controls.Add(this.SpamButton);
            this.Controls.Add(this.ImportantButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.InboxButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailClientATM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InboxButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ImportantButton;
        private System.Windows.Forms.Button SpamButton;
        private System.Windows.Forms.Button TrashButton;
        private System.Windows.Forms.Button SignOutButton;
    }
}