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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_bookinfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_logoff = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pubdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_edit = new System.Windows.Forms.TextBox();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.txt_bookn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_booklist = new System.Windows.Forms.GroupBox();
            this.grp_booksscan = new System.Windows.Forms.GroupBox();
            this.btn_renew = new System.Windows.Forms.Button();
            this.btn_erase_ret = new System.Windows.Forms.Button();
            this.btn_erase_bor = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lst_return = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lst_borrow = new System.Windows.Forms.ListBox();
            this.btn_process = new System.Windows.Forms.Button();
            this.grp_booksava = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lst_search = new System.Windows.Forms.ListBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lst_avabooks = new System.Windows.Forms.ListBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_bookinfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_booklist.SuspendLayout();
            this.grp_booksscan.SuspendLayout();
            this.grp_booksava.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.57014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.429864F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1346, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(365, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lam Tin Church Library System";
            // 
            // grp_bookinfo
            // 
            this.grp_bookinfo.Controls.Add(this.groupBox1);
            this.grp_bookinfo.Controls.Add(this.textBox1);
            this.grp_bookinfo.Controls.Add(this.label5);
            this.grp_bookinfo.Controls.Add(this.txt_pubdate);
            this.grp_bookinfo.Controls.Add(this.label7);
            this.grp_bookinfo.Controls.Add(this.txt_edit);
            this.grp_bookinfo.Controls.Add(this.txt_pub);
            this.grp_bookinfo.Controls.Add(this.txt_auth);
            this.grp_bookinfo.Controls.Add(this.txt_bookn);
            this.grp_bookinfo.Controls.Add(this.label4);
            this.grp_bookinfo.Controls.Add(this.label3);
            this.grp_bookinfo.Controls.Add(this.label2);
            this.grp_bookinfo.Controls.Add(this.label1);
            this.grp_bookinfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grp_bookinfo.Location = new System.Drawing.Point(0, 51);
            this.grp_bookinfo.Name = "grp_bookinfo";
            this.grp_bookinfo.Size = new System.Drawing.Size(200, 674);
            this.grp_bookinfo.TabIndex = 1;
            this.grp_bookinfo.TabStop = false;
            this.grp_bookinfo.Text = "BookInfo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_logoff);
            this.groupBox1.Controls.Add(this.btn_admin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 571);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txt_logoff
            // 
            this.txt_logoff.Location = new System.Drawing.Point(9, 45);
            this.txt_logoff.Name = "txt_logoff";
            this.txt_logoff.Size = new System.Drawing.Size(179, 23);
            this.txt_logoff.TabIndex = 12;
            this.txt_logoff.Text = "Log off";
            this.txt_logoff.UseVisualStyleBackColor = true;
            this.txt_logoff.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(9, 74);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(179, 23);
            this.btn_admin.TabIndex = 11;
            this.btn_admin.Text = "Admin Login";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 228);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Format:";
            // 
            // txt_pubdate
            // 
            this.txt_pubdate.Location = new System.Drawing.Point(78, 185);
            this.txt_pubdate.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txt_pubdate.Name = "txt_pubdate";
            this.txt_pubdate.ReadOnly = true;
            this.txt_pubdate.Size = new System.Drawing.Size(100, 20);
            this.txt_pubdate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Publish Year:";
            // 
            // txt_edit
            // 
            this.txt_edit.Location = new System.Drawing.Point(78, 142);
            this.txt_edit.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.ReadOnly = true;
            this.txt_edit.Size = new System.Drawing.Size(100, 20);
            this.txt_edit.TabIndex = 9;
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(78, 99);
            this.txt_pub.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.ReadOnly = true;
            this.txt_pub.Size = new System.Drawing.Size(100, 20);
            this.txt_pub.TabIndex = 8;
            // 
            // txt_auth
            // 
            this.txt_auth.Location = new System.Drawing.Point(78, 56);
            this.txt_auth.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.ReadOnly = true;
            this.txt_auth.Size = new System.Drawing.Size(100, 20);
            this.txt_auth.TabIndex = 7;
            // 
            // txt_bookn
            // 
            this.txt_bookn.Location = new System.Drawing.Point(78, 13);
            this.txt_bookn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txt_bookn.Name = "txt_bookn";
            this.txt_bookn.ReadOnly = true;
            this.txt_bookn.Size = new System.Drawing.Size(100, 20);
            this.txt_bookn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // grp_booklist
            // 
            this.grp_booklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_booklist.Controls.Add(this.grp_booksscan);
            this.grp_booklist.Controls.Add(this.grp_booksava);
            this.grp_booklist.Location = new System.Drawing.Point(203, 51);
            this.grp_booklist.Name = "grp_booklist";
            this.grp_booklist.Size = new System.Drawing.Size(1143, 674);
            this.grp_booklist.TabIndex = 2;
            this.grp_booklist.TabStop = false;
            this.grp_booklist.Text = "Book List";
            // 
            // grp_booksscan
            // 
            this.grp_booksscan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_booksscan.Controls.Add(this.btn_renew);
            this.grp_booksscan.Controls.Add(this.btn_erase_ret);
            this.grp_booksscan.Controls.Add(this.btn_erase_bor);
            this.grp_booksscan.Controls.Add(this.btn_clean);
            this.grp_booksscan.Controls.Add(this.txt_barcode);
            this.grp_booksscan.Controls.Add(this.label9);
            this.grp_booksscan.Controls.Add(this.lst_return);
            this.grp_booksscan.Controls.Add(this.label8);
            this.grp_booksscan.Controls.Add(this.lst_borrow);
            this.grp_booksscan.Controls.Add(this.btn_process);
            this.grp_booksscan.Location = new System.Drawing.Point(3, 369);
            this.grp_booksscan.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.grp_booksscan.Name = "grp_booksscan";
            this.grp_booksscan.Size = new System.Drawing.Size(1137, 302);
            this.grp_booksscan.TabIndex = 5;
            this.grp_booksscan.TabStop = false;
            this.grp_booksscan.Text = "Scanned books:";
            // 
            // btn_renew
            // 
            this.btn_renew.Location = new System.Drawing.Point(442, 14);
            this.btn_renew.Name = "btn_renew";
            this.btn_renew.Size = new System.Drawing.Size(75, 23);
            this.btn_renew.TabIndex = 13;
            this.btn_renew.Text = "Renew";
            this.btn_renew.UseVisualStyleBackColor = true;
            this.btn_renew.Visible = false;
            this.btn_renew.Click += new System.EventHandler(this.btn_renew_Click);
            // 
            // btn_erase_ret
            // 
            this.btn_erase_ret.Location = new System.Drawing.Point(361, 14);
            this.btn_erase_ret.Name = "btn_erase_ret";
            this.btn_erase_ret.Size = new System.Drawing.Size(75, 23);
            this.btn_erase_ret.TabIndex = 12;
            this.btn_erase_ret.Text = "Erase item";
            this.btn_erase_ret.UseVisualStyleBackColor = true;
            this.btn_erase_ret.Visible = false;
            this.btn_erase_ret.Click += new System.EventHandler(this.btn_erase_ret_Click);
            // 
            // btn_erase_bor
            // 
            this.btn_erase_bor.Location = new System.Drawing.Point(70, 13);
            this.btn_erase_bor.Name = "btn_erase_bor";
            this.btn_erase_bor.Size = new System.Drawing.Size(75, 23);
            this.btn_erase_bor.TabIndex = 11;
            this.btn_erase_bor.Text = "Erase item";
            this.btn_erase_bor.UseVisualStyleBackColor = true;
            this.btn_erase_bor.Visible = false;
            this.btn_erase_bor.Click += new System.EventHandler(this.btn_erase_bor_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clean.Location = new System.Drawing.Point(615, 270);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(513, 23);
            this.btn_clean.TabIndex = 10;
            this.btn_clean.Text = "Clear all items";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_barcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_barcode.Location = new System.Drawing.Point(615, 42);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(170, 20);
            this.txt_barcode.TabIndex = 8;
            this.txt_barcode.Text = "Click here when scanning books...";
            this.txt_barcode.Enter += new System.EventHandler(this.txt_barcode_Enter);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            this.txt_barcode.Leave += new System.EventHandler(this.txt_barcode_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "To return:";
            // 
            // lst_return
            // 
            this.lst_return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_return.FormattingEnabled = true;
            this.lst_return.Location = new System.Drawing.Point(305, 42);
            this.lst_return.Name = "lst_return";
            this.lst_return.ScrollAlwaysVisible = true;
            this.lst_return.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_return.Size = new System.Drawing.Size(296, 251);
            this.lst_return.TabIndex = 8;
            this.lst_return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lst_return_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "To borrow:";
            // 
            // lst_borrow
            // 
            this.lst_borrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_borrow.FormattingEnabled = true;
            this.lst_borrow.Location = new System.Drawing.Point(3, 42);
            this.lst_borrow.Name = "lst_borrow";
            this.lst_borrow.ScrollAlwaysVisible = true;
            this.lst_borrow.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_borrow.Size = new System.Drawing.Size(296, 251);
            this.lst_borrow.TabIndex = 0;
            this.lst_borrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lst_borrow_MouseClick);
            // 
            // btn_process
            // 
            this.btn_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_process.Location = new System.Drawing.Point(615, 68);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(513, 202);
            this.btn_process.TabIndex = 6;
            this.btn_process.Text = "Borrow/Return books";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_booksava
            // 
            this.grp_booksava.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_booksava.Controls.Add(this.label10);
            this.grp_booksava.Controls.Add(this.lst_search);
            this.grp_booksava.Controls.Add(this.lbl_welcome);
            this.grp_booksava.Controls.Add(this.lbl_result);
            this.grp_booksava.Controls.Add(this.btn_search);
            this.grp_booksava.Controls.Add(this.lst_avabooks);
            this.grp_booksava.Controls.Add(this.txt_search);
            this.grp_booksava.Location = new System.Drawing.Point(3, 16);
            this.grp_booksava.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.grp_booksava.Name = "grp_booksava";
            this.grp_booksava.Size = new System.Drawing.Size(1137, 353);
            this.grp_booksava.TabIndex = 4;
            this.grp_booksava.TabStop = false;
            this.grp_booksava.Text = "Available books:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Serach result:";
            // 
            // lst_search
            // 
            this.lst_search.FormattingEnabled = true;
            this.lst_search.Location = new System.Drawing.Point(305, 31);
            this.lst_search.Name = "lst_search";
            this.lst_search.ScrollAlwaysVisible = true;
            this.lst_search.Size = new System.Drawing.Size(296, 316);
            this.lst_search.TabIndex = 10;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(743, 20);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 13);
            this.lbl_welcome.TabIndex = 9;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(740, 294);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(886, 328);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lst_avabooks
            // 
            this.lst_avabooks.FormattingEnabled = true;
            this.lst_avabooks.Location = new System.Drawing.Point(3, 19);
            this.lst_avabooks.Name = "lst_avabooks";
            this.lst_avabooks.ScrollAlwaysVisible = true;
            this.lst_avabooks.Size = new System.Drawing.Size(296, 329);
            this.lst_avabooks.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(615, 328);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(265, 20);
            this.txt_search.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.Controls.Add(this.grp_booklist);
            this.Controls.Add(this.grp_bookinfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grp_bookinfo.ResumeLayout(false);
            this.grp_bookinfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grp_booklist.ResumeLayout(false);
            this.grp_booksscan.ResumeLayout(false);
            this.grp_booksscan.PerformLayout();
            this.grp_booksava.ResumeLayout(false);
            this.grp_booksava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grp_bookinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_edit;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.TextBox txt_bookn;
        private System.Windows.Forms.GroupBox grp_booklist;
        private System.Windows.Forms.ListBox lst_avabooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp_booksava;
        private System.Windows.Forms.GroupBox grp_booksscan;
        private System.Windows.Forms.ListBox lst_borrow;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.TextBox txt_pubdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_logoff;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lst_return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lst_search;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_erase_bor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_renew;
        private System.Windows.Forms.Button btn_erase_ret;
    }
}

