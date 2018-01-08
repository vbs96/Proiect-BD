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
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Configuration;

namespace EmailClientATM
{
    public partial class FormAutentificare : Form
    {
        string Gender;

        



        
        public FormAutentificare()
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


        private void btnCreazaCont_Click(object sender, EventArgs e)
        {
            bool blocat = false;
            string email = txtEmail.Text.Trim() + "@atm" + comboBoxEmail.Text.Trim();

            if (txtNume.Text == "" || txtPrenume.Text == "" || txtEmail.Text == "" || (txtSexF.Checked == false && txtSexM.Checked == false) || txtTelefon.Text == "" || txtParola.Text == "" || txtConfirmaParola.Text == "" || string.IsNullOrEmpty(comboBoxEmail.Text) || string.IsNullOrEmpty(comboBoxDataAn.Text) || string.IsNullOrEmpty(comboBoxDataLuna.Text) || string.IsNullOrEmpty(comboBoxDataZi.Text) || txtInterogareResetPass.Text == "")
                MessageBox.Show("Vă rugăm completați toate câmpurile!");

            else if (txtConfirmaParola.Text != txtParola.Text)
            {
                MessageBox.Show("Parolele nu coincid!");
                txtParola.Text = txtConfirmaParola.Text = "";

            }

            else if (!checkPhone(txtTelefon.Text))
                MessageBox.Show("Telefon incorect!");

            else if (existEmail(email))
                MessageBox.Show("Email invalid! Reîncercați!");

            else
            {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {

                    string data = comboBoxDataAn.Text.Trim() + "-" + comboBoxDataLuna.Text.Trim() + "-" + comboBoxDataZi.Text.Trim();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddUtilizatori", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nume", txtNume.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenume", txtPrenume.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sex", Gender);
                    cmd.Parameters.AddWithValue("@DataNastere", data);
                    cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Parola", HashParola(txtParola.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Blocat", blocat);
                    cmd.Parameters.AddWithValue("@Interogare", txtInterogareResetPass.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contul a fost înregistrat cu succes!");
                Clear();
                this.Close();
            }
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
        

        public bool checkPhone(string telefon)
        {
            Regex expr = new Regex(@"^?([07]{2})?([07]2)?([0-9]{8})$");
            if (expr.IsMatch(telefon))
                return true;
            else return false;
        }


        private void txtSexM_CheckedChanged(object sender, EventArgs e)
        {
            Gender = txtSexM.Text.Trim();
        }

        private void txtSexF_CheckedChanged(object sender, EventArgs e)
        {
            Gender = txtSexF.Text.Trim();
        }


        void Clear()
        {
            txtNume.Text = txtPrenume.Text = txtEmail.Text = txtParola.Text = txtConfirmaParola.Text = txtTelefon.Text = comboBoxEmail.Text = comboBoxDataZi.Text = comboBoxDataLuna.Text = comboBoxDataAn.Text = "";
            if (txtSexM.Checked)
                txtSexM.Checked = false;

            if (txtSexF.Checked)
                txtSexF.Checked = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
