namespace dbQLHK
{
    partial class frm_ChuyenBay
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
            this.tb_MPC = new System.Windows.Forms.TextBox();
            this.tb_LoaiMB = new System.Windows.Forms.TextBox();
            this.tb_TenCB = new System.Windows.Forms.TextBox();
            this.tb_MCB = new System.Windows.Forms.TextBox();
            this.txtMTb = new System.Windows.Forms.Label();
            this.txtMPc = new System.Windows.Forms.Label();
            this.txtLoaiMb = new System.Windows.Forms.Label();
            this.txtTCb = new System.Windows.Forms.Label();
            this.txt_MCb = new System.Windows.Forms.Label();
            this.tb_MTB = new System.Windows.Forms.ComboBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_cb = new System.Windows.Forms.Button();
            this.PhiCong = new System.Windows.Forms.Button();
            this.DonViBay = new System.Windows.Forms.Button();
            this.CTCB = new System.Windows.Forms.Button();
            this.ChuyenBay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.Label();
            this.txt_help = new System.Windows.Forms.Label();
            this.txt_intro = new System.Windows.Forms.Label();
            this.txt_sys = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, -2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 39;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(705, 44);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 38;
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
            this.listView.Location = new System.Drawing.Point(202, 109);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(578, 341);
            this.listView.TabIndex = 37;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellClick);
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(705, 15);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 36;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(612, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(612, 44);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(612, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tb_MPC
            // 
            this.tb_MPC.Location = new System.Drawing.Point(472, 19);
            this.tb_MPC.Name = "tb_MPC";
            this.tb_MPC.Size = new System.Drawing.Size(100, 20);
            this.tb_MPC.TabIndex = 30;
            // 
            // tb_LoaiMB
            // 
            this.tb_LoaiMB.Location = new System.Drawing.Point(284, 73);
            this.tb_LoaiMB.Name = "tb_LoaiMB";
            this.tb_LoaiMB.Size = new System.Drawing.Size(100, 20);
            this.tb_LoaiMB.TabIndex = 29;
            // 
            // tb_TenCB
            // 
            this.tb_TenCB.Location = new System.Drawing.Point(284, 46);
            this.tb_TenCB.Name = "tb_TenCB";
            this.tb_TenCB.Size = new System.Drawing.Size(100, 20);
            this.tb_TenCB.TabIndex = 28;
            // 
            // tb_MCB
            // 
            this.tb_MCB.Location = new System.Drawing.Point(284, 19);
            this.tb_MCB.Name = "tb_MCB";
            this.tb_MCB.Size = new System.Drawing.Size(100, 20);
            this.tb_MCB.TabIndex = 27;
            // 
            // txtMTb
            // 
            this.txtMTb.AutoSize = true;
            this.txtMTb.Location = new System.Drawing.Point(400, 53);
            this.txtMTb.Name = "txtMTb";
            this.txtMTb.Size = new System.Drawing.Size(71, 13);
            this.txtMTb.TabIndex = 25;
            this.txtMTb.Text = "Mã tuyến bay";
            // 
            // txtMPc
            // 
            this.txtMPc.AutoSize = true;
            this.txtMPc.Location = new System.Drawing.Point(400, 22);
            this.txtMPc.Name = "txtMPc";
            this.txtMPc.Size = new System.Drawing.Size(66, 13);
            this.txtMPc.TabIndex = 24;
            this.txtMPc.Text = "Mã phi công";
            // 
            // txtLoaiMb
            // 
            this.txtLoaiMb.AutoSize = true;
            this.txtLoaiMb.Location = new System.Drawing.Point(203, 78);
            this.txtLoaiMb.Name = "txtLoaiMb";
            this.txtLoaiMb.Size = new System.Drawing.Size(69, 13);
            this.txtLoaiMb.TabIndex = 23;
            this.txtLoaiMb.Text = "Loại máy bay";
            // 
            // txtTCb
            // 
            this.txtTCb.AutoSize = true;
            this.txtTCb.Location = new System.Drawing.Point(203, 49);
            this.txtTCb.Name = "txtTCb";
            this.txtTCb.Size = new System.Drawing.Size(84, 13);
            this.txtTCb.TabIndex = 22;
            this.txtTCb.Text = "Tên chuyến bay";
            // 
            // txt_MCb
            // 
            this.txt_MCb.AutoSize = true;
            this.txt_MCb.Location = new System.Drawing.Point(203, 22);
            this.txt_MCb.Name = "txt_MCb";
            this.txt_MCb.Size = new System.Drawing.Size(80, 13);
            this.txt_MCb.TabIndex = 21;
            this.txt_MCb.Text = "Mã chuyến bay";
            // 
            // tb_MTB
            // 
            this.tb_MTB.FormattingEnabled = true;
            this.tb_MTB.Items.AddRange(new object[] {
            "HANtoCAH",
            "HANtoVKG",
            "HANtoPQC",
            "HANtoDAD",
            "HANtoVCA",
            "HANtoHUI",
            "HANtoCXR",
            "HANtoSGN",
            "HANtoVII",
            "HANtoDIN"});
            this.tb_MTB.Location = new System.Drawing.Point(472, 50);
            this.tb_MTB.Name = "tb_MTB";
            this.tb_MTB.Size = new System.Drawing.Size(100, 21);
            this.tb_MTB.TabIndex = 42;
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(89, 456);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(85, 27);
            this.btn_change.TabIndex = 54;
            this.btn_change.Text = "Đổi tài khoản";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_o
            // 
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(13, 456);
            this.btn_o.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(71, 27);
            this.btn_o.TabIndex = 53;
            this.btn_o.Text = "Đăng xuất";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(12, 109);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(160, 52);
            this.btn_cb.TabIndex = 48;
            this.btn_cb.Text = "Tuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // PhiCong
            // 
            this.PhiCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiCong.Location = new System.Drawing.Point(12, 285);
            this.PhiCong.Name = "PhiCong";
            this.PhiCong.Size = new System.Drawing.Size(160, 52);
            this.PhiCong.TabIndex = 47;
            this.PhiCong.Text = "Phi công";
            this.PhiCong.UseVisualStyleBackColor = true;
            this.PhiCong.Click += new System.EventHandler(this.PhiCong_Click);
            // 
            // DonViBay
            // 
            this.DonViBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViBay.Location = new System.Drawing.Point(12, 398);
            this.DonViBay.Name = "DonViBay";
            this.DonViBay.Size = new System.Drawing.Size(160, 52);
            this.DonViBay.TabIndex = 46;
            this.DonViBay.Text = "Đơn vị bay";
            this.DonViBay.UseVisualStyleBackColor = true;
            this.DonViBay.Click += new System.EventHandler(this.DonViBay_Click);
            // 
            // CTCB
            // 
            this.CTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCB.Location = new System.Drawing.Point(10, 341);
            this.CTCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(160, 52);
            this.CTCB.TabIndex = 45;
            this.CTCB.Text = "CTCB";
            this.CTCB.UseVisualStyleBackColor = true;
            this.CTCB.Click += new System.EventHandler(this.CTCB_Click);
            // 
            // ChuyenBay
            // 
            this.ChuyenBay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenBay.Location = new System.Drawing.Point(12, 167);
            this.ChuyenBay.Name = "ChuyenBay";
            this.ChuyenBay.Size = new System.Drawing.Size(160, 52);
            this.ChuyenBay.TabIndex = 44;
            this.ChuyenBay.Text = "Chuyến bay";
            this.ChuyenBay.UseVisualStyleBackColor = false;
            this.ChuyenBay.Click += new System.EventHandler(this.ChuyenBay_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 43;
            this.button1.Text = "Hành khách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.AutoSize = true;
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(92, 54);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(54, 17);
            this.txt_contact.TabIndex = 71;
            this.txt_contact.Text = "Liên hệ";
            // 
            // txt_help
            // 
            this.txt_help.AutoSize = true;
            this.txt_help.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(92, 21);
            this.txt_help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_help.Name = "txt_help";
            this.txt_help.Size = new System.Drawing.Size(59, 17);
            this.txt_help.TabIndex = 70;
            this.txt_help.Text = "Trợ giúp";
            // 
            // txt_intro
            // 
            this.txt_intro.AutoSize = true;
            this.txt_intro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intro.Location = new System.Drawing.Point(14, 54);
            this.txt_intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(70, 17);
            this.txt_intro.TabIndex = 69;
            this.txt_intro.Text = "Giới thiệu";
            // 
            // txt_sys
            // 
            this.txt_sys.AutoSize = true;
            this.txt_sys.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sys.Location = new System.Drawing.Point(14, 21);
            this.txt_sys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sys.Name = "txt_sys";
            this.txt_sys.Size = new System.Drawing.Size(64, 17);
            this.txt_sys.TabIndex = 68;
            this.txt_sys.Text = "Hệ thống";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(15, 17);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 67;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(15, 23);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 13);
            this.linkLabel3.TabIndex = 66;
            // 
            // frm_ChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 495);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_help);
            this.Controls.Add(this.txt_intro);
            this.Controls.Add(this.txt_sys);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_o);
            this.Controls.Add(this.btn_cb);
            this.Controls.Add(this.PhiCong);
            this.Controls.Add(this.DonViBay);
            this.Controls.Add(this.CTCB);
            this.Controls.Add(this.ChuyenBay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_MTB);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tb_MPC);
            this.Controls.Add(this.tb_LoaiMB);
            this.Controls.Add(this.tb_TenCB);
            this.Controls.Add(this.tb_MCB);
            this.Controls.Add(this.txtMTb);
            this.Controls.Add(this.txtMPc);
            this.Controls.Add(this.txtLoaiMb);
            this.Controls.Add(this.txtTCb);
            this.Controls.Add(this.txt_MCb);
            this.Name = "frm_ChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChuyenBay";
            this.Load += new System.EventHandler(this.frm_ChuyenBay_Load);
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
        private System.Windows.Forms.TextBox tb_MPC;
        private System.Windows.Forms.TextBox tb_LoaiMB;
        private System.Windows.Forms.TextBox tb_TenCB;
        private System.Windows.Forms.TextBox tb_MCB;
        private System.Windows.Forms.Label txtMTb;
        private System.Windows.Forms.Label txtMPc;
        private System.Windows.Forms.Label txtLoaiMb;
        private System.Windows.Forms.Label txtTCb;
        private System.Windows.Forms.Label txt_MCb;
        private System.Windows.Forms.ComboBox tb_MTB;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_cb;
        private System.Windows.Forms.Button PhiCong;
        private System.Windows.Forms.Button DonViBay;
        private System.Windows.Forms.Button CTCB;
        private System.Windows.Forms.Button ChuyenBay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_contact;
        private System.Windows.Forms.Label txt_help;
        private System.Windows.Forms.Label txt_intro;
        private System.Windows.Forms.Label txt_sys;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}