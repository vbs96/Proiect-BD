using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;




namespace EmailClientATM
{
    public partial class FormUpdateUtilizator : Form
    {
        //string connectionString = @"Data Source= DESKTOP-UG714NR ; Initial Catalog = EmailClient ; Integrated Security=true;";
        string Gender;
        string initialEmail;


        public FormUpdateUtilizator()
        {
            InitializeComponent();
        }

        public FormUpdateUtilizator(string email, string Nume, string Prenume, string Sex, string DataNastere, string Telefon, string Email, string Parola, string Blocat)
        {
            InitializeComponent();


            initialEmail = email;
            txtNume.Text = Nume;
            txtPrenume.Text = Prenume;
            txtTelefon.Text = Telefon;
            txtParola.Text = Parola;
            txtConfirmaParola.Text = Parola;

            String[] data = DataNastere.Split('/', ' ');
                comboBoxDataZi.Text = data[1];
                comboBoxDataLuna.Text = data[0];
                comboBoxDataAn.Text = data[2];

            string[] separator = new string[] { "@atm" };
            string[] vecEmail = Email.Split(separator, StringSplitOptions.None);
                txtEmail.Text = vecEmail[0];
                comboBoxEmail.Text = vecEmail[1];

            if (Sex == "M")
            {  if (!txtSexM.Checked)
                    txtSexM.Checked = true;
            }
            else
                if (!txtSexF.Checked)
                txtSexF.Checked = true;

            if (Blocat == "True")
                chkBlocat.Checked = true;
            else
                chkBlocat.Checked = false;
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


        private void txtSexF_CheckedChanged(object sender, EventArgs e)
        {
            Gender = txtSexF.Text.Trim();
        }


        private void txtSexM_CheckedChanged(object sender, EventArgs e)
        {
            Gender = txtSexM.Text.Trim();
        }


        private bool existEmail(string email)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Email from Utilizatori where Email= @Email", con);
                comand.Parameters.AddWithValue("@Email", email);
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
            {
                return true;
            }
            else return false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim() + "@atm"+comboBoxEmail.Text.Trim();

            if (txtNume.Text == "" || txtPrenume.Text == "" || txtEmail.Text == "" || (txtSexF.Checked == false && txtSexM.Checked == false) || txtTelefon.Text == "" || txtParola.Text == "" || txtConfirmaParola.Text == "" || string.IsNullOrEmpty(comboBoxEmail.Text) || string.IsNullOrEmpty(comboBoxDataAn.Text) || string.IsNullOrEmpty(comboBoxDataLuna.Text) || string.IsNullOrEmpty(comboBoxDataZi.Text))
                MessageBox.Show("Vă rugăm completați toate câmpurile!");
            else if (txtConfirmaParola.Text != txtParola.Text)
            {
                MessageBox.Show("Parolele nu coincid!");
                txtParola.Text = txtConfirmaParola.Text = "";
            }

            else if (!checkPhone(txtTelefon.Text))
            {
                MessageBox.Show("Telefon incorect!");
                txtTelefon.Text = "";
            }

            else
            {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {
                    bool blocat = chkBlocat.Checked;

                    string data = comboBoxDataAn.Text.Trim() + "-" + comboBoxDataLuna.Text.Trim() + "-" + comboBoxDataZi.Text.Trim();
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UpdateUtilizatori", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InitialEmail", email);
                    cmd.Parameters.AddWithValue("@Nume", txtNume.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenume", txtPrenume.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sex", Gender);
                    cmd.Parameters.AddWithValue("@DataNastere", data);
                    cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@Parola", HashParola(txtParola.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Blocat", blocat);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Update realizat cu succes!");
                Clear();
                this.Close();

                FormAdmin form = new FormAdmin();
                form.Show();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();
            this.Close();

            FormAdmin form = new FormAdmin();
            form.Show();
        }

        private void FormUpdateUtilizator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clear();
            FormAdmin form = new FormAdmin();
            form.Show();
        }


        public void Clear()
        {
            txtNume.Text = txtPrenume.Text = txtEmail.Text = txtParola.Text = txtConfirmaParola.Text = txtTelefon.Text = comboBoxEmail.Text = comboBoxDataZi.Text = comboBoxDataLuna.Text = comboBoxDataAn.Text = "";
            if (txtSexM.Checked)
                txtSexM.Checked = false;

            if (txtSexF.Checked)
                txtSexF.Checked = false;

            if (chkBlocat.Checked)
                chkBlocat.Checked = false;
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormUpdateUtilizator_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)

        {

        }
    }
}
