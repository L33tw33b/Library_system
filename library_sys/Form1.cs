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
    public partial class Form1 : Form
    {   
        Form2 fm2 = new Form2();       
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;
        MySqlConnection connection = new MySqlConnection(@"Server=localhost;Database=library;Uid=root;pwd=root;");
        public Form1()
        { 
            InitializeComponent();

        }

        private void fill_data(string sql, ListBox lst)
        {
            try
            {
                connection.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();
                

                cmd.Connection = connection;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                lst.DataSource = dt;
                lst.DisplayMember = "b_Title";

            }
            catch (Exception ex)
            {
                MessageBox.Show("The book scanned does not exist in the Database, Please contact admin.\n"+ex.Message);

            }
            finally
            {
                connection.Close();
                da.Dispose();
            }

        }


        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_barcode;
            txt_barcode.Focus();
            fill_data("SELECT b_Title FROM books WHERE b_Borrowed_by IS NULL", lst_avabooks);
            lbl_result.Text = lst_avabooks.Items.Count.ToString() + " results";

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
            if (e.KeyCode == Keys.Enter)
            {
                connection.Open();
                cmd = new MySqlCommand("SELECT * FROM books WHERE b_Barcode = "+txt_barcode,connection);
                dr = cmd.ExecuteReader();
                dr.Read();

                if ((dr["b_Borrowed_by"].ToString()) != null) {
                    fill_data("SELECT b_Title FROM books WHERE b_Barcode ='" + txt_barcode.Text + "'", lst_return);
                } else
                {
                    fill_data("SELECT b_Title FROM books WHERE b_Barcode ='" + txt_barcode.Text + "'", lst_borrow);
                }
                connection.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lst_search.Items.Clear();
            fill_data("SELECT b_Title FROM books WHERE b_Title ='" + txt_search.Text + "' AND b_Borrowed_by IS NULL", lst_borrow);
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

            if (MessageBox.Show($"You are about to borrow {bor} books and return {ret} books. Confirm?", "Books processing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult)
            {

                connection.Open();
                foreach(var listboxitem in lst_borrow.Items) 
                {
                    cmd = new MySqlCommand("UPDATE books SET b_Borrowed_by =" + Global.GlobalVar + "b_Due_Date = " + (due_date.ToString("YYYY-mm-dd H:mm:ss")) + "WHERE b_Title =" + listboxitem + ";");
                    cmd.ExecuteNonQuery();
                }

                foreach (var listboxitem in lst_return.Items)
                {
                    cmd = new MySqlCommand("UPDATE books SET b_Borrowed_by =" + null + "b_Due_Date = "+ null + "WHERE b_Title =" + listboxitem + ";");
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }


        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to clear all items in the scanned book lists. Confirm?", "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult) 
            {
                lst_borrow.Items.Clear();
                lst_return.Items.Clear();
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
            int i = lst_return.SelectedItems.Count;
            if (MessageBox.Show($"You are about to renew {i} books from the Return list. Confirm?", "Renew items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                lst_return.SelectedItems.Clear();
            }
        }
    }
}
