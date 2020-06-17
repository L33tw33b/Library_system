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
        int uid = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Clear(grp_booksop);
            Clear(grp_userop);
            GridFill("BookViewAll",dgvbook);
            GridFill("UserViewAll",dgvuser);
            txt_bid.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            switch (Convert.ToInt32(txt_bid.Text)) {
                case 0:
                    message = $"Add book {txt_title.Text}?";
                    break;
                default:
                    message = $"Overwrite book {txt_title.Text} in book ID {txt_bid.Text}?";
                        break;
            }
            if (MessageBox.Show(message, "List update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    try
                    {
                        mysqlcon.Open();
                        MySqlCommand cmd = new MySqlCommand("AddOrEdit", mysqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_BID", Convert.ToInt32(txt_bid.Text));
                        cmd.Parameters.AddWithValue("_Seq", txt_seq.Text.Trim());
                        cmd.Parameters.AddWithValue("_Subject", txt_sub.Text.Trim());
                        cmd.Parameters.AddWithValue("_ISBN", txt_isbn.Text.Trim());
                        cmd.Parameters.AddWithValue("_Call_number", txt_call.Text.Trim());
                        cmd.Parameters.AddWithValue("_Barcode", txt_barcode.Text.Trim());
                        cmd.Parameters.AddWithValue("_Format", txt_format.Text.Trim());
                        cmd.Parameters.AddWithValue("_Title", txt_title.Text.Trim());
                        cmd.Parameters.AddWithValue("_Author", txt_auth.Text.Trim());
                        cmd.Parameters.AddWithValue("_Publisher", txt_pub.Text.Trim());
                        cmd.Parameters.AddWithValue("_Publication_year", txt_pubyear.Text.Trim());
                        cmd.Parameters.AddWithValue("_Borrowed_by", null);
                        cmd.Parameters.AddWithValue("_Due_Date", null);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Submitted.");
                        Clear(grp_booksop);
                        GridFill("BookViewAll", dgvbook);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occurred!" + ex.Message);
                    }



                }
            }

        }



        void GridFill(string pro,DataGridView control) {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                mysqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pro, mysqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                control.DataSource = dt;
                control.Columns[0].Visible = false;
            }
        }

        void Clear(GroupBox grp) { 
             foreach(Control c in grp.Controls)
            {
                if (c is TextBox) {
                    c.Text = String.Empty;
                }
            }
            btn_add.Text = "Save";
        }

        private void cbox_overdue_CheckedChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                if (cbox_overdue.CheckState == CheckState.Checked)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("ViewByOverdue", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbook.DataSource = dt;
                    dgvbook.Columns[0].Visible = false;
                } else {
                    GridFill("BookViewAll",dgvbook);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear(grp_booksop);
            txt_bid.Text = "0";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (MessageBox.Show("Delete book?", "Admin privilege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    try
                    {
                        mysqlcon.Open();
                        MySqlCommand cmd = new MySqlCommand("DeleteByID", mysqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_BID", Convert.ToInt32(txt_bid.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted.");
                        Clear(grp_booksop);
                        GridFill("BookViewAll", dgvbook);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured!" + ex);
                    }
                    mysqlcon.Close();
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                if (txt_search.Text != null)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SearchByValue", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_search.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbook.DataSource = dt;
                    dgvbook.Columns[0].Visible = false;
                } else
                {
                    mysqlcon.Open();
                    GridFill("BookViewAll",dgvbook);
                }

                mysqlcon.Close();
            }
        }

        private void btn_uadd_Click(object sender, EventArgs e)
        {
            string message = "";
            switch (Convert.ToInt32(txt_uid.Text))
            {
                case 0:
                    message = $"Add user {txt_u_name.Text}?";
                    break;
                default:
                    message = $"Overwrite user data {txt_u_name.Text} in user ID {txt_bid.Text}?";
                    break;
            }
            if (MessageBox.Show(message, "List update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    try
                    {
                        mysqlcon.Open();
                        MySqlCommand cmd = new MySqlCommand("AddOrEditUser", mysqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_ID", uid);
                        cmd.Parameters.AddWithValue("_Name", txt_u_name.Text.Trim());
                        cmd.Parameters.AddWithValue("_Email", txt_u_email.Text.Trim());
                        cmd.Parameters.AddWithValue("_Contact_no", txt_u_contact.Text.Trim());
                        cmd.Parameters.AddWithValue("_Password", txt_u_pass.Text);
                        cmd.Parameters.AddWithValue("_Is_admin", 0);
                        cmd.Parameters.AddWithValue("_Borrow_number", 2);
                        cmd.Parameters.AddWithValue("_rName", txt_rName.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Submitted.");
                        Clear(grp_userop);
                        GridFill("UserViewAll", dgvuser);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occurred!" + ex.Message);
                    }

                    mysqlcon.Close();
                }
            }
        }

        private void btn_usearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (txt_search.Text != null)
                {
                    mysqlcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SearchByValueUser", mysqlcon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_usearch.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvuser.DataSource = dt;
                    dgvuser.Columns[0].Visible = false;
                }
                else
                {
                    GridFill("UserViewAll", dgvbook);
                }
                mysqlcon.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selecteduser = dgvuser.CurrentRow.Cells["u_Name"].Value.ToString();
            if (dgvbook.CurrentRow.Index != -1)
            {
                if (Convert.ToInt32(dgvuser.CurrentRow.Cells["u_Is_admin"].Value) == 0)
                {
                    if (MessageBox.Show($"You are about to give admin privilege to {selecteduser}.", "Admin privilege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                        {
                            try
                            {
                                mysqlcon.Open();
                                MySqlCommand cmd = new MySqlCommand("UPDATE registered_members SET u_Is_admin = 1 WHERE u_Name = '" + selecteduser + "';", mysqlcon);
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Privilege has been given.");
                                mysqlcon.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show($"You are about to confine admin privilege from {selecteduser}.", "Admin privilege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                        {
                            try
                            {
                                mysqlcon.Open();
                                MySqlCommand cmd = new MySqlCommand("UPDATE registered_members SET u_Is_admin = 0 WHERE u_Name = '" + selecteduser + "';", mysqlcon);
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Privilege has been taken.");
                                mysqlcon.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Please select a user.");
            }
            Clear(grp_userop);
            GridFill("UserViewAll", dgvuser);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string selectedbook = txt_title.Text;
            if (MessageBox.Show($"Return {selectedbook}?", "Admin privilege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvbook.CurrentRow.Cells[11].Value == System.DBNull.Value)
                {
                    MessageBox.Show("Book has already been returned!");
                }
                else
                {
                    using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                    {
                        try
                        {
                            mysqlcon.Open();
                            MySqlCommand cmd = new MySqlCommand("ReturnBook", mysqlcon);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_Title", txt_title.Text.Trim());
                            cmd.Parameters.AddWithValue("_Borrowed_by", dgvbook.CurrentRow.Cells[11].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Process complete.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Book Title may not exist! \n" + ex.Message);
                        }
                        mysqlcon.Close();
                    }
                    
                }
                Clear(grp_booksop);
                GridFill("BookViewAll", dgvbook);
            }
        }
        private void dgvbook_Click(object sender, EventArgs e)
        {

            if (dgvbook.CurrentRow.Index != -1)
            {
                txt_seq.Text = dgvbook.CurrentRow.Cells[1].Value.ToString();
                txt_sub.Text = dgvbook.CurrentRow.Cells[2].Value.ToString();
                txt_isbn.Text = dgvbook.CurrentRow.Cells[3].Value.ToString();
                txt_call.Text = dgvbook.CurrentRow.Cells[4].Value.ToString();
                txt_barcode.Text = dgvbook.CurrentRow.Cells[5].Value.ToString();
                txt_format.Text = dgvbook.CurrentRow.Cells[6].Value.ToString();
                txt_title.Text = dgvbook.CurrentRow.Cells[7].Value.ToString();
                txt_auth.Text = dgvbook.CurrentRow.Cells[8].Value.ToString();
                txt_pub.Text = dgvbook.CurrentRow.Cells[9].Value.ToString();
                txt_pubyear.Text = dgvbook.CurrentRow.Cells[10].Value.ToString();
                txt_bid.Text = dgvbook.CurrentRow.Cells[0].Value.ToString();
            }
            btn_add.Text = "Edit";
        }

        private void dgvuser_Click(object sender, EventArgs e)
        {
            if (dgvuser.CurrentRow.Index != -1)
            {

                txt_u_name.Text = dgvuser.CurrentRow.Cells[1].Value.ToString();
                txt_u_email.Text = dgvuser.CurrentRow.Cells[2].Value.ToString();
                txt_u_contact.Text = dgvuser.CurrentRow.Cells[3].Value.ToString();
                txt_u_pass.Text = dgvuser.CurrentRow.Cells[4].Value.ToString();
                txt_rName.Text = dgvuser.CurrentRow.Cells[7].Value.ToString();
                txt_uid.Text = dgvuser.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    if (txt_search.Text != null)
                    {
                        mysqlcon.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter("SearchByValue", mysqlcon);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_search.Text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvbook.DataSource = dt;
                        dgvbook.Columns[0].Visible = false;
                    }
                    else
                    {
                        mysqlcon.Open();
                        GridFill("BookViewAll", dgvbook);
                    }

                    mysqlcon.Close();
                }
            }
        }

        private void txt_usearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    if (txt_search.Text != null)
                    {
                        mysqlcon.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter("SearchByValueUser", mysqlcon);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_usearch.Text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvuser.DataSource = dt;
                        dgvuser.Columns[0].Visible = false;
                    }
                    else
                    {
                        GridFill("UserViewAll", dgvbook);
                    }
                    mysqlcon.Close();

                }
            }

        }

        private void btn_udel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (MessageBox.Show("Delete user?", "Admin privilege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        mysqlcon.Open();
                        MySqlCommand cmd = new MySqlCommand("DeleteByIDUser", mysqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_UID", Convert.ToInt32(txt_uid.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted.");
                        Clear(grp_booksop);
                        GridFill("UserViewAll", dgvuser);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured!" + ex);
                    }
                    mysqlcon.Close();
                }
            }
        }

        private void btn_uclear_Click(object sender, EventArgs e)
        {
            Clear(grp_userop);
            txt_uid.Text = "0";
        }
    }
}
