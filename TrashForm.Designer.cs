﻿namespace EmailClientATM
{
    partial class TrashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContinutBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachamentBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveFromTrashBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateBox,
            this.FromBox,
            this.SubjectBox,
            this.ContinutBox,
            this.AttachamentBox,
            this.RemoveFromTrashBox,
            this.DeleteBox,
            this.IdBox,
            this.ID_Sender});
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateBox
            // 
            this.DateBox.HeaderText = "Date and time";
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.SubjectBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContinutBox
            // 
            this.ContinutBox.HeaderText = "Content";
            this.ContinutBox.Name = "ContinutBox";
            this.ContinutBox.ReadOnly = true;
            this.ContinutBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AttachamentBox
            // 
            this.AttachamentBox.HeaderText = "Attachament";
            this.AttachamentBox.Name = "AttachamentBox";
            this.AttachamentBox.ReadOnly = true;
            this.AttachamentBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RemoveFromTrashBox
            // 
            this.RemoveFromTrashBox.HeaderText = "Remove from Trash";
            this.RemoveFromTrashBox.Name = "RemoveFromTrashBox";
            this.RemoveFromTrashBox.ReadOnly = true;
            // 
            // DeleteBox
            // 
            this.DeleteBox.HeaderText = "Delete";
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.ReadOnly = true;
            this.DeleteBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdBox
            // 
            this.IdBox.HeaderText = "Id";
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdBox.Visible = false;
            // 
            // ID_Sender
            // 
            this.ID_Sender.HeaderText = "ID_Sender";
            this.ID_Sender.Name = "ID_Sender";
            this.ID_Sender.ReadOnly = true;
            this.ID_Sender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Sender.Visible = false;
            // 
            // TrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 367);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrashForm";
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.TrashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContinutBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachamentBox;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveFromTrashBox;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sender;
    }
}