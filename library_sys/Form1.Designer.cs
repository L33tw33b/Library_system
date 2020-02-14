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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_bookinfo = new System.Windows.Forms.GroupBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_edit = new System.Windows.Forms.TextBox();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.txt_bookn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grp_booklist = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.grp_booksscan = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.grp_booksava = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_bookinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.grp_booklist.SuspendLayout();
            this.grp_booksscan.SuspendLayout();
            this.grp_booksava.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(367, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lam Tin Church Library System";
            // 
            // grp_bookinfo
            // 
            this.grp_bookinfo.Controls.Add(this.btn_admin);
            this.grp_bookinfo.Controls.Add(this.txt_isbn);
            this.grp_bookinfo.Controls.Add(this.txt_edit);
            this.grp_bookinfo.Controls.Add(this.txt_pub);
            this.grp_bookinfo.Controls.Add(this.txt_auth);
            this.grp_bookinfo.Controls.Add(this.txt_bookn);
            this.grp_bookinfo.Controls.Add(this.label5);
            this.grp_bookinfo.Controls.Add(this.pic_book);
            this.grp_bookinfo.Controls.Add(this.label4);
            this.grp_bookinfo.Controls.Add(this.label3);
            this.grp_bookinfo.Controls.Add(this.label2);
            this.grp_bookinfo.Controls.Add(this.label1);
            this.grp_bookinfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grp_bookinfo.Location = new System.Drawing.Point(0, 51);
            this.grp_bookinfo.Name = "grp_bookinfo";
            this.grp_bookinfo.Size = new System.Drawing.Size(200, 678);
            this.grp_bookinfo.TabIndex = 1;
            this.grp_bookinfo.TabStop = false;
            this.grp_bookinfo.Text = "BookInfo";
            // 
            // btn_admin
            // 
            this.btn_admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_admin.Location = new System.Drawing.Point(3, 652);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(194, 23);
            this.btn_admin.TabIndex = 11;
            this.btn_admin.Text = "Admin Login";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(79, 265);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.ReadOnly = true;
            this.txt_isbn.Size = new System.Drawing.Size(100, 20);
            this.txt_isbn.TabIndex = 10;
            // 
            // txt_edit
            // 
            this.txt_edit.Location = new System.Drawing.Point(78, 202);
            this.txt_edit.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.ReadOnly = true;
            this.txt_edit.Size = new System.Drawing.Size(100, 20);
            this.txt_edit.TabIndex = 9;
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(78, 139);
            this.txt_pub.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.ReadOnly = true;
            this.txt_pub.Size = new System.Drawing.Size(100, 20);
            this.txt_pub.TabIndex = 8;
            // 
            // txt_auth
            // 
            this.txt_auth.Location = new System.Drawing.Point(78, 76);
            this.txt_auth.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.ReadOnly = true;
            this.txt_auth.Size = new System.Drawing.Size(100, 20);
            this.txt_auth.TabIndex = 7;
            // 
            // txt_bookn
            // 
            this.txt_bookn.Location = new System.Drawing.Point(78, 13);
            this.txt_bookn.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txt_bookn.Name = "txt_bookn";
            this.txt_bookn.ReadOnly = true;
            this.txt_bookn.Size = new System.Drawing.Size(100, 20);
            this.txt_bookn.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ISBN-13:";
            // 
            // pic_book
            // 
            this.pic_book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_book.Location = new System.Drawing.Point(26, 328);
            this.pic_book.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(152, 306);
            this.pic_book.TabIndex = 4;
            this.pic_book.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // grp_booklist
            // 
            this.grp_booklist.Controls.Add(this.grp_booksscan);
            this.grp_booklist.Controls.Add(this.grp_booksava);
            this.grp_booklist.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_booklist.Location = new System.Drawing.Point(1150, 51);
            this.grp_booklist.Name = "grp_booklist";
            this.grp_booklist.Size = new System.Drawing.Size(200, 678);
            this.grp_booklist.TabIndex = 2;
            this.grp_booklist.TabStop = false;
            this.grp_booklist.Text = "Book List";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(110, 326);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // grp_booksscan
            // 
            this.grp_booksscan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_booksscan.Controls.Add(this.listBox2);
            this.grp_booksscan.Location = new System.Drawing.Point(3, 369);
            this.grp_booksscan.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.grp_booksscan.Name = "grp_booksscan";
            this.grp_booksscan.Size = new System.Drawing.Size(185, 306);
            this.grp_booksscan.TabIndex = 5;
            this.grp_booksscan.TabStop = false;
            this.grp_booksscan.Text = "Scanned books:";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 277);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // grp_booksava
            // 
            this.grp_booksava.Controls.Add(this.btn_search);
            this.grp_booksava.Controls.Add(this.listBox1);
            this.grp_booksava.Controls.Add(this.textBox6);
            this.grp_booksava.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_booksava.Location = new System.Drawing.Point(3, 16);
            this.grp_booksava.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.grp_booksava.Name = "grp_booksava";
            this.grp_booksava.Size = new System.Drawing.Size(194, 353);
            this.grp_booksava.TabIndex = 4;
            this.grp_booksava.TabStop = false;
            this.grp_booksava.Text = "Available books:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(169, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_return, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_borrow, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(950, 678);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Crimson;
            this.btn_return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_return.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_return.FlatAppearance.BorderSize = 3;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(478, 3);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(469, 672);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Visible = false;
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_borrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_borrow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_borrow.FlatAppearance.BorderSize = 3;
            this.btn_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrow.ForeColor = System.Drawing.Color.White;
            this.btn_borrow.Location = new System.Drawing.Point(3, 3);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(469, 672);
            this.btn_borrow.TabIndex = 0;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = false;
            this.btn_borrow.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.grp_booklist);
            this.Controls.Add(this.grp_bookinfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grp_bookinfo.ResumeLayout(false);
            this.grp_bookinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.grp_booklist.ResumeLayout(false);
            this.grp_booksscan.ResumeLayout(false);
            this.grp_booksava.ResumeLayout(false);
            this.grp_booksava.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grp_bookinfo;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_edit;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.TextBox txt_bookn;
        private System.Windows.Forms.GroupBox grp_booklist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.GroupBox grp_booksava;
        private System.Windows.Forms.GroupBox grp_booksscan;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_admin;
    }
}

