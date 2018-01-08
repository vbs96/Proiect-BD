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
    public partial class FormResetPass1 : Form
    {
       // string connectionString = @"Data Source= DESKTOP-UG714NR ; Initial Catalog = EmailClient ; Integrated Security=true;";


        public FormResetPass1()
        {
            InitializeComponent();
        }

        public bool existEmail(string Email)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Email from Utilizatori where Email= @Email", con);
                comand.Parameters.AddWithValue("@Email", Email);
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

       

        private bool VerifInterogare(string email, string interogare)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Email,Interogare from Utilizatori where Email = @Email and Interogare=@Interogare", con);
                comand.Parameters.AddWithValue("@Email", email);
                comand.Parameters.AddWithValue("@Interogare", interogare);
                con.Open();
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                        return true;
                }
            }

            return ok;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtInterogare.Text == "")
                MessageBox.Show("Completați toate câmpurile!");

            else if (!existEmail(txtEmail.Text))
            {
                MessageBox.Show("Email invalid! Reîncercați!");
                txtEmail.Text = "";
            }

            else if (!VerifInterogare(txtEmail.Text, txtInterogare.Text))
            {
                MessageBox.Show("Text Interogare incorect!");
                txtInterogare.Text = "";
            }

            else
            {
                
                Form f = new FormResetPass2(txtEmail.Text);
                f.Show();
                txtEmail.Text = txtInterogare.Text = "";
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = txtInterogare.Text = "";
            this.Close();
        }
    }
}
