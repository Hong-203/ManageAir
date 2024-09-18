namespace dbQLHK
{
    partial class frm_PageLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PageLogin));
            this.txtNamePage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamePage
            // 
            resources.ApplyResources(this.txtNamePage, "txtNamePage");
            this.txtNamePage.Name = "txtNamePage";
            this.txtNamePage.Click += new System.EventHandler(this.txtNamePage_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_out);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.tb_PW);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_out
            // 
            this.btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_out, "btn_out");
            this.btn_out.ForeColor = System.Drawing.Color.Blue;
            this.btn_out.Name = "btn_out";
            this.btn_out.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.ForeColor = System.Drawing.Color.Blue;
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_PW
            // 
            resources.ApplyResources(this.tb_PW, "tb_PW");
            this.tb_PW.Name = "tb_PW";
            // 
            // tb_user
            // 
            resources.ApplyResources(this.tb_user, "tb_user");
            this.tb_user.Name = "tb_user";
            this.tb_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPW
            // 
            resources.ApplyResources(this.txtPW, "txtPW");
            this.txtPW.BackColor = System.Drawing.SystemColors.Info;
            this.txtPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPW.Name = "txtPW";
            this.txtPW.Click += new System.EventHandler(this.txtPW_Click);
            // 
            // txt_user
            // 
            resources.ApplyResources(this.txt_user, "txt_user");
            this.txt_user.BackColor = System.Drawing.SystemColors.Info;
            this.txt_user.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_user.Name = "txt_user";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.InitialImage = global::dbQLHK.Properties.Resources.bg_LoginPage1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // frm_PageLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNamePage);
            this.Name = "frm_PageLogin";
            this.Load += new System.EventHandler(this.frm_PageLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNamePage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtPW;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.TextBox tb_PW;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
    }
}