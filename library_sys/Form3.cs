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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
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
                    cmd.Parameters.AddWithValue("_ISBN", txt_pub.Text.Trim());
                    cmd.Parameters.AddWithValue("_Call_number", txt_auth.Text.Trim());
                    cmd.Parameters.AddWithValue("_Barcode", txt_title.Text.Trim());
                    cmd.Parameters.AddWithValue("_Format", txt_format.Text.Trim());
                    cmd.Parameters.AddWithValue("_Title", txt_barcode.Text.Trim());
                    cmd.Parameters.AddWithValue("_Author", txt_call.Text.Trim());
                    cmd.Parameters.AddWithValue("_Publisher", txt_isbn.Text.Trim());
                    cmd.Parameters.AddWithValue("_Publication_year", txt_pubyear.Text.Trim());
                    cmd.Parameters.AddWithValue("_Borrowed_by", null);
                    cmd.Parameters.AddWithValue("_Due_Date", null);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted.");
                    Clear();
                    GridFill();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error Occurred!" + ex.Message);
                }



            }
        }

        void GridFill() {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                mysqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("BookViewAll", mysqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvbook.DataSource = dt;
                dgvbook.Columns[0].Visible = false;
            }
        }

        void Clear() { 
             foreach(Control c in grp_booksop.Controls)
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
                    GridFill();
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }
    }
}
