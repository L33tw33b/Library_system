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
    public partial class Form1 : Form
    {
        int borrowamount = 0; //Amount of books that can be borrowed (Initial value)
        int adminval = 0; // Is admin or not
        int iniamount = 0; // Initial amount of books borrowed;
        string currentuser;
        string connection = ConfigurationManager.ConnectionStrings["library_sys.Properties.Settings.Setting"].ConnectionString;
        Form2 fm2 = new Form2();       
        public Form1(int value,int admin, string user)
        {
            
            InitializeComponent();
            borrowamount = value;
            adminval = admin;
            iniamount = value;
            currentuser = user;
        }


        void GridFill(string pro, DataGridView control)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pro, mysqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_SearchValue", txt_search.Text.ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                control.DataSource = dt;
                control.Columns[0].Visible = false;
                control.Columns[1].Visible = false;
                control.Columns[2].Visible = false;
                control.Columns[3].Visible = false;
                control.Columns[4].Visible = false;
                control.Columns[5].Visible = false;
                control.Columns[6].Visible = false;
                control.Columns[11].Visible = false;
                control.Columns[12].Visible = false;
                control.Columns[13].Visible = false;
                
            }
        }

        void Clear(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
            
        }

        void Fillinfo(DataGridView dgv) {

            if (dgv.CurrentRow.Index != -1)
            {
                txt_bookn.Text = dgv_books.CurrentRow.Cells[7].Value.ToString();
                txt_auth.Text = dgv_books.CurrentRow.Cells[8].Value.ToString();
                txt_pub.Text = dgv_books.CurrentRow.Cells[9].Value.ToString();
                txt_sub.Text = dgv_books.CurrentRow.Cells[2].Value.ToString();
                txt_pubyear.Text = dgv_books.CurrentRow.Cells[10].Value.ToString();
            }               
        }
            
        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (adminval == 0) {
                btn_admin.Visible = false;
            }
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag) {
                case "zh-HK": MessageBox.Show($"你可借 {borrowamount} 本書.");
                    break;
                case "en-US":
                    MessageBox.Show($"You can borrow {borrowamount} books.");
                    break;
            }
            
            txt_barcode.Focus();
            Clear(grp_booklist);
            GridFill("BookViewAll",dgv_books);
            DataGridViewColumn col1 = dgv_books.Columns[7];
            col1.Width = 300;
            dgv_borrow.ColumnCount = 1;
            dgv_return.ColumnCount = 3;
            dgv_borrow.Columns[0].Name = "Books";
            dgv_return.Columns[0].Name = "Books";
            dgv_return.Columns[1].Name = "Renewed";
            dgv_return.Columns[2].Name = "Due Date";
            foreach (DataGridViewRow row in dgv_books.Rows) {
                if (row.Cells[11].Value != System.DBNull.Value) {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void txt_barcode_Enter(object sender, EventArgs e)
        {
            if (txt_barcode.Text == "掃描書籍按此..." || txt_barcode.Text == "Click here when scanning books...")
            {
                txt_barcode.Text = "";

                txt_barcode.ForeColor = Color.Black;
            }
        }

        private void txt_barcode_Leave(object sender, EventArgs e)
        {
            if (txt_barcode.Text == "")
            {
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "zh-HK":
                        txt_barcode.Text = "掃描書籍按此..."; 
                        break;
                    case "en-US":
                        txt_barcode.Text = "Click here when scanning books...";
                        break;
                }
                
                
                txt_barcode.ForeColor = Color.Silver;
            }
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (e.KeyCode == Keys.Enter)
                {
                   
                        mysqlcon.Open();
                        int dgvborrow_rows = dgv_borrow.Rows.Count - 1;
                        int dgvreturn_rows = dgv_return.Rows.Count - 1;
                        bool exist = false;
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM books WHERE b_Barcode = '" + txt_barcode.Text + "'", mysqlcon);
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr["b_Borrowed_by"] != System.DBNull.Value && currentuser != dr["b_Borrowed_by"].ToString())
                        {
                            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                            {
                                case "zh-HK":
                                    MessageBox.Show("項目己掃描.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case "en-US":
                                    MessageBox.Show("Item was borrowed by another personel, please contact the admin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < dgvborrow_rows; i++)
                            {
                                if (dgv_borrow.Rows[i].Cells[0].Value.Equals(dr["b_Title"])) { exist = true; }
                            }
                            for (int i = 0; i < dgvreturn_rows; i++)
                            {
                                if (dgv_return.Rows[i].Cells[0].Value.Equals(dr["b_Title"])) { exist = true; }
                            }
                            if (exist)
                            {
                                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                                {
                                    case "zh-HK":
                                        MessageBox.Show("項目己掃描.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                    case "en-US":
                                        MessageBox.Show("Item has already been scanned.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                }


                            }
                            else
                            {
                                if (dr["b_Borrowed_by"] == System.DBNull.Value)
                                {
                                    if (borrowamount > 0)
                                    {
                                        dgv_borrow.Rows.Add(dr["b_Title"]);
                                        borrowamount--;
                                    }
                                    else
                                    {
                                        switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                                        {
                                            case "zh-HK":
                                                MessageBox.Show("你不可借閱多於2本書.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            case "en-US":
                                                MessageBox.Show("You cannot borrow more than 2 books.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                        }

                                    }

                                }
                                else
                                {
                                    dgv_return.Rows.Add(dr["b_Title"], dr["b_renewed"], dr["b_Due_Date"]);
                                    borrowamount++;
                                }

                            }

                        }
                    }
                    else
                    {
                        switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                        {
                            case "zh-HK":
                                MessageBox.Show("項目不屬於數據庫!請確定而清除文本框內容.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            case "en-US":
                                MessageBox.Show("Item does not belong to the database! Please make sure to clear textbox.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }


                    }
                    mysqlcon.Close();
                    txt_barcode.SelectAll();
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                if (txt_search.Text != null && !string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    mysqlcon.Open();
                    GridFill("SearchByValue", dgv_search);
                }
                else
                {
                    
                    dgv_search.Columns.Clear();
                    
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "", endmessage = "";
            int bor, ret;
            bor = dgv_borrow.Rows.Count - 1;
            ret = dgv_return.Rows.Count - 1;
            DateTime due_date = DateTime.Today.AddDays(14);
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag) {
                case "zh-HK": message = $"你將要借{bor}本書及還{ret}本書.確定?";
                    endmessage = "操作完成.";
                    break;
                case "en-US": message = $"You are about to borrow {bor} books and return {ret} books. Confirm?";
                    endmessage = "Process complete.";
                    break;
            }
            if (MessageBox.Show(message, "Books processing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    foreach (DataGridViewRow item in dgv_borrow.Rows)
                    {
                        if (item.Cells["Books"].Value != System.DBNull.Value) {
                                MySqlDataAdapter da = new MySqlDataAdapter("BorrowBook", mysqlcon);
                                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                                da.SelectCommand.Parameters.AddWithValue("_Title", item.Cells["Books"].Value);
                                da.SelectCommand.Parameters.AddWithValue("_Borrowed_by", currentuser);
                                da.SelectCommand.Parameters.AddWithValue("_Due_Date", due_date.ToString("yyyy-MM-dd H:mm:ss"));
                                da.SelectCommand.ExecuteNonQuery();
                        }


                    }

                    foreach (DataGridViewRow item in dgv_return.Rows)
                    {
                        if (item.Cells["Books"].Value != System.DBNull.Value)
                        {
                                MySqlDataAdapter da = new MySqlDataAdapter("ReturnBook", mysqlcon);
                                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                                da.SelectCommand.Parameters.AddWithValue("_Title", item.Cells["Books"].Value);
                                da.SelectCommand.Parameters.AddWithValue("_Borrowed_by", currentuser);
                                da.SelectCommand.ExecuteNonQuery();
                        }
                    }
                    mysqlcon.Close();
                    MessageBox.Show(endmessage);
                    dgv_borrow.Rows.Clear();
                    dgv_return.Rows.Clear();
                    Clear(grp_booklist);
                    GridFill("BookViewAll", dgv_books);
                    fm2.Show();
                    this.Hide();
                    
                    
                    
                }

            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            string message = "";
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "zh-HK":
                    message = $"清除所有項目?";
                    break;
                case "en-US":
                    message = $"Clear all items?";
                    break;
            }
            if (MessageBox.Show(message, "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                dgv_return.Rows.Clear();
                dgv_borrow.Rows.Clear();
                borrowamount = iniamount;
            }
        }

        private void btn_erase_bor_Click(object sender, EventArgs e)
        {
            int delamountbor = dgv_borrow.SelectedRows.Count;
            string message = "";
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "zh-HK":
                    message = $"從借閱清單清除{delamountbor}本書?";
                    break;
                case "en-US":
                    message = $"Delete {delamountbor} from borrow list?";
                    break;
            }
            if (MessageBox.Show(message, "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                try {
                    dgv_borrow.Rows.RemoveAt(this.dgv_borrow.SelectedRows[0].Index);
                    borrowamount += delamountbor;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_erase_ret_Click(object sender, EventArgs e)
        {
            int delamountret = dgv_return.SelectedRows.Count;
            string message = "";
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "zh-HK":
                    message = $"從借閱清單清除{delamountret}本書?";
                    break;
                case "en-US":
                    message = $"Delete {delamountret} from borrow list?";
                    break;
            }
            if (MessageBox.Show(message, "Delete items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                    dgv_return.Rows.RemoveAt(this.dgv_return.SelectedRows[0].Index);
                    borrowamount -= delamountret;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
        }

        private void btn_renew_Click(object sender, EventArgs e)
        {
            int renewamount = dgv_return.SelectedRows.Count;
            string message = "", endmessage = "", errmess = "";
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "zh-HK":
                    message = $"續借{renewamount}本書?";
                    endmessage = "操作完成.";
                    break;
                case "en-US":
                    message = $"Renew {renewamount} books?";
                    endmessage = "Process complete.";
                    break;
            }      
                if (MessageBox.Show($"續借{renewamount}本書?", "Renew items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    /*MySqlCommand cmd = new MySqlCommand("SELECT * FROM books", mysqlcon);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader dr = cmd.ExecuteReader();*/

                    MySqlCommand cmd = new MySqlCommand("RenewBook", mysqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DateTime today = DateTime.Now;
                    try
                    {
                        foreach (DataGridViewRow listboxitems in dgv_return.SelectedRows)
                        {

                            DateTime old_due = Convert.ToDateTime(listboxitems.Cells[2].Value.ToString());
                            if ((listboxitems.Cells[1].Value.ToString() == "0") && (old_due > today.Date))
                            {
                                DateTime new_due_date = DateTime.Today.AddDays(14);
                                cmd.Parameters.AddWithValue("_New_Date", new_due_date.ToString("yyyy-MM-dd H:mm:ss"));
                                cmd.Parameters.AddWithValue("_b_Title", listboxitems.Cells[0].Value.ToString());
                                dgv_return.Rows.Remove(listboxitems);
                                borrowamount -= renewamount;
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                                {
                                    case "zh-HK":
                                        errmess = $"{listboxitems.ToString()} 不可續借,因為已經被更新或超過了到止日期。";
                                        break;
                                    case "en-US":
                                        errmess = $"{listboxitems.ToString()} cannot be renewed as it has already been renewed or exceed due date.";
                                        break;
                                }
                                MessageBox.Show(errmess);
                            }
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }


                    MessageBox.Show(endmessage);
                    GridFill("BookViewAll", dgv_books);
                    
                }
            }
        }

        private void dgv_books_Click(object sender, EventArgs e)
        {
            Fillinfo(dgv_books);

        }

        private void dgv_search_Click(object sender, EventArgs e)
        {
            Fillinfo(dgv_search);

        }

        private void dgv_return_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgv_return.CurrentRow.Index != -1 && dgv_return.SelectedRows[0].Cells["Books"].Value != System.DBNull.Value)

                {
                    btn_erase_ret.Visible = true;
                    btn_renew.Visible = true;
                }
                else
                {
                    btn_erase_ret.Visible = false;
                    btn_renew.Visible = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgv_borrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_borrow.CurrentRow.Index != -1 && dgv_borrow.SelectedRows[0].Cells["Books"].Value != System.DBNull.Value)
                {
                    btn_erase_bor.Visible = true;
                }
                else
                {
                    btn_erase_bor.Visible = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm2.Show();
            this.Hide();
            
        }

        private void btn_chi_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-HK");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btn_eng_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void grp_booklist_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    if (txt_search.Text != null && !string.IsNullOrWhiteSpace(txt_search.Text))
                    {
                        mysqlcon.Open();
                        GridFill("SearchByValue", dgv_search);
                    }
                    else
                    {

                        dgv_search.Columns.Clear();

                    }


                }
            }
        }
    }
}
