using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Globalization;

namespace EmailClientATM
{
    public partial class CreateMessageForm : Form
    {
        private string emailUser;
        private string atasament;
        public CreateMessageForm(string email)
        {
            InitializeComponent();
            emailUser = email;
        }
        public CreateMessageForm(string email, string to)
        {
            InitializeComponent();
            emailUser = email;
            toTextBox.Text = to;
        }
        private void CreateMessageForm_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (this.toTextBox == null)
            {
                MessageBox.Show("Completati campul Destinatar!");
            }
            else
            {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand("GetIdByEmail", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", emailUser);
                    var id_sender = cmd.ExecuteScalar();

                    cmd = new SqlCommand("GetIdByEmail", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", toTextBox.Text);
                    var id_receiver = cmd.ExecuteScalar();
                    var dataTimp = DateTime.Now;

                    cmd = new SqlCommand("CheckIfExistsUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", toTextBox.Text);
                    var checker = cmd.ExecuteScalar();
                    if (int.Parse(checker.ToString()) == 0)
                    {
                        MessageBox.Show("Introduceti un email valid!");
                    }
                    else
                    {

                        cmd = new SqlCommand("AddMesaj", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_SENDER", id_sender);
                        cmd.Parameters.AddWithValue("@ID_RECEIVER", id_receiver);
                        cmd.Parameters.AddWithValue("@CONTINUT", contentTextBox.Text);
                        cmd.Parameters.AddWithValue("@SUBIECT", subjTextBox.Text);
                        cmd.Parameters.AddWithValue("@ATASAMENT", atasament);
                        cmd.Parameters.AddWithValue("@DATEANDTIME", dataTimp);

                        var stuff = cmd.ExecuteNonQuery();
                        this.Close();
                    }
                   
                }
            }
        }

        private void AttachmentButton_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                atasament = FD.FileName;
            }

        }
    }
}
