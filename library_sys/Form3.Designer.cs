namespace library_sys
{
    partial class Form3
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
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.grp_userop = new System.Windows.Forms.GroupBox();
            this.btn_giveadmin = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_rName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_u_pass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_u_contact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_u_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_u_name = new System.Windows.Forms.TextBox();
            this.btn_uclear = new System.Windows.Forms.Button();
            this.btn_udel = new System.Windows.Forms.Button();
            this.btn_uadd = new System.Windows.Forms.Button();
            this.grp_booksop = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_seq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_call = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_format = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pubyear = new System.Windows.Forms.TextBox();
            this.lbl_seq = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_overdue = new System.Windows.Forms.CheckBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_usearch = new System.Windows.Forms.Button();
            this.txt_usearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.grp_userop.SuspendLayout();
            this.grp_booksop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvuser
            // 
            this.dgvuser.AllowUserToAddRows = false;
            this.dgvuser.AllowUserToDeleteRows = false;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(339, 11);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.ReadOnly = true;
            this.dgvuser.Size = new System.Drawing.Size(979, 333);
            this.dgvuser.TabIndex = 0;
            this.dgvuser.Click += new System.EventHandler(this.dgvuser_Click);
            // 
            // grp_userop
            // 
            this.grp_userop.Controls.Add(this.btn_giveadmin);
            this.grp_userop.Controls.Add(this.label17);
            this.grp_userop.Controls.Add(this.txt_rName);
            this.grp_userop.Controls.Add(this.label16);
            this.grp_userop.Controls.Add(this.txt_u_pass);
            this.grp_userop.Controls.Add(this.label15);
            this.grp_userop.Controls.Add(this.txt_u_contact);
            this.grp_userop.Controls.Add(this.label14);
            this.grp_userop.Controls.Add(this.txt_u_email);
            this.grp_userop.Controls.Add(this.label13);
            this.grp_userop.Controls.Add(this.txt_u_name);
            this.grp_userop.Controls.Add(this.btn_uclear);
            this.grp_userop.Controls.Add(this.dgvuser);
            this.grp_userop.Controls.Add(this.btn_udel);
            this.grp_userop.Controls.Add(this.btn_uadd);
            this.grp_userop.Location = new System.Drawing.Point(14, 14);
            this.grp_userop.Name = "grp_userop";
            this.grp_userop.Size = new System.Drawing.Size(1324, 350);
            this.grp_userop.TabIndex = 1;
            this.grp_userop.TabStop = false;
            this.grp_userop.Text = "Users options";
            // 
            // btn_giveadmin
            // 
            this.btn_giveadmin.Location = new System.Drawing.Point(252, 293);
            this.btn_giveadmin.Name = "btn_giveadmin";
            this.btn_giveadmin.Size = new System.Drawing.Size(75, 51);
            this.btn_giveadmin.TabIndex = 43;
            this.btn_giveadmin.Text = "Admin Privilege";
            this.btn_giveadmin.UseVisualStyleBackColor = true;
            this.btn_giveadmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Full Name:";
            // 
            // txt_rName
            // 
            this.txt_rName.Location = new System.Drawing.Point(9, 197);
            this.txt_rName.Name = "txt_rName";
            this.txt_rName.Size = new System.Drawing.Size(100, 20);
            this.txt_rName.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Password:";
            // 
            // txt_u_pass
            // 
            this.txt_u_pass.Location = new System.Drawing.Point(9, 153);
            this.txt_u_pass.Name = "txt_u_pass";
            this.txt_u_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_u_pass.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Contact_no:";
            // 
            // txt_u_contact
            // 
            this.txt_u_contact.Location = new System.Drawing.Point(9, 114);
            this.txt_u_contact.Name = "txt_u_contact";
            this.txt_u_contact.Size = new System.Drawing.Size(100, 20);
            this.txt_u_contact.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Email:";
            // 
            // txt_u_email
            // 
            this.txt_u_email.Location = new System.Drawing.Point(9, 75);
            this.txt_u_email.Name = "txt_u_email";
            this.txt_u_email.Size = new System.Drawing.Size(100, 20);
            this.txt_u_email.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Name:";
            // 
            // txt_u_name
            // 
            this.txt_u_name.Location = new System.Drawing.Point(9, 36);
            this.txt_u_name.Name = "txt_u_name";
            this.txt_u_name.Size = new System.Drawing.Size(100, 20);
            this.txt_u_name.TabIndex = 32;
            // 
            // btn_uclear
            // 
            this.btn_uclear.Location = new System.Drawing.Point(171, 321);
            this.btn_uclear.Name = "btn_uclear";
            this.btn_uclear.Size = new System.Drawing.Size(75, 23);
            this.btn_uclear.TabIndex = 30;
            this.btn_uclear.Text = "Clear";
            this.btn_uclear.UseVisualStyleBackColor = true;
            // 
            // btn_udel
            // 
            this.btn_udel.Location = new System.Drawing.Point(90, 321);
            this.btn_udel.Name = "btn_udel";
            this.btn_udel.Size = new System.Drawing.Size(75, 23);
            this.btn_udel.TabIndex = 29;
            this.btn_udel.Text = "Delete";
            this.btn_udel.UseVisualStyleBackColor = true;
            // 
            // btn_uadd
            // 
            this.btn_uadd.Location = new System.Drawing.Point(9, 321);
            this.btn_uadd.Name = "btn_uadd";
            this.btn_uadd.Size = new System.Drawing.Size(75, 23);
            this.btn_uadd.TabIndex = 28;
            this.btn_uadd.Text = "Add/Edit";
            this.btn_uadd.UseVisualStyleBackColor = true;
            this.btn_uadd.Click += new System.EventHandler(this.btn_uadd_Click);
            // 
            // grp_booksop
            // 
            this.grp_booksop.Controls.Add(this.btn_return);
            this.grp_booksop.Controls.Add(this.btn_clear);
            this.grp_booksop.Controls.Add(this.txt_seq);
            this.grp_booksop.Controls.Add(this.label10);
            this.grp_booksop.Controls.Add(this.txt_sub);
            this.grp_booksop.Controls.Add(this.label9);
            this.grp_booksop.Controls.Add(this.txt_isbn);
            this.grp_booksop.Controls.Add(this.label8);
            this.grp_booksop.Controls.Add(this.txt_call);
            this.grp_booksop.Controls.Add(this.label7);
            this.grp_booksop.Controls.Add(this.txt_barcode);
            this.grp_booksop.Controls.Add(this.label6);
            this.grp_booksop.Controls.Add(this.txt_format);
            this.grp_booksop.Controls.Add(this.label5);
            this.grp_booksop.Controls.Add(this.txt_title);
            this.grp_booksop.Controls.Add(this.label4);
            this.grp_booksop.Controls.Add(this.txt_auth);
            this.grp_booksop.Controls.Add(this.label3);
            this.grp_booksop.Controls.Add(this.txt_pub);
            this.grp_booksop.Controls.Add(this.label2);
            this.grp_booksop.Controls.Add(this.txt_pubyear);
            this.grp_booksop.Controls.Add(this.lbl_seq);
            this.grp_booksop.Controls.Add(this.btn_del);
            this.grp_booksop.Controls.Add(this.btn_add);
            this.grp_booksop.Controls.Add(this.dgvbook);
            this.grp_booksop.Location = new System.Drawing.Point(14, 386);
            this.grp_booksop.Name = "grp_booksop";
            this.grp_booksop.Size = new System.Drawing.Size(1324, 305);
            this.grp_booksop.TabIndex = 2;
            this.grp_booksop.TabStop = false;
            this.grp_booksop.Text = "Books option";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(168, 276);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_seq
            // 
            this.txt_seq.Location = new System.Drawing.Point(6, 35);
            this.txt_seq.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_seq.Name = "txt_seq";
            this.txt_seq.Size = new System.Drawing.Size(100, 20);
            this.txt_seq.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Publication Year:";
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(6, 78);
            this.txt_sub.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(100, 20);
            this.txt_sub.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Publisher:";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(6, 120);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(100, 20);
            this.txt_isbn.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Author:";
            // 
            // txt_call
            // 
            this.txt_call.Location = new System.Drawing.Point(6, 165);
            this.txt_call.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_call.Name = "txt_call";
            this.txt_call.Size = new System.Drawing.Size(100, 20);
            this.txt_call.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Title:";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(6, 212);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_barcode.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Format:";
            // 
            // txt_format
            // 
            this.txt_format.Location = new System.Drawing.Point(6, 256);
            this.txt_format.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_format.Name = "txt_format";
            this.txt_format.Size = new System.Drawing.Size(100, 20);
            this.txt_format.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Barcode:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(112, 35);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(221, 20);
            this.txt_title.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Call number:";
            // 
            // txt_auth
            // 
            this.txt_auth.Location = new System.Drawing.Point(112, 78);
            this.txt_auth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.Size = new System.Drawing.Size(221, 20);
            this.txt_auth.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ISBN:";
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(112, 121);
            this.txt_pub.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.Size = new System.Drawing.Size(100, 20);
            this.txt_pub.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject:";
            // 
            // txt_pubyear
            // 
            this.txt_pubyear.Location = new System.Drawing.Point(112, 166);
            this.txt_pubyear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_pubyear.Name = "txt_pubyear";
            this.txt_pubyear.Size = new System.Drawing.Size(100, 20);
            this.txt_pubyear.TabIndex = 7;
            // 
            // lbl_seq
            // 
            this.lbl_seq.AutoSize = true;
            this.lbl_seq.Location = new System.Drawing.Point(6, 16);
            this.lbl_seq.Name = "lbl_seq";
            this.lbl_seq.Size = new System.Drawing.Size(97, 13);
            this.lbl_seq.TabIndex = 6;
            this.lbl_seq.Text = "Sequence number:";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(87, 276);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 276);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add/Edit";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvbook
            // 
            this.dgvbook.AllowUserToAddRows = false;
            this.dgvbook.AllowUserToDeleteRows = false;
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Location = new System.Drawing.Point(339, 9);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.ReadOnly = true;
            this.dgvbook.Size = new System.Drawing.Size(979, 290);
            this.dgvbook.TabIndex = 1;
            this.dgvbook.Click += new System.EventHandler(this.dgvbook_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 705);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "b_renew/Is_admin: 1 = True 0 = False";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 705);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Book Search:";
            // 
            // cbox_overdue
            // 
            this.cbox_overdue.AutoSize = true;
            this.cbox_overdue.Location = new System.Drawing.Point(482, 704);
            this.cbox_overdue.Name = "cbox_overdue";
            this.cbox_overdue.Size = new System.Drawing.Size(123, 17);
            this.cbox_overdue.TabIndex = 28;
            this.cbox_overdue.Text = "View overdue books";
            this.cbox_overdue.UseVisualStyleBackColor = true;
            this.cbox_overdue.CheckedChanged += new System.EventHandler(this.cbox_overdue_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(175, 702);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 20);
            this.txt_search.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_usearch
            // 
            this.btn_usearch.Location = new System.Drawing.Point(381, 367);
            this.btn_usearch.Name = "btn_usearch";
            this.btn_usearch.Size = new System.Drawing.Size(75, 23);
            this.btn_usearch.TabIndex = 31;
            this.btn_usearch.Text = "Search";
            this.btn_usearch.UseVisualStyleBackColor = true;
            this.btn_usearch.Click += new System.EventHandler(this.btn_usearch_Click);
            // 
            // txt_usearch
            // 
            this.txt_usearch.Location = new System.Drawing.Point(175, 369);
            this.txt_usearch.Name = "txt_usearch";
            this.txt_usearch.Size = new System.Drawing.Size(200, 20);
            this.txt_usearch.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "User Search:";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(250, 276);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 28;
            this.btn_return.Text = "Return book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_usearch);
            this.Controls.Add(this.txt_usearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbox_overdue);
            this.Controls.Add(this.grp_booksop);
            this.Controls.Add(this.grp_userop);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.grp_userop.ResumeLayout(false);
            this.grp_userop.PerformLayout();
            this.grp_booksop.ResumeLayout(false);
            this.grp_booksop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.GroupBox grp_userop;
        private System.Windows.Forms.GroupBox grp_booksop;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_call;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_format;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pubyear;
        private System.Windows.Forms.Label lbl_seq;
        private System.Windows.Forms.TextBox txt_seq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbox_overdue;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_uclear;
        private System.Windows.Forms.Button btn_udel;
        private System.Windows.Forms.Button btn_uadd;
        private System.Windows.Forms.Button btn_usearch;
        private System.Windows.Forms.TextBox txt_usearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_u_pass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_u_contact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_u_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_u_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_rName;
        private System.Windows.Forms.Button btn_giveadmin;
        private System.Windows.Forms.Button btn_return;
    }
}