using System;
using System.Configuration;
using System.Threading;
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
        string connection = ConfigurationManager.ConnectionStrings["library_sys.Properties.Settings.Setting"].ConnectionString;
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
                String command = "select * from registered_members where u_Name = @name and u_Password = @password;";
                MySqlCommand cmd = new MySqlCommand(command, mysqlcon);
                cmd.Parameters.AddWithValue("@name", txt_user.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass.Text);
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
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Form1 fm1 = new Form1(Convert.ToInt32(dr["u_Borrow_number"].ToString()), Convert.ToInt32(dr["u_Is_admin"].ToString()), txt_user.Text.Trim());
                            fm1.Show();
                            this.Hide();
                            
                            
                        }

                    }
                }


                mysqlcon.Close();
            }


            
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Registercs registerfrm = new Registercs();
            registerfrm.TopMost = true;
            registerfrm.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void btn_lang_Click(object sender, EventArgs e)
        {
            LangForm lang = new LangForm();
            this.Hide();
            lang.Show();
        }
    }
}
