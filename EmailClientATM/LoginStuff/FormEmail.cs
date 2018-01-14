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


    public partial class FormEmail : Form
    {


        public FormEmail()
        {
            InitializeComponent();
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


        private void checkAratăParola_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkAratăParola.Checked;

            switch (check)
            {
                case true:
                    txtParola.UseSystemPasswordChar = false; break;
                default:
                    txtParola.UseSystemPasswordChar = true; break;
            };
        }


        private bool existEmail(string email)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Email from Utilizatori where Email = @Email", con);
                  comand.Parameters.AddWithValue("@Email", email);
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


         bool verifParolaEmail(string email, string parola)         
        {           
                bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {
                    SqlCommand comand = new SqlCommand("Select Email,Parola from Utilizatori where Email= @Email and Parola=@Parola", con);
                     comand.Parameters.AddWithValue("@Email",email);
                     comand.Parameters.AddWithValue("@Parola", HashParola(parola));
                     con.Open();
                    SqlDataReader dr = comand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                         dr = null;
                         con.Close();
                         return true;
                        }
                    }
                }

                return ok;
            }
        
    
        private bool esteBlocat(string email)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select * from Utilizatori where Email = @Email", con);
                 comand.Parameters.AddWithValue("@Email", email);
                 con.Open();

                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        string blocat = dr[8].ToString();
                        if (blocat == "False")
                            return false;
                        else return true ;
                    }
                }
            }

            return ok;
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Completati toate campurile!");
            }
            else if (!txtEmail.Text.Contains("@atm"))
            {
                MessageBox.Show("Email invalid!");
                Clear();
            }
            else if (!existEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email invalid!");
                Clear();
            }
            else if (esteBlocat(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email blocat!");
                Clear();
            }
            else if (!verifParolaEmail(txtEmail.Text.Trim(), txtParola.Text.Trim()))
            {
                MessageBox.Show("Parola introdusă este incorecta!");
                txtParola.Text = "";
            }
            else
            {
                this.Hide();
                using (var mainForm = new MainForm(txtEmail.Text))
                {
                    mainForm.ShowDialog();
                    if(this.Visible)
                        this.ShowDialog();
                }
            }
        }

        private void Clear()
        {
            txtEmail.Text = "";
            txtParola.Text = "";
        }

        private void linkLabelCreareCont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAutentificare form = new FormAutentificare();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLoginAdmin f3 = new FormLoginAdmin();
            f3.Show();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new FormResetPass1();
            form.Show();
        }

        

        private void FormEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void FormEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

    }
}
