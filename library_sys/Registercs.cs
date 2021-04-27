using System;
using System.Configuration;
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
    public partial class Registercs : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["library_sys.Properties.Settings.Setting"].ConnectionString;
        int uid = 0;
        bool IsEmpty() {
            if (String.IsNullOrEmpty(txt_uName.Text) || String.IsNullOrEmpty(txt_uPass.Text) || String.IsNullOrEmpty(txt_uRname.Text) || (String.IsNullOrEmpty(txt_uContact.Text) && String.IsNullOrEmpty(txt_uEmail.Text))) { 
                return true;
            } else { 
                return false;
            }
        }


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


        public Registercs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                int i = 0;
                mysqlcon.Open();
                String command = "select * from registered_members where u_Name = @user;";
                MySqlCommand scmd = new MySqlCommand(command, mysqlcon);
                scmd.Parameters.AddWithValue("@user", txt_uName.Text);
                scmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                MySqlDataReader dr = scmd.ExecuteReader();
                dt.Load(dr);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (!IsValidEmail(txt_uEmail.Text) && !String.IsNullOrEmpty(txt_uEmail.Text))
                {
                    MessageBox.Show("Invalid Email.");
                }
                else if (i == 1) {
                     MessageBox.Show("Username has already been taken."); 
                }
                else
                {
                    if (IsEmpty())
                    {
                        MessageBox.Show("Missing value in required TextBox.");
                    }
                    else
                    {
                        try
                        {
                            
                            MySqlCommand cmd = new MySqlCommand("AddOrEditUser", mysqlcon);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_ID", uid);
                            cmd.Parameters.AddWithValue("_Name", txt_uName.Text.Trim());
                            cmd.Parameters.AddWithValue("_Email", txt_uEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("_rName", txt_uRname.Text.Trim());
                            cmd.Parameters.AddWithValue("_Contact_no", txt_uContact.Text.Trim());
                            cmd.Parameters.AddWithValue("_Password", txt_uPass.Text);
                            cmd.Parameters.AddWithValue("_Is_admin", 0);
                            cmd.Parameters.AddWithValue("_Borrow_number", 2);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully registered!");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Occured!" + ex.Message);
                        }
                    }
                }
            }


        }

    }
}
