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
            fill_data("SELECT b_Title FROM books", lst_avabooks);
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
            lst_avabooks.Items.Clear();
            fill_data("SELECT b_Title FROM books WHERE b_Barcode ='" + txt_search.Text + "'", lst_borrow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            fm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
