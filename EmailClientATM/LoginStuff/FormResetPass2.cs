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
using System.Security.Cryptography;
using System.Configuration;



namespace EmailClientATM
{
    public partial class FormResetPass2 : Form
    {
        static string Email;
        //static string connectionString = @"Data Source= DESKTOP-UG714NR ; Initial Catalog = EmailClient ; Integrated Security=true;";
               

        public FormResetPass2(string email)
        {
            InitializeComponent();
            Email = email;
           
        }


        public string HashParola(string parola)
        {
            byte[] data = Encoding.ASCII.GetBytes(parola);
            byte[] result;
            string rezultat;

            SHA1 sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);
            rezultat = Encoding.ASCII.GetString(result);

            return rezultat;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Email);
            if (txtPassword.Text == "" || txtConfirmPassword.Text == "")
                MessageBox.Show("Completați toate câmpurile!");
            else
                if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Parolele nu coincid!");
                txtConfirmPassword.Text = txtPassword.Text = "";
            }


            else
            {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ResetParola", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Parola",HashParola(txtPassword.Text));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Parola a fost resetata");
                txtPassword.Text = txtConfirmPassword.Text = "";
                this.Close();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtConfirmPassword.Text = "";
            this.Close();
        }
    }
}
