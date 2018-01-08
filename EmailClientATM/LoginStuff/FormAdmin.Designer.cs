namespace EmailClientATM
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnUpdateUtilizator = new System.Windows.Forms.Button();
            this.btnBlockUtilizator = new System.Windows.Forms.Button();
            this.txtUpdateUtilizator = new System.Windows.Forms.TextBox();
            this.btnUnblockUtilizator = new System.Windows.Forms.Button();
            this.txtBlockUtilizator = new System.Windows.Forms.TextBox();
            this.txtUnblockUtilizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnAddAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.Location = new System.Drawing.Point(118, 367);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(215, 54);
            this.btnAddAdmin.TabIndex = 7;
            this.btnAddAdmin.Text = "Adăugare Administrator";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnUpdateUtilizator
            // 
            this.btnUpdateUtilizator.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateUtilizator.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUtilizator.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUtilizator.Location = new System.Drawing.Point(96, 110);
            this.btnUpdateUtilizator.Name = "btnUpdateUtilizator";
            this.btnUpdateUtilizator.Size = new System.Drawing.Size(215, 44);
            this.btnUpdateUtilizator.TabIndex = 0;
            this.btnUpdateUtilizator.Text = "Editare Utilizator";
            this.btnUpdateUtilizator.UseVisualStyleBackColor = false;
            this.btnUpdateUtilizator.Click += new System.EventHandler(this.btnUpdateUtilizator_Click);
            // 
            // btnBlockUtilizator
            // 
            this.btnBlockUtilizator.BackColor = System.Drawing.Color.Silver;
            this.btnBlockUtilizator.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockUtilizator.Location = new System.Drawing.Point(96, 296);
            this.btnBlockUtilizator.Name = "btnBlockUtilizator";
            this.btnBlockUtilizator.Size = new System.Drawing.Size(215, 44);
            this.btnBlockUtilizator.TabIndex = 4;
            this.btnBlockUtilizator.Text = "Blocheaza Utilizator";
            this.btnBlockUtilizator.UseVisualStyleBackColor = false;
            this.btnBlockUtilizator.Click += new System.EventHandler(this.btnBlockUtilizator_Click);
            // 
            // txtUpdateUtilizator
            // 
            this.txtUpdateUtilizator.AccessibleDescription = "";
            this.txtUpdateUtilizator.AccessibleName = "";
            this.txtUpdateUtilizator.BackColor = System.Drawing.Color.White;
            this.txtUpdateUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUtilizator.Location = new System.Drawing.Point(359, 115);
            this.txtUpdateUtilizator.Name = "txtUpdateUtilizator";
            this.txtUpdateUtilizator.Size = new System.Drawing.Size(265, 30);
            this.txtUpdateUtilizator.TabIndex = 1;
            this.txtUpdateUtilizator.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUnblockUtilizator
            // 
            this.btnUnblockUtilizator.BackColor = System.Drawing.Color.Silver;
            this.btnUnblockUtilizator.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblockUtilizator.Location = new System.Drawing.Point(96, 198);
            this.btnUnblockUtilizator.Name = "btnUnblockUtilizator";
            this.btnUnblockUtilizator.Size = new System.Drawing.Size(215, 43);
            this.btnUnblockUtilizator.TabIndex = 2;
            this.btnUnblockUtilizator.Text = "Deblocheaza Utilizator";
            this.btnUnblockUtilizator.UseVisualStyleBackColor = false;
            this.btnUnblockUtilizator.Click += new System.EventHandler(this.btnUnblockUtilizator_Click);
            // 
            // txtBlockUtilizator
            // 
            this.txtBlockUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockUtilizator.Location = new System.Drawing.Point(359, 301);
            this.txtBlockUtilizator.Name = "txtBlockUtilizator";
            this.txtBlockUtilizator.Size = new System.Drawing.Size(265, 30);
            this.txtBlockUtilizator.TabIndex = 5;
            this.txtBlockUtilizator.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUnblockUtilizator
            // 
            this.txtUnblockUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnblockUtilizator.Location = new System.Drawing.Point(359, 211);
            this.txtUnblockUtilizator.Name = "txtUnblockUtilizator";
            this.txtUnblockUtilizator.Size = new System.Drawing.Size(265, 30);
            this.txtUnblockUtilizator.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Meniu Administrator";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 171);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::EmailClientATM.Properties.Resources.images4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnblockUtilizator);
            this.Controls.Add(this.txtBlockUtilizator);
            this.Controls.Add(this.btnUnblockUtilizator);
            this.Controls.Add(this.txtUpdateUtilizator);
            this.Controls.Add(this.btnBlockUtilizator);
            this.Controls.Add(this.btnUpdateUtilizator);
            this.Controls.Add(this.btnAddAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailClientATM";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnUpdateUtilizator;
        private System.Windows.Forms.Button btnBlockUtilizator;
        private System.Windows.Forms.TextBox txtUpdateUtilizator;
        private System.Windows.Forms.Button btnUnblockUtilizator;
        private System.Windows.Forms.TextBox txtBlockUtilizator;
        private System.Windows.Forms.TextBox txtUnblockUtilizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}