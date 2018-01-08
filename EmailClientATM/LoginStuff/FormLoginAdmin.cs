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
    public partial class FormLoginAdmin : Form
    {

        public FormLoginAdmin()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (existEmptySpace())
                MessageBox.Show("Completați toate câmpurile!");
            else
            if (!existAdmin(txtUserLogAdmin.Text.Trim()))
                MessageBox.Show("Adminul nu există în sistem");
            else
                if (!corectPassword(txtUserLogAdmin.Text.Trim(), txtPassLogAdmin.Text.Trim()))
            {
                txtPassLogAdmin.Text = "";
                MessageBox.Show("Parola introdusă este Incorectă");
            }
            else
            {
                clear();
                this.Close();
                FormAdmin frm = new FormAdmin();
                frm.Show();

            }
        }


        bool existAdmin(string username)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Username from Administratori where Username = @Username", con);
                comand.Parameters.AddWithValue("@Username", username);
                con.Open();
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {                      
                        return true;
                        
                    }
                }
            }

            return ok;
        }
        

        bool corectPassword(string username,string password)
        {
            bool ok = false;

            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                SqlCommand comand = new SqlCommand("Select Username,Parola from Administratori where Username = @Username and Parola=@Parola", con);
                comand.Parameters.AddWithValue("@Username", username);
                comand.Parameters.AddWithValue("@Parola", password);
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


        bool existEmptySpace()
        {
            if (txtPassLogAdmin.Text.Trim() == "" || txtUserLogAdmin.Text.Trim() == "")
                return true;
            return false;
        }


        void clear()
        {
            txtPassLogAdmin.Text = txtUserLogAdmin.Text = "";
        }

       
    }
}
