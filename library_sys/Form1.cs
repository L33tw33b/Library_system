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

//-------------------##READ THIS BEFORE CONTINUING##-------------------
//REPLACE LISTBOXS TO DATABASE IN NEXT COMMIT

namespace library_sys
{
    public partial class Form1 : Form
    {
        string connection = @"Server=localhost;Database=library;Uid=root;pwd=root;";
        Form2 fm2 = new Form2();       
        public Form1()
        { 
            InitializeComponent();

        }

        


        void GridFill(string pro, DataGridView control)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pro, mysqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                control.DataSource = dt;
                control.Columns[0].Visible = false;
                control.Columns[1].Visible = false;
                control.Columns[2].Visible = false;
                control.Columns[3].Visible = false;
                control.Columns[4].Visible = false;
                control.Columns[5].Visible = false;
                control.Columns[6].Visible = false;
                control.Columns[11].Visible = false;
                control.Columns[12].Visible = false;
                control.Columns[13].Visible = false;
            }
        }

        void Clear(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
            
        }

        void Fillinfo(DataGridView dgv) {
            
           if (dgv.CurrentRow.Index != -1)
           {
                txt_bookn.Text = dgv_books.CurrentRow.Cells[7].Value.ToString();
                txt_auth.Text = dgv_books.CurrentRow.Cells[8].Value.ToString();
                txt_pub.Text = dgv_books.CurrentRow.Cells[9].Value.ToString();
                txt_sub.Text = dgv_books.CurrentRow.Cells[2].Value.ToString();
                txt_pubyear.Text = dgv_books.CurrentRow.Cells[10].Value.ToString();


           }


                
        }
            
 

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_barcode.Focus();
            Clear(grp_booklist);
            GridFill("BookViewAllUPOV",dgv_books);
            dgv_borrow.ColumnCount = 1;
            dgv_return.ColumnCount = 1;
            dgv_borrow.Columns[0].Name = "Books";
            dgv_return.Columns[0].Name = "Books";

        }

        private void txt_barcode_Enter(object sender, EventArgs e)
        {
            if (txt_barcode.Text == "Click here when scanning books...")
            {
                txt_barcode.Text = "";

                txt_barcode.ForeColor = Color.Black;
            }
        }

        private void txt_barcode_Leave(object sender, EventArgs e)
        {
            if (txt_barcode.Text == "")
            {
                txt_barcode.Text = "Click here when scanning books...";

                txt_barcode.ForeColor = Color.Silver;
            }
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    mysqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM books WHERE b_Barcode = " + txt_barcode.Text, mysqlcon);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        if (dr["b_Borrowed_by"] == System.DBNull.Value){
                            dgv_borrow.Rows.Add(dr["b_Title"]);
                        } else
                        {
                            dgv_return.Rows.Add(dr["b_Title"]);
                        }
                            
                    }

                    mysqlcon.Close();

                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (txt_search.Text != null)
                {
                    mysqlcon.Open();
                    GridFill("SearchByValue", dgv_search);
                }
                else
                {
                    mysqlcon.Open();
                    GridFill("BookViewAll", dgv_books);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int bor, ret;
            bor = dgv_borrow.Rows.Count - 1;
            ret = dgv_return.Rows.Count - 1;
            DateTime due_date = DateTime.Today.AddDays(14);

            if (MessageBox.Show($"You are about to borrow {bor} books and return {ret} books. Confirm?", "Books processing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    foreach (DataGridViewRow item in dgv_borrow.Rows)
                    {                        
                        MySqlDataAdapter da = new MySqlDataAdapter("BorrowBook",mysqlcon);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("_Title", item.Cells["Books"].Value);
                        da.SelectCommand.Parameters.AddWithValue("_Borrowed_by", Global.GlobalVar);
                        da.SelectCommand.Parameters.AddWithValue("_Due_Date", due_date.ToString("yyyy-MM-dd H:mm:ss"));
                        da.SelectCommand.ExecuteNonQuery();
                    }

                    foreach (DataGridViewRow item in dgv_return.Rows)
                    {                       
                        MySqlDataAdapter da = new MySqlDataAdapter("ReturnBook",mysqlcon);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("_Title", item.Cells["Books"].ToString());                       
                        da.SelectCommand.ExecuteNonQuery();
                    }
                    mysqlcon.Close();
                    MessageBox.Show("Process complete.");
                    Clear(grp_booklist);
                    GridFill("BookViewAllUPOV", dgv_books);

                }

            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to clear all items in the scanned book lists. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Clear(grp_booksscan);
            }
        }

        private void btn_erase_bor_Click(object sender, EventArgs e)
        {
            int i = dgv_borrow.SelectedRows.Count - 1;
            if (MessageBox.Show($"You are about to erase {i} books from the Borrow list. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult) 
            {
                dgv_borrow.SelectedRows.Clear();
            }
        }

        private void btn_erase_ret_Click(object sender, EventArgs e)
        {
            int i = dgv_return.SelectedRows.Count - 1;
            if (MessageBox.Show($"You are about to erase {i} books from the Return list. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                dgv_return.SelectedRows.Clear();
            }
        }

        private void btn_renew_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                int i = dgv_return.SelectedRows.Count-1;
                if (MessageBox.Show($"You are about to renew {i} books from the Return list. Confirm?", "Renew items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                {
                    mysqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM books");
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        foreach (var listboxitems in dgv_return.SelectedRows)
                        {
                            DateTime new_due_date = DateTime.ParseExact(dr["b_Due_Date"].ToString(), "YYYY-mm-dd H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            new_due_date.AddDays(14);
                            cmd = new MySqlCommand("UPDATE books SET b_Due_Date = " + new_due_date.ToString() + "WHERE b_Title =" + listboxitems + ";", mysqlcon);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    dr.Close();
                    GridFill("BookViewAll", dgv_books);
                    dgv_return.SelectedRows.Clear();
                }
            }
        }

        private void dgv_books_Click(object sender, EventArgs e)
        {
            Fillinfo(dgv_books);
        }

        private void dgv_search_Click(object sender, EventArgs e)
        {
            Fillinfo(dgv_search);
        }
    }
}
