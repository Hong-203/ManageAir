namespace dbQLHK
{
    partial class frm_PhiCong
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tb_QT = new System.Windows.Forms.TextBox();
            this.tb_DT = new System.Windows.Forms.TextBox();
            this.tb_DC = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.Label();
            this.txtMDVB = new System.Windows.Forms.Label();
            this.txtTPC = new System.Windows.Forms.Label();
            this.txtMPC = new System.Windows.Forms.Label();
            this.tb_MDVB = new System.Windows.Forms.ComboBox();
            this.tb_MPC = new System.Windows.Forms.ComboBox();
            this.tb_TPC = new System.Windows.Forms.ComboBox();
            this.tb_MCB = new System.Windows.Forms.ComboBox();
            this.txtMCB = new System.Windows.Forms.Label();
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
            this.ChuyenBay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 58;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(724, 38);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 57;
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
            this.listView.Location = new System.Drawing.Point(205, 122);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(743, 341);
            this.listView.TabIndex = 56;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellClick);
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(724, 9);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 55;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(634, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(634, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(634, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tb_QT
            // 
            this.tb_QT.Location = new System.Drawing.Point(453, 67);
            this.tb_QT.Name = "tb_QT";
            this.tb_QT.Size = new System.Drawing.Size(100, 20);
            this.tb_QT.TabIndex = 51;
            // 
            // tb_DT
            // 
            this.tb_DT.Location = new System.Drawing.Point(453, 41);
            this.tb_DT.Name = "tb_DT";
            this.tb_DT.Size = new System.Drawing.Size(100, 20);
            this.tb_DT.TabIndex = 50;
            // 
            // tb_DC
            // 
            this.tb_DC.Location = new System.Drawing.Point(453, 17);
            this.tb_DC.Name = "tb_DC";
            this.tb_DC.Size = new System.Drawing.Size(100, 20);
            this.tb_DC.TabIndex = 49;
            // 
            // txtQT
            // 
            this.txtQT.AutoSize = true;
            this.txtQT.Location = new System.Drawing.Point(400, 72);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(53, 13);
            this.txtQT.TabIndex = 46;
            this.txtQT.Text = "Quốc tịch";
            // 
            // txtDT
            // 
            this.txtDT.AutoSize = true;
            this.txtDT.Location = new System.Drawing.Point(407, 45);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(45, 13);
            this.txtDT.TabIndex = 45;
            this.txtDT.Text = "Dân tộc";
            // 
            // txtDC
            // 
            this.txtDC.AutoSize = true;
            this.txtDC.Location = new System.Drawing.Point(407, 20);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(40, 13);
            this.txtDC.TabIndex = 44;
            this.txtDC.Text = "Địa chỉ";
            // 
            // txtMDVB
            // 
            this.txtMDVB.AutoSize = true;
            this.txtMDVB.Location = new System.Drawing.Point(208, 72);
            this.txtMDVB.Name = "txtMDVB";
            this.txtMDVB.Size = new System.Drawing.Size(75, 13);
            this.txtMDVB.TabIndex = 43;
            this.txtMDVB.Text = "Mã đơn vị bay";
            // 
            // txtTPC
            // 
            this.txtTPC.AutoSize = true;
            this.txtTPC.Location = new System.Drawing.Point(213, 44);
            this.txtTPC.Name = "txtTPC";
            this.txtTPC.Size = new System.Drawing.Size(70, 13);
            this.txtTPC.TabIndex = 42;
            this.txtTPC.Text = "Tên phi công";
            // 
            // txtMPC
            // 
            this.txtMPC.AutoSize = true;
            this.txtMPC.Location = new System.Drawing.Point(217, 15);
            this.txtMPC.Name = "txtMPC";
            this.txtMPC.Size = new System.Drawing.Size(66, 13);
            this.txtMPC.TabIndex = 41;
            this.txtMPC.Text = "Mã phi công";
            // 
            // tb_MDVB
            // 
            this.tb_MDVB.FormattingEnabled = true;
            this.tb_MDVB.Items.AddRange(new object[] {
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
            this.tb_MDVB.Location = new System.Drawing.Point(283, 70);
            this.tb_MDVB.Name = "tb_MDVB";
            this.tb_MDVB.Size = new System.Drawing.Size(100, 21);
            this.tb_MDVB.TabIndex = 60;
            // 
            // tb_MPC
            // 
            this.tb_MPC.FormattingEnabled = true;
            this.tb_MPC.Items.AddRange(new object[] {
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
            this.tb_MPC.Location = new System.Drawing.Point(283, 12);
            this.tb_MPC.Name = "tb_MPC";
            this.tb_MPC.Size = new System.Drawing.Size(100, 21);
            this.tb_MPC.TabIndex = 61;
            // 
            // tb_TPC
            // 
            this.tb_TPC.FormattingEnabled = true;
            this.tb_TPC.Items.AddRange(new object[] {
            "Trần Hoàng Duy",
            "Trần Hồng Hải",
            "Lê Khánh Nam",
            "Phạm Gia Bảo",
            "Vũ Anh Khoa",
            "Đặng Thiên Phúc",
            "Hoàng Anh Tuấn",
            "Bùi Minh Khang",
            "Đỗ Hữu Nghĩa",
            "Phan Nhật Nam"});
            this.tb_TPC.Location = new System.Drawing.Point(283, 42);
            this.tb_TPC.Name = "tb_TPC";
            this.tb_TPC.Size = new System.Drawing.Size(100, 21);
            this.tb_TPC.TabIndex = 62;
            // 
            // tb_MCB
            // 
            this.tb_MCB.FormattingEnabled = true;
            this.tb_MCB.Items.AddRange(new object[] {
            "VN-223",
            "VN-7208",
            "VN-1557",
            "VN-1370",
            "VJ-455",
            "VN-8204",
            "QH-2386",
            "VJ-541",
            "VN-1203",
            "QH-1281"});
            this.tb_MCB.Location = new System.Drawing.Point(283, 96);
            this.tb_MCB.Name = "tb_MCB";
            this.tb_MCB.Size = new System.Drawing.Size(100, 21);
            this.tb_MCB.TabIndex = 64;
            // 
            // txtMCB
            // 
            this.txtMCB.AutoSize = true;
            this.txtMCB.Location = new System.Drawing.Point(203, 98);
            this.txtMCB.Name = "txtMCB";
            this.txtMCB.Size = new System.Drawing.Size(80, 13);
            this.txtMCB.TabIndex = 63;
            this.txtMCB.Text = "Mã chuyến bay";
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(88, 452);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(85, 27);
            this.btn_change.TabIndex = 81;
            this.btn_change.Text = "Đổi tài khoản";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_o
            // 
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(13, 452);
            this.btn_o.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(71, 27);
            this.btn_o.TabIndex = 80;
            this.btn_o.Text = "Đăng xuất";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.AutoSize = true;
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(98, 48);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(54, 17);
            this.txt_contact.TabIndex = 79;
            this.txt_contact.Text = "Liên hệ";
            // 
            // txt_help
            // 
            this.txt_help.AutoSize = true;
            this.txt_help.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(98, 15);
            this.txt_help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_help.Name = "txt_help";
            this.txt_help.Size = new System.Drawing.Size(59, 17);
            this.txt_help.TabIndex = 78;
            this.txt_help.Text = "Trợ giúp";
            // 
            // txt_intro
            // 
            this.txt_intro.AutoSize = true;
            this.txt_intro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intro.Location = new System.Drawing.Point(20, 48);
            this.txt_intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(70, 17);
            this.txt_intro.TabIndex = 77;
            this.txt_intro.Text = "Giới thiệu";
            // 
            // txt_sys
            // 
            this.txt_sys.AutoSize = true;
            this.txt_sys.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sys.Location = new System.Drawing.Point(20, 15);
            this.txt_sys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sys.Name = "txt_sys";
            this.txt_sys.Size = new System.Drawing.Size(64, 17);
            this.txt_sys.TabIndex = 76;
            this.txt_sys.Text = "Hệ thống";
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(11, 105);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(160, 52);
            this.btn_cb.TabIndex = 75;
            this.btn_cb.Text = "Tuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // PhiCong
            // 
            this.PhiCong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PhiCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiCong.Location = new System.Drawing.Point(11, 280);
            this.PhiCong.Name = "PhiCong";
            this.PhiCong.Size = new System.Drawing.Size(160, 52);
            this.PhiCong.TabIndex = 74;
            this.PhiCong.Text = "Phi công";
            this.PhiCong.UseVisualStyleBackColor = false;
            this.PhiCong.Click += new System.EventHandler(this.PhiCong_Click);
            // 
            // DonViBay
            // 
            this.DonViBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViBay.Location = new System.Drawing.Point(11, 394);
            this.DonViBay.Name = "DonViBay";
            this.DonViBay.Size = new System.Drawing.Size(160, 52);
            this.DonViBay.TabIndex = 73;
            this.DonViBay.Text = "Đơn vị bay";
            this.DonViBay.UseVisualStyleBackColor = true;
            this.DonViBay.Click += new System.EventHandler(this.DonViBay_Click);
            // 
            // CTCB
            // 
            this.CTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCB.Location = new System.Drawing.Point(9, 337);
            this.CTCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(160, 52);
            this.CTCB.TabIndex = 72;
            this.CTCB.Text = "CTCB";
            this.CTCB.UseVisualStyleBackColor = true;
            this.CTCB.Click += new System.EventHandler(this.CTCB_Click);
            // 
            // ChuyenBay
            // 
            this.ChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenBay.Location = new System.Drawing.Point(11, 163);
            this.ChuyenBay.Name = "ChuyenBay";
            this.ChuyenBay.Size = new System.Drawing.Size(160, 52);
            this.ChuyenBay.TabIndex = 71;
            this.ChuyenBay.Text = "Chuyến bay";
            this.ChuyenBay.UseVisualStyleBackColor = true;
            this.ChuyenBay.Click += new System.EventHandler(this.ChuyenBay_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 52);
            this.button2.TabIndex = 70;
            this.button2.Text = "Hành khách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(20, 11);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 69;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(20, 16);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 13);
            this.linkLabel3.TabIndex = 68;
            // 
            // frm_PhiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(958, 493);
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
            this.Controls.Add(this.ChuyenBay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.tb_MCB);
            this.Controls.Add(this.txtMCB);
            this.Controls.Add(this.tb_TPC);
            this.Controls.Add(this.tb_MPC);
            this.Controls.Add(this.tb_MDVB);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tb_QT);
            this.Controls.Add(this.tb_DT);
            this.Controls.Add(this.tb_DC);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtMDVB);
            this.Controls.Add(this.txtTPC);
            this.Controls.Add(this.txtMPC);
            this.Name = "frm_PhiCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhiCong";
            this.Load += new System.EventHandler(this.frm_PhiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tb_QT;
        private System.Windows.Forms.TextBox tb_DT;
        private System.Windows.Forms.TextBox tb_DC;
        private System.Windows.Forms.Label txtQT;
        private System.Windows.Forms.Label txtDT;
        private System.Windows.Forms.Label txtDC;
        private System.Windows.Forms.Label txtMDVB;
        private System.Windows.Forms.Label txtTPC;
        private System.Windows.Forms.Label txtMPC;
        private System.Windows.Forms.ComboBox tb_MDVB;
        private System.Windows.Forms.ComboBox tb_MPC;
        private System.Windows.Forms.ComboBox tb_TPC;
        private System.Windows.Forms.ComboBox tb_MCB;
        private System.Windows.Forms.Label txtMCB;
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
        private System.Windows.Forms.Button ChuyenBay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}