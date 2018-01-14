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
    public partial class TrashForm : Form
    {
        private string emailUser;
        public TrashForm(string email)
        {
            InitializeComponent();
            emailUser = email;
            PopulateTrashForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var senderGrid = (DataGridView)sender;
                if (e.RowIndex >= 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        var nw = ConfigurationManager.ConnectionStrings["nw"];
                        using (SqlConnection con = new SqlConnection(nw.ConnectionString))
                        {
                            if (senderGrid.Columns[e.ColumnIndex].Name == "DeleteBox")
                            {
                                con.Open();
                                var cmd = new SqlCommand("RemoveFromTrashById", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ID",
                                       senderGrid.Rows[e.RowIndex].Cells[7].Value);
                                var stuff = cmd.ExecuteNonQuery();

                                cmd = new SqlCommand("RemoveById", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ID",
                                       senderGrid.Rows[e.RowIndex].Cells[7].Value);
                                stuff = cmd.ExecuteNonQuery();

                                dataGridView1.Rows.Clear();
                                PopulateTrashForm();
                            }
                            else 
                            {
                                con.Open();

                            var cmd = new SqlCommand("RemoveFromTrashById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[7].Value);
                            var stuff = cmd.ExecuteNonQuery();



                            dataGridView1.Rows.Clear();
                                PopulateTrashForm();
                            }
                       
                     
                        }
                    }
                    else
                    {
                        var viewEmailForm = new ViewEmailForm(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),
                            senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                            senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                            senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString(),
                            senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
                        viewEmailForm.ShowDialog();
                    }
                }
         
        }

        private void TrashForm_Load(object sender, EventArgs e)
        {

        }
        private void PopulateTrashForm()
        {
            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetTrashByEmail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", emailUser);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    var cmd1 = new SqlCommand("GetEmailById", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@ID", reader["ID_Sender"]);
                    var numeSender = cmd1.ExecuteScalar();

                    row.Cells[0].Value = reader[5];
                    row.Cells[1].Value = numeSender.ToString();
                    row.Cells[2].Value = reader[1];
                    row.Cells[3].Value = reader[2];
                    row.Cells[4].Value = reader[3];
                    row.Cells[7].Value = reader[4];
                    row.Cells[8].Value = reader[0];

                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}
