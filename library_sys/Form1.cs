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
        string connection = "@Server=localhost;Database=library;Uid=root;pwd=root;";
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_barcode;
            txt_barcode.Focus();
            Form form1 = new Form();
            form1.FormBorderStyle = FormBorderStyle.None;

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
                txt_barcode.SelectAll();
                MessageBox.Show("key down");

            }
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
