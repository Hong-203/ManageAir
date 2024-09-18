namespace dbQLHK
{
    partial class frm_DViBay
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
            this.tb_MPc = new System.Windows.Forms.ComboBox();
            this.tb_TDVb = new System.Windows.Forms.ComboBox();
            this.tb_MDVb = new System.Windows.Forms.ComboBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMPc = new System.Windows.Forms.Label();
            this.txtTDVB = new System.Windows.Forms.Label();
            this.txtMDVB = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_o = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.Label();
            this.txt_help = new System.Windows.Forms.Label();
            this.txt_intro = new System.Windows.Forms.Label();
            this.txt_sys = new System.Windows.Forms.Label();
            this.btn_cb = new System.Windows.Forms.Button();
            this.PhiCong = new System.Windows.Forms.Button();
            this.DonViBay = new System.Windows.Forms.Button();
            this.CTCB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MPc
            // 
            this.tb_MPc.FormattingEnabled = true;
            this.tb_MPc.Items.AddRange(new object[] {
            "PC1",
            "PC10",
            "PC2",
            "PC3",
            "PC4",
            "PC5",
            "PC6",
            "PC7",
            "PC8",
            "PC9"});
            this.tb_MPc.Location = new System.Drawing.Point(286, 76);
            this.tb_MPc.Name = "tb_MPc";
            this.tb_MPc.Size = new System.Drawing.Size(100, 21);
            this.tb_MPc.TabIndex = 91;
            // 
            // tb_TDVb
            // 
            this.tb_TDVb.FormattingEnabled = true;
            this.tb_TDVb.Items.AddRange(new object[] {
            "Emirates Airlines",
            "Vietnam Airline",
            "Jetstar Pacific",
            "Vietravel Airlines",
            "VASCO",
            "Air China ",
            "Asiana Airlines",
            "Vietjet Air",
            "Japan Airlines",
            "Bamboo Airways"});
            this.tb_TDVb.Location = new System.Drawing.Point(286, 47);
            this.tb_TDVb.Name = "tb_TDVb";
            this.tb_TDVb.Size = new System.Drawing.Size(100, 21);
            this.tb_TDVb.TabIndex = 90;
            // 
            // tb_MDVb
            // 
            this.tb_MDVb.FormattingEnabled = true;
            this.tb_MDVb.Items.AddRange(new object[] {
            "DV1",
            "DV10",
            "DV2",
            "DV3",
            "DV4",
            "DV5",
            "DV6",
            "DV7",
            "DV8",
            "DV9"});
            this.tb_MDVb.Location = new System.Drawing.Point(286, 20);
            this.tb_MDVb.Name = "tb_MDVb";
            this.tb_MDVb.Size = new System.Drawing.Size(100, 21);
            this.tb_MDVb.TabIndex = 89;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(718, 44);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 86;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.AllowUserToOrderColumns = true;
            this.listView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(202, 105);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(664, 341);
            this.listView.TabIndex = 85;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellClick);
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(718, 15);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 84;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(628, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 83;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(628, 44);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 82;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(628, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMPc
            // 
            this.txtMPc.AutoSize = true;
            this.txtMPc.Location = new System.Drawing.Point(218, 78);
            this.txtMPc.Name = "txtMPc";
            this.txtMPc.Size = new System.Drawing.Size(66, 13);
            this.txtMPc.TabIndex = 80;
            this.txtMPc.Text = "Mã phi công";
            // 
            // txtTDVB
            // 
            this.txtTDVB.AutoSize = true;
            this.txtTDVB.Location = new System.Drawing.Point(206, 50);
            this.txtTDVB.Name = "txtTDVB";
            this.txtTDVB.Size = new System.Drawing.Size(79, 13);
            this.txtTDVB.TabIndex = 79;
            this.txtTDVB.Text = "Tên đơn vị bay";
            // 
            // txtMDVB
            // 
            this.txtMDVB.AutoSize = true;
            this.txtMDVB.Location = new System.Drawing.Point(209, 23);
            this.txtMDVB.Name = "txtMDVB";
            this.txtMDVB.Size = new System.Drawing.Size(75, 13);
            this.txtMDVB.TabIndex = 78;
            this.txtMDVB.Text = "Mã đơn vị bay";
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(87, 452);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(85, 27);
            this.btn_change.TabIndex = 103;
            this.btn_change.Text = "Đổi tài khoản";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_o
            // 
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(11, 452);
            this.btn_o.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(71, 27);
            this.btn_o.TabIndex = 102;
            this.btn_o.Text = "Đăng xuất";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.AutoSize = true;
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(96, 48);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(54, 17);
            this.txt_contact.TabIndex = 101;
            this.txt_contact.Text = "Liên hệ";
            // 
            // txt_help
            // 
            this.txt_help.AutoSize = true;
            this.txt_help.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(96, 15);
            this.txt_help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_help.Name = "txt_help";
            this.txt_help.Size = new System.Drawing.Size(59, 17);
            this.txt_help.TabIndex = 100;
            this.txt_help.Text = "Trợ giúp";
            // 
            // txt_intro
            // 
            this.txt_intro.AutoSize = true;
            this.txt_intro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intro.Location = new System.Drawing.Point(18, 48);
            this.txt_intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(70, 17);
            this.txt_intro.TabIndex = 99;
            this.txt_intro.Text = "Giới thiệu";
            // 
            // txt_sys
            // 
            this.txt_sys.AutoSize = true;
            this.txt_sys.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sys.Location = new System.Drawing.Point(18, 15);
            this.txt_sys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sys.Name = "txt_sys";
            this.txt_sys.Size = new System.Drawing.Size(64, 17);
            this.txt_sys.TabIndex = 98;
            this.txt_sys.Text = "Hệ thống";
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(10, 105);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(160, 52);
            this.btn_cb.TabIndex = 97;
            this.btn_cb.Text = "Tuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // PhiCong
            // 
            this.PhiCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiCong.Location = new System.Drawing.Point(10, 280);
            this.PhiCong.Name = "PhiCong";
            this.PhiCong.Size = new System.Drawing.Size(160, 52);
            this.PhiCong.TabIndex = 96;
            this.PhiCong.Text = "Phi công";
            this.PhiCong.UseVisualStyleBackColor = true;
            this.PhiCong.Click += new System.EventHandler(this.PhiCong_Click);
            // 
            // DonViBay
            // 
            this.DonViBay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DonViBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViBay.Location = new System.Drawing.Point(10, 394);
            this.DonViBay.Name = "DonViBay";
            this.DonViBay.Size = new System.Drawing.Size(160, 52);
            this.DonViBay.TabIndex = 95;
            this.DonViBay.Text = "Đơn vị bay";
            this.DonViBay.UseVisualStyleBackColor = false;
            this.DonViBay.Click += new System.EventHandler(this.DonViBay_Click);
            // 
            // CTCB
            // 
            this.CTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCB.Location = new System.Drawing.Point(8, 337);
            this.CTCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(160, 52);
            this.CTCB.TabIndex = 94;
            this.CTCB.Text = "CTCB";
            this.CTCB.UseVisualStyleBackColor = true;
            this.CTCB.Click += new System.EventHandler(this.CTCB_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 52);
            this.button2.TabIndex = 93;
            this.button2.Text = "Chuyến bay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 52);
            this.button3.TabIndex = 92;
            this.button3.Text = "Hành khách";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_DViBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(898, 493);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_o);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_help);
            this.Controls.Add(this.txt_intro);
            this.Controls.Add(this.txt_sys);
            this.Controls.Add(this.btn_cb);
            this.Controls.Add(this.PhiCong);
            this.Controls.Add(this.DonViBay);
            this.Controls.Add(this.CTCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_MPc);
            this.Controls.Add(this.tb_TDVb);
            this.Controls.Add(this.tb_MDVb);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMPc);
            this.Controls.Add(this.txtTDVB);
            this.Controls.Add(this.txtMDVB);
            this.Name = "frm_DViBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DViBay";
            this.Load += new System.EventHandler(this.frm_DViBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tb_MPc;
        private System.Windows.Forms.ComboBox tb_TDVb;
        private System.Windows.Forms.ComboBox tb_MDVb;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtMPc;
        private System.Windows.Forms.Label txtTDVB;
        private System.Windows.Forms.Label txtMDVB;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Label txt_contact;
        private System.Windows.Forms.Label txt_help;
        private System.Windows.Forms.Label txt_intro;
        private System.Windows.Forms.Label txt_sys;
        private System.Windows.Forms.Button btn_cb;
        private System.Windows.Forms.Button PhiCong;
        private System.Windows.Forms.Button DonViBay;
        private System.Windows.Forms.Button CTCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}