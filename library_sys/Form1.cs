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
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
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

        void Fillinfo(ListBox lst) {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                if (lst.SelectedIndex != -1)
                {
                    cmd = new MySqlCommand("BookInfo", mysqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_Title", lst.SelectedItem.ToString());
                    mysqlcon.Open();
                    cmd.ExecuteNonQuery();

                    mysqlcon.Close();
                }
            }


        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear(grp_booklist);
            GridFill("BookViewAll",dgv_books);

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
                    cmd = new MySqlCommand("SELECT * FROM books WHERE b_Barcode = " + txt_barcode.Text, mysqlcon);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader dr = cmd.ExecuteReader();


                    mysqlcon.Close();

                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                lst_search.Items.Clear();
                mysqlcon.Open();
                fill_data("SELECT b_Title FROM books WHERE b_Title ='" + txt_search.Text + "' AND b_Borrowed_by IS NULL", lst_borrow);
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
            bor = lst_borrow.Items.Count;
            ret = lst_return.Items.Count;
            DateTime due_date = DateTime.Today.AddDays(14);

            if (MessageBox.Show($"You are about to borrow {bor} books and return {ret} books. Confirm?", "Books processing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    foreach (var listboxitem in lst_borrow.Items)
                    {
                        da = new MySqlDataAdapter("BorrowBook", connection);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("_Title", listboxitem.ToString());
                        da.SelectCommand.Parameters.AddWithValue("_Borrowed_by", Global.GlobalVar);
                        da.SelectCommand.Parameters.AddWithValue("_Due_Date", due_date.ToString("yyyy-MM-dd H:mm:ss"));
                        da.SelectCommand.ExecuteNonQuery();

                    }

                    foreach (var listboxitem in lst_return.Items)
                    {
                        cmd = new MySqlCommand("UPDATE books SET b_Borrowed_by =" + null + "b_Due_Date = " + null + "WHERE b_Title =" + listboxitem + ";", mysqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    mysqlcon.Close();
                    MessageBox.Show("Process complete.");
                    lst_borrow.DataSource = null;
                    lst_return.DataSource = null;
                    lst_borrow.Items.Clear();
                    lst_return.Items.Clear();

                }

            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to clear all items in the scanned book lists. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult) 
            {
                Clear(grp_booksscan);
            }
        }

        private void btn_erase_bor_Click(object sender, EventArgs e)
        {
            int i = lst_borrow.SelectedItems.Count;
            if (MessageBox.Show($"You are about to erase {i} books from the Borrow list. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult) 
            {
                lst_borrow.SelectedItems.Clear();
            }
        }

        private void btn_erase_ret_Click(object sender, EventArgs e)
        {
            int i = lst_return.SelectedItems.Count;
            if (MessageBox.Show($"You are about to erase {i} books from the Return list. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                lst_return.SelectedItems.Clear();
            }
        }

        private void btn_renew_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                int i = lst_return.SelectedItems.Count;
                if (MessageBox.Show($"You are about to renew {i} books from the Return list. Confirm?", "Renew items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                {
                    mysqlcon.Open();
                    cmd = new MySqlCommand("SELECT * FROM books");
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        foreach (var listboxitems in lst_return.SelectedItems)
                        {
                            DateTime new_due_date = DateTime.ParseExact(dr["b_Due_Date"].ToString(), "YYYY-mm-dd H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            new_due_date.AddDays(14);
                            cmd = new MySqlCommand("UPDATE books SET b_Due_Date = " + new_due_date.ToString() + "WHERE b_Title =" + listboxitems + ";", mysqlcon);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    dr.Close();
                    mysqlcon.Close();
                    lst_return.SelectedItems.Clear();
                }
            }
        }


    }
}
