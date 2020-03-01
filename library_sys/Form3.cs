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
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("AddOrEdit", mysqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_BID", bid);
                cmd.Parameters.AddWithValue("_Seq", bid);
                cmd.Parameters.AddWithValue("_Subject", bid);
                cmd.Parameters.AddWithValue("_ISBN", bid);
                cmd.Parameters.AddWithValue("_Call_number", bid);
                cmd.Parameters.AddWithValue("_Barcode", bid);
                cmd.Parameters.AddWithValue("_Format", bid);
                cmd.Parameters.AddWithValue("_Title", bid);
                cmd.Parameters.AddWithValue("_Author", bid);
                cmd.Parameters.AddWithValue("_Publisher", bid);
                cmd.Parameters.AddWithValue("_Publication_date", bid);
                cmd.Parameters.AddWithValue("_Borrowed_by", null);
                cmd.Parameters.AddWithValue("_Due_Date", null);

            }
        }
    }
}
