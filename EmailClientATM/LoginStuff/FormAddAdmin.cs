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

namespace EmailClientATM
{
    public partial class FormAddAdmin : Form
    {
       
       
        public FormAddAdmin()
        {
            InitializeComponent();
        }


        private bool existAdmin(string username)
        {
            bool ok = false;
            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Username from Administratori where Username= @Username", con);
                 comand.Parameters.AddWithValue("@Username", username);
                 con.Open();
                SqlDataReader dr = comand.ExecuteReader();
                  while (dr.Read())
                  {
                      if (dr.HasRows == true)
                      { 
                          ok = true;
                          break;
                      }
                  }
            }

            return ok;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (txtAddPasswordAdmin.Text == "" || txtAddUsernameAdmin.Text == "")
                MessageBox.Show("Vă rugăm completați toate câmpurile!");

            else if (existAdmin(txtAddUsernameAdmin.Text))
                MessageBox.Show("Username Admin Exista! Reîncercați!");

             else
                {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("AddAdmini", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", txtAddUsernameAdmin.Text.Trim());
                        cmd.Parameters.AddWithValue("@Parola", txtAddPasswordAdmin.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Contul a fost înregistrat cu succes!");
                    Clear();
                    this.Close();
                }
        }
        

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkShowPass.Checked;

            switch (check)
            {
                case true:
                    txtAddPasswordAdmin.UseSystemPasswordChar = false; break;
                default:
                    txtAddPasswordAdmin.UseSystemPasswordChar = true; break;
            };
        }


        private void Clear()
        {
            txtAddUsernameAdmin.Text = "";
            txtAddPasswordAdmin.Text = "";
        }

    }
}
