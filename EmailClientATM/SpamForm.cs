﻿using System;
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
    public partial class SpamForm : Form
    {
        private string emailUser;
        public SpamForm(string email)
        {
            InitializeComponent();
            emailUser = email;
            PopulateSpamForm();
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
                            var cmd = new SqlCommand("RemoveFromSpamById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[8].Value);
                            var stuff = cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("MoveToTrashById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[8].Value);
                            stuff = cmd.ExecuteNonQuery();

                            dataGridView1.Rows.Clear();
                            PopulateSpamForm();
                        }
                        else if (senderGrid.Columns[e.ColumnIndex].Name == "SpamBox")
                        {
                            con.Open();

                            var cmd = new SqlCommand("GetIdByEmail", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Email", emailUser);
                            var idUser = cmd.ExecuteScalar();

                            cmd = new SqlCommand("RemoveSpammerById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID_User", idUser);
                            cmd.Parameters.AddWithValue("@ID_Spammer",
                                senderGrid.Rows[e.RowIndex].Cells[10].Value);
                            var stuff = cmd.ExecuteNonQuery();


                            cmd = new SqlCommand("RemoveFromSpamById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[8].Value);
                            stuff = cmd.ExecuteNonQuery();

                            dataGridView1.Rows.Clear();
                            PopulateSpamForm();
                        }
                        else if (senderGrid.Columns[e.ColumnIndex].Name == "ImportantBox")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("RemoveFromSpamById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[8].Value);
                            var stuff = cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("MoveToImportantById", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID",
                                   senderGrid.Rows[e.RowIndex].Cells[8].Value);
                            stuff = cmd.ExecuteNonQuery();

                            dataGridView1.Rows.Clear();
                            PopulateSpamForm();
                        }
                        else
                        {
                            //CreateMessage form-ul
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

        private void PopulateSpamForm()
        {
            var nw = ConfigurationManager.ConnectionStrings["nw"];
            using (SqlConnection con = new SqlConnection(nw.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetSpamByEmail", con);
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
                    row.Cells[8].Value = reader[4];
                    row.Cells[10].Value = reader[0];

                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}
