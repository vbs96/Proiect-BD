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
    public partial class FormAdmin : Form
    {
       // static string connectionString = @"Data Source= DESKTOP-UG714NR ; Initial Catalog = EmailClient ; Integrated Security=true;";
        string Nume, Prenume, Sex, DataNastere, Telefon, Email, Parola, Blocat;


        public FormAdmin()
        {
            InitializeComponent();
            dataGridView1.DataSource = Get_Utilizatori();
        }


        


        private static DataTable Get_Utilizatori()
        {
            DataTable utilizatori = new DataTable();
            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select Id,Nume,Prenume,Email,Sex,DataNastere,Telefon,Blocat from Utilizatori", con);
                
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    utilizatori.Load(reader);
            }

            return utilizatori;
        }


        private bool existUpdateEmail(string email)
        {
            bool ok = false;
            var nw = ConfigurationManager.ConnectionStrings["nw"];

            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select * from Utilizatori where Email= @Email", con);
                    comand.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    SqlDataReader dr = comand.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr.HasRows == true)
                            {
                                Nume = dr[1].ToString();
                                Prenume = dr[2].ToString();
                                Sex = dr[3].ToString();
                                DataNastere = dr[4].ToString();
                                Telefon = dr[5].ToString();
                                Email = dr[6].ToString();
                                Parola = dr[7].ToString();
                                Blocat = dr[8].ToString();

                                ok = true;
                                break;
                            }
                        }
            }

            return ok;
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


        private void btnBlockUtilizator_Click(object sender, EventArgs e)
        {
            if (txtBlockUtilizator.Text == "")
                MessageBox.Show("Va rugăm completați câmpul Blocare Utilizator!");
            else if (!existEmail(txtBlockUtilizator.Text.Trim()))
                 MessageBox.Show("Email Invalid");
               else
               {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                    {
                     con.Open();

                     SqlCommand cmd = new SqlCommand("UpdateBlocat", con);
                         cmd.CommandType = CommandType.StoredProcedure;
                         cmd.Parameters.AddWithValue("@Email", txtBlockUtilizator.Text);
                         cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Contul a fost blocat!");
                    Clear();
               }
        }

        private void btnUnblockUtilizator_Click(object sender, EventArgs e)
        {
            if (txtUnblockUtilizator.Text == "")
                MessageBox.Show("Va rugăm completati câmpul Deblocare Utilizator!");
            else if (!existEmail(txtUnblockUtilizator.Text.Trim()))
                MessageBox.Show("Email Invalid");
             else

             {
                var nw = ConfigurationManager.ConnectionStrings["nw"];
                using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UpdateDeblocat", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", txtUnblockUtilizator.Text);
                        cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contul a fost deblocat!");
                Clear();

             }
        }


        private void btnUpdateUtilizator_Click(object sender, EventArgs e)
        {
            if (txtUpdateUtilizator.Text == "")
                MessageBox.Show("Va rugăm completati câmpul Editare Utilizator!");
            else if (!existUpdateEmail(txtUpdateUtilizator.Text.Trim()))
                MessageBox.Show("Email Invalid");

            else
            {
                Clear();
                FormUpdateUtilizator form = new FormUpdateUtilizator(txtUpdateUtilizator.Text, Nume, Prenume, Sex, DataNastere, Telefon, Email, Parola, Blocat);
                form.Show();
                this.Close();
            }
        }


        private void Clear()
        {
            txtBlockUtilizator.Text = "";
            txtUnblockUtilizator.Text = "";
            txtUpdateUtilizator.Text = "";
        }


        private void Add_Click(object sender, EventArgs e)
        {
            FormAddAdmin form = new FormAddAdmin();
            form.Show();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

