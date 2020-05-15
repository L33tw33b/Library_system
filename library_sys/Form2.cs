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

    public partial class Form2 : Form
    {
        string connection = @"Server=localhost;Database=library;Uid=root;pwd=root;";
        int i;



        public Form2()            
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                i = 0;
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("select * from registered_members where u_Name = '" + txt_user.Text + "' and u_Password = '" + txt_pass.Text + "'", mysqlcon);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                using (dr) {
                    if (i == 0)
                    {
                        MessageBox.Show("Incorrect credentials");
                    }
                    else
                    {
                        Global.GlobalVar = txt_user.Text;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            this.Hide();
                            Form1 fm1 = new Form1(Convert.ToInt32(dr["u_Borrow_number"].ToString()), Convert.ToInt32(dr["u_Is_admin"].ToString()));
                            fm1.Show();
                        }

                    }
                }


                mysqlcon.Close();
            }


            
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Registercs registerfrm = new Registercs();
            registerfrm.Show();
        }
    }
}
