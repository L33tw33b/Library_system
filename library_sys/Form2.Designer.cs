namespace library_sys
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_lang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_user
            // 
            resources.ApplyResources(this.txt_user, "txt_user");
            this.txt_user.Name = "txt_user";
            // 
            // txt_pass
            // 
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btn_log
            // 
            resources.ApplyResources(this.btn_log, "btn_log");
            this.btn_log.Name = "btn_log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reg
            // 
            resources.ApplyResources(this.btn_reg, "btn_reg");
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_lang
            // 
            resources.ApplyResources(this.btn_lang, "btn_lang");
            this.btn_lang.Name = "btn_lang";
            this.btn_lang.UseVisualStyleBackColor = true;
            this.btn_lang.Click += new System.EventHandler(this.btn_lang_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_lang);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_lang;
    }
}