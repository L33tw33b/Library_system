using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_sys
{
    public partial class Form3 : Form
    {
        string connection = @"Server=localhost;Database=library;Uid=root;pwd=root;";
        int bid = 0;
        int uid = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Clear(grp_booksop);
            Clear(grp_userop);
            GridFill("BookViewAll",dgvbook);
            GridFill("UserViewAll",dgvuser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                try {
                    mysqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand("AddOrEdit", mysqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_BID", bid);
                    cmd.Parameters.AddWithValue("_Seq", txt_seq.Text.Trim());
                    cmd.Parameters.AddWithValue("_Subject", txt_sub.Text.Trim());
                    cmd.Parameters.AddWithValue("_ISBN", txt_isbn.Text.Trim());
                    cmd.Parameters.AddWithValue("_Call_number", txt_call.Text.Trim());
                    cmd.Parameters.AddWithValue("_Barcode", txt_barcode.Text.Trim());
                    cmd.Parameters.AddWithValue("_Format", txt_format.Text.Trim());
                    cmd.Parameters.AddWithValue("_Title", txt_title.Text.Trim());
                    cmd.Parameters.AddWithValue("_Author", txt_auth.Text.Trim());
                    cmd.Parameters.AddWithValue("_Publisher", txt_pub.Text.Trim());
                    cmd.Parameters.AddWithValue("_Publication_year", txt_pubyear.Text.Trim());
                    cmd.Parameters.AddWithValue("_Borrowed_by", null);
                    cmd.Parameters.AddWithValue("_Due_Date", null);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted.");
                    Clear(grp_booksop);
                    GridFill("BookViewAll",dgvbook);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error Occurred!" + ex.Message);
                }



            }
        }

        void FillTextBox(string dgv) {
            if (dgv == "book")
            {

            }
            else if (dgv == "user") { 
            
            }
        }

        void GridFill(string pro,DataGridView control) {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                mysqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pro, mysqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                control.DataSource = dt;
                control.Columns[0].Visible = false;
            }
        }

        void Clear(GroupBox grp) { 
             foreach(Control c in grp.Controls)
            {
                if (c is TextBox) {
                    c.Text = String.Empty;
                }
            }
            btn_add.Text = "Save";
        }

        private void dgvbook_DoubleClick(object sender, EventArgs e)
        {
            int i = 1;
            if (dgvbook.CurrentRow.Index != -1) {
                
                foreach (Control c in grp_booksop.Controls) {
                    if (c is TextBox) {               
                        c.Text = dgvbook.CurrentRow.Cells[i].Value.ToString();
                        i++;
                    }
                }
            }
            bid = Convert.ToInt32(dgvbook.CurrentRow.Cells[0].Value.ToString());
            btn_add.Text = "Edit";
            
        }

        private void cbox_overdue_CheckedChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                if (cbox_overdue.CheckState == CheckState.Checked)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("ViewByOverdue", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbook.DataSource = dt;
                    dgvbook.Columns[0].Visible = false;
                } else {
                    GridFill("BookViewAll",dgvbook);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear(grp_booksop);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                try {
                    mysqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand("DeleteByID", mysqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_BID", bid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted.");
                    Clear(grp_booksop);
                    GridFill("BookViewAll",dgvbook);
                } catch(Exception ex)
                {
                    MessageBox.Show("Error Occured!" + ex);
                }

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                if (txt_search.Text != null)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SearchByValue", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_search.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbook.DataSource = dt;
                    dgvbook.Columns[0].Visible = false;
                } else
                {
                    mysqlcon.Open();
                    GridFill("BookViewAll",dgvbook);
                }


            }
        }

        private void dgvuser_DoubleClick(object sender, EventArgs e)
        {
            int i = 1;
            if (dgvbook.CurrentRow.Index != -1)
            {

                foreach (Control c in grp_booksop.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = dgvbook.CurrentRow.Cells[i].Value.ToString();
                        i++;
                    }
                }
            }
        }

        private void btn_uadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                try
                {
                    mysqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand("AddOrEditUser", mysqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ID", uid);
                    cmd.Parameters.AddWithValue("_Name", txt_seq.Text.Trim());
                    cmd.Parameters.AddWithValue("_Email", txt_sub.Text.Trim());
                    cmd.Parameters.AddWithValue("_Contact_no", txt_pub.Text.Trim());
                    cmd.Parameters.AddWithValue("_Password", txt_auth.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted.");
                    Clear(grp_userop);
                    GridFill("BookViewAll", dgvuser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred!" + ex.Message);
                }



            }
        }

        private void btn_usearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (txt_search.Text != null)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SearchByValueUser", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_usearch.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvuser.DataSource = dt;
                    dgvuser.Columns[0].Visible = false;
                }
                else
                {
                    GridFill("UserViewAll", dgvbook);
                }


            }
        }
    }
}
