﻿namespace EmailClientATM
{
    partial class ImportantForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTimeBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplyBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SpamBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportantBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeBox,
            this.FromBox,
            this.SubjectBox,
            this.ContentBox,
            this.AttachmentBox,
            this.ReplyBox,
            this.SpamBox,
            this.DeleteBox,
            this.IdBox,
            this.ImportantBox,
            this.ID_Sender});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.HeaderText = "Date and Time";
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.ReadOnly = true;
            this.DateTimeBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FromBox
            // 
            this.FromBox.HeaderText = "From";
            this.FromBox.Name = "FromBox";
            this.FromBox.ReadOnly = true;
            this.FromBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FromBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubjectBox
            // 
            this.SubjectBox.HeaderText = "Subject";
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.ReadOnly = true;
            this.SubjectBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContentBox
            // 
            this.ContentBox.HeaderText = "Content";
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContentBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AttachmentBox
            // 
            this.AttachmentBox.HeaderText = "Attachment";
            this.AttachmentBox.Name = "AttachmentBox";
            this.AttachmentBox.ReadOnly = true;
            this.AttachmentBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AttachmentBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReplyBox
            // 
            this.ReplyBox.HeaderText = "Reply";
            this.ReplyBox.Name = "ReplyBox";
            this.ReplyBox.ReadOnly = true;
            // 
            // SpamBox
            // 
            this.SpamBox.HeaderText = "Spam";
            this.SpamBox.Name = "SpamBox";
            this.SpamBox.ReadOnly = true;
            // 
            // DeleteBox
            // 
            this.DeleteBox.HeaderText = "Delete";
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.ReadOnly = true;
            // 
            // IdBox
            // 
            this.IdBox.HeaderText = "Id";
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdBox.Visible = false;
            // 
            // ImportantBox
            // 
            this.ImportantBox.HeaderText = "Remove from Important";
            this.ImportantBox.Name = "ImportantBox";
            this.ImportantBox.ReadOnly = true;
            // 
            // ID_Sender
            // 
            this.ID_Sender.HeaderText = "ID_Sender";
            this.ID_Sender.Name = "ID_Sender";
            this.ID_Sender.ReadOnly = true;
            this.ID_Sender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Sender.Visible = false;
            // 
            // ImportantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 339);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImportantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Important";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentBox;
        private System.Windows.Forms.DataGridViewButtonColumn ReplyBox;
        private System.Windows.Forms.DataGridViewButtonColumn SpamBox;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBox;
        private System.Windows.Forms.DataGridViewButtonColumn ImportantBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sender;
    }
}