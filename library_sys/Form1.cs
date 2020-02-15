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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_borrow.Visible = true; btn_return.Visible = true;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_barcode;
            txt_barcode.Focus();
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
    }
}
