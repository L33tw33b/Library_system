namespace library_sys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_bookinfo = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_record = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_logoff = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.txt_pubyear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.txt_bookn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_booklist = new System.Windows.Forms.GroupBox();
            this.grp_booksscan = new System.Windows.Forms.GroupBox();
            this.dgv_return = new System.Windows.Forms.DataGridView();
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.btn_renew = new System.Windows.Forms.Button();
            this.btn_erase_ret = new System.Windows.Forms.Button();
            this.btn_erase_bor = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.grp_booksava = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_bookinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_record)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_booklist.SuspendLayout();
            this.grp_booksscan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            this.grp_booksava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // grp_bookinfo
            // 
            resources.ApplyResources(this.grp_bookinfo, "grp_bookinfo");
            this.grp_bookinfo.Controls.Add(this.label11);
            this.grp_bookinfo.Controls.Add(this.dgv_record);
            this.grp_bookinfo.Controls.Add(this.groupBox1);
            this.grp_bookinfo.Controls.Add(this.txt_pubyear);
            this.grp_bookinfo.Controls.Add(this.label7);
            this.grp_bookinfo.Controls.Add(this.txt_sub);
            this.grp_bookinfo.Controls.Add(this.txt_pub);
            this.grp_bookinfo.Controls.Add(this.txt_auth);
            this.grp_bookinfo.Controls.Add(this.txt_bookn);
            this.grp_bookinfo.Controls.Add(this.label4);
            this.grp_bookinfo.Controls.Add(this.label3);
            this.grp_bookinfo.Controls.Add(this.label2);
            this.grp_bookinfo.Controls.Add(this.label1);
            this.grp_bookinfo.Name = "grp_bookinfo";
            this.grp_bookinfo.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // dgv_record
            // 
            this.dgv_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_record, "dgv_record");
            this.dgv_record.Name = "dgv_record";
            this.dgv_record.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_logoff);
            this.groupBox1.Controls.Add(this.btn_admin);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txt_logoff
            // 
            resources.ApplyResources(this.txt_logoff, "txt_logoff");
            this.txt_logoff.Name = "txt_logoff";
            this.txt_logoff.UseVisualStyleBackColor = true;
            this.txt_logoff.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_admin
            // 
            resources.ApplyResources(this.btn_admin, "btn_admin");
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // txt_pubyear
            // 
            resources.ApplyResources(this.txt_pubyear, "txt_pubyear");
            this.txt_pubyear.Name = "txt_pubyear";
            this.txt_pubyear.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txt_sub
            // 
            resources.ApplyResources(this.txt_sub, "txt_sub");
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.ReadOnly = true;
            // 
            // txt_pub
            // 
            resources.ApplyResources(this.txt_pub, "txt_pub");
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.ReadOnly = true;
            // 
            // txt_auth
            // 
            resources.ApplyResources(this.txt_auth, "txt_auth");
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.ReadOnly = true;
            // 
            // txt_bookn
            // 
            resources.ApplyResources(this.txt_bookn, "txt_bookn");
            this.txt_bookn.Name = "txt_bookn";
            this.txt_bookn.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // grp_booklist
            // 
            resources.ApplyResources(this.grp_booklist, "grp_booklist");
            this.grp_booklist.Controls.Add(this.grp_booksscan);
            this.grp_booklist.Controls.Add(this.grp_booksava);
            this.grp_booklist.Name = "grp_booklist";
            this.grp_booklist.TabStop = false;
            this.grp_booklist.Enter += new System.EventHandler(this.grp_booklist_Enter);
            // 
            // grp_booksscan
            // 
            resources.ApplyResources(this.grp_booksscan, "grp_booksscan");
            this.grp_booksscan.Controls.Add(this.dgv_return);
            this.grp_booksscan.Controls.Add(this.dgv_borrow);
            this.grp_booksscan.Controls.Add(this.btn_renew);
            this.grp_booksscan.Controls.Add(this.btn_erase_ret);
            this.grp_booksscan.Controls.Add(this.btn_erase_bor);
            this.grp_booksscan.Controls.Add(this.btn_clean);
            this.grp_booksscan.Controls.Add(this.txt_barcode);
            this.grp_booksscan.Controls.Add(this.label9);
            this.grp_booksscan.Controls.Add(this.label8);
            this.grp_booksscan.Controls.Add(this.btn_process);
            this.grp_booksscan.Name = "grp_booksscan";
            this.grp_booksscan.TabStop = false;
            // 
            // dgv_return
            // 
            resources.ApplyResources(this.dgv_return, "dgv_return");
            this.dgv_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_return.MultiSelect = false;
            this.dgv_return.Name = "dgv_return";
            this.dgv_return.ReadOnly = true;
            this.dgv_return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_return.Click += new System.EventHandler(this.dgv_return_Click);
            // 
            // dgv_borrow
            // 
            resources.ApplyResources(this.dgv_borrow, "dgv_borrow");
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrow.MultiSelect = false;
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.ReadOnly = true;
            this.dgv_borrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_borrow.Click += new System.EventHandler(this.dgv_borrow_Click);
            // 
            // btn_renew
            // 
            resources.ApplyResources(this.btn_renew, "btn_renew");
            this.btn_renew.Name = "btn_renew";
            this.btn_renew.UseVisualStyleBackColor = true;
            this.btn_renew.Click += new System.EventHandler(this.btn_renew_Click);
            // 
            // btn_erase_ret
            // 
            resources.ApplyResources(this.btn_erase_ret, "btn_erase_ret");
            this.btn_erase_ret.Name = "btn_erase_ret";
            this.btn_erase_ret.UseVisualStyleBackColor = true;
            this.btn_erase_ret.Click += new System.EventHandler(this.btn_erase_ret_Click);
            // 
            // btn_erase_bor
            // 
            resources.ApplyResources(this.btn_erase_bor, "btn_erase_bor");
            this.btn_erase_bor.Name = "btn_erase_bor";
            this.btn_erase_bor.UseVisualStyleBackColor = true;
            this.btn_erase_bor.Click += new System.EventHandler(this.btn_erase_bor_Click);
            // 
            // btn_clean
            // 
            resources.ApplyResources(this.btn_clean, "btn_clean");
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // txt_barcode
            // 
            resources.ApplyResources(this.txt_barcode, "txt_barcode");
            this.txt_barcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Enter += new System.EventHandler(this.txt_barcode_Enter);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            this.txt_barcode.Leave += new System.EventHandler(this.txt_barcode_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btn_process
            // 
            resources.ApplyResources(this.btn_process, "btn_process");
            this.btn_process.Name = "btn_process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_booksava
            // 
            resources.ApplyResources(this.grp_booksava, "grp_booksava");
            this.grp_booksava.Controls.Add(this.label5);
            this.grp_booksava.Controls.Add(this.dgv_search);
            this.grp_booksava.Controls.Add(this.dgv_books);
            this.grp_booksava.Controls.Add(this.label10);
            this.grp_booksava.Controls.Add(this.lbl_welcome);
            this.grp_booksava.Controls.Add(this.lbl_result);
            this.grp_booksava.Controls.Add(this.btn_search);
            this.grp_booksava.Controls.Add(this.txt_search);
            this.grp_booksava.Name = "grp_booksava";
            this.grp_booksava.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Name = "label5";
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_search, "dgv_search");
            this.dgv_search.MultiSelect = false;
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.ReadOnly = true;
            this.dgv_search.Click += new System.EventHandler(this.dgv_search_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_books, "dgv_books");
            this.dgv_books.MultiSelect = false;
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
            this.dgv_books.Click += new System.EventHandler(this.dgv_books_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lbl_welcome
            // 
            resources.ApplyResources(this.lbl_welcome, "lbl_welcome");
            this.lbl_welcome.Name = "lbl_welcome";
            // 
            // lbl_result
            // 
            resources.ApplyResources(this.lbl_result, "lbl_result");
            this.lbl_result.Name = "lbl_result";
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_booklist);
            this.Controls.Add(this.grp_bookinfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grp_bookinfo.ResumeLayout(false);
            this.grp_bookinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_record)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grp_booklist.ResumeLayout(false);
            this.grp_booksscan.ResumeLayout(false);
            this.grp_booksscan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            this.grp_booksava.ResumeLayout(false);
            this.grp_booksava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grp_bookinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.TextBox txt_bookn;
        private System.Windows.Forms.GroupBox grp_booklist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp_booksava;
        private System.Windows.Forms.GroupBox grp_booksscan;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.TextBox txt_pubyear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_logoff;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_erase_bor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_renew;
        private System.Windows.Forms.Button btn_erase_ret;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.DataGridView dgv_return;
        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_record;
    }
}

