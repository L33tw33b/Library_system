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
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        MySqlConnection connection = new MySqlConnection(@"Server=localhost;Database=library;Uid=root;pwd=root;");
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
            
                i = 0;
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registered_members where Email='" + txt_user.Text + "' and Password='" + txt_pass.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Incorrect credentials");
                }
                else {
                    Global.GlobalVar = txt_user.Text;
                    this.Hide();
                    Form1 fm1 = new Form1();
                    fm1.Show();
                }

                connection.Close();

            
        }
    }
}
