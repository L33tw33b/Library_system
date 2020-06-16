namespace library_sys
{
    partial class LangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LangForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chi = new System.Windows.Forms.Button();
            this.btn_eng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_chi
            // 
            resources.ApplyResources(this.btn_chi, "btn_chi");
            this.btn_chi.Name = "btn_chi";
            this.btn_chi.UseVisualStyleBackColor = true;
            this.btn_chi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eng
            // 
            resources.ApplyResources(this.btn_eng, "btn_eng");
            this.btn_eng.Name = "btn_eng";
            this.btn_eng.UseVisualStyleBackColor = true;
            this.btn_eng.Click += new System.EventHandler(this.btn_eng_Click);
            // 
            // LangForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_eng);
            this.Controls.Add(this.btn_chi);
            this.Controls.Add(this.label1);
            this.Name = "LangForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LangForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chi;
        private System.Windows.Forms.Button btn_eng;
    }
}