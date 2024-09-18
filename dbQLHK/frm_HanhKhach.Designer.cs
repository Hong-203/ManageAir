namespace dbQLHK
{
    partial class frm_HanhKhach
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
            this.tb_DC = new System.Windows.Forms.TextBox();
            this.tb_GT = new System.Windows.Forms.TextBox();
            this.tb_THk = new System.Windows.Forms.TextBox();
            this.tb_Mhk = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.Label();
            this.txtNS = new System.Windows.Forms.Label();
            this.txtTHk = new System.Windows.Forms.Label();
            this.txtMHk = new System.Windows.Forms.Label();
            this.tb_NS = new System.Windows.Forms.DateTimePicker();
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
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
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
            this.linkLabel1.TabIndex = 38;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(725, 38);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 37;
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
            this.listView.Location = new System.Drawing.Point(202, 103);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(664, 341);
            this.listView.TabIndex = 36;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellClick);
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(725, 9);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 35;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(634, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(634, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(634, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tb_QT
            // 
            this.tb_QT.Location = new System.Drawing.Point(462, 72);
            this.tb_QT.Name = "tb_QT";
            this.tb_QT.Size = new System.Drawing.Size(100, 20);
            this.tb_QT.TabIndex = 31;
            // 
            // tb_DC
            // 
            this.tb_DC.Location = new System.Drawing.Point(462, 41);
            this.tb_DC.Name = "tb_DC";
            this.tb_DC.Size = new System.Drawing.Size(100, 20);
            this.tb_DC.TabIndex = 30;
            // 
            // tb_GT
            // 
            this.tb_GT.Location = new System.Drawing.Point(462, 11);
            this.tb_GT.Name = "tb_GT";
            this.tb_GT.Size = new System.Drawing.Size(100, 20);
            this.tb_GT.TabIndex = 29;
            // 
            // tb_THk
            // 
            this.tb_THk.Location = new System.Drawing.Point(291, 41);
            this.tb_THk.Name = "tb_THk";
            this.tb_THk.Size = new System.Drawing.Size(100, 20);
            this.tb_THk.TabIndex = 27;
            // 
            // tb_Mhk
            // 
            this.tb_Mhk.Location = new System.Drawing.Point(291, 14);
            this.tb_Mhk.Name = "tb_Mhk";
            this.tb_Mhk.Size = new System.Drawing.Size(100, 20);
            this.tb_Mhk.TabIndex = 26;
            // 
            // txtQT
            // 
            this.txtQT.AutoSize = true;
            this.txtQT.Location = new System.Drawing.Point(397, 73);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(53, 13);
            this.txtQT.TabIndex = 25;
            this.txtQT.Text = "Quốc tịch";
            // 
            // txtDC
            // 
            this.txtDC.AutoSize = true;
            this.txtDC.Location = new System.Drawing.Point(397, 48);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(40, 13);
            this.txtDC.TabIndex = 24;
            this.txtDC.Text = "Địa chỉ";
            // 
            // txtGT
            // 
            this.txtGT.AutoSize = true;
            this.txtGT.Location = new System.Drawing.Point(397, 17);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(47, 13);
            this.txtGT.TabIndex = 23;
            this.txtGT.Text = "Giới tính";
            // 
            // txtNS
            // 
            this.txtNS.AutoSize = true;
            this.txtNS.Location = new System.Drawing.Point(200, 73);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(54, 13);
            this.txtNS.TabIndex = 22;
            this.txtNS.Text = "Ngày sinh";
            // 
            // txtTHk
            // 
            this.txtTHk.AutoSize = true;
            this.txtTHk.Location = new System.Drawing.Point(200, 48);
            this.txtTHk.Name = "txtTHk";
            this.txtTHk.Size = new System.Drawing.Size(86, 13);
            this.txtTHk.TabIndex = 21;
            this.txtTHk.Text = "Tên hành khách";
            // 
            // txtMHk
            // 
            this.txtMHk.AutoSize = true;
            this.txtMHk.Location = new System.Drawing.Point(200, 17);
            this.txtMHk.Name = "txtMHk";
            this.txtMHk.Size = new System.Drawing.Size(82, 13);
            this.txtMHk.TabIndex = 20;
            this.txtMHk.Text = "Mã hành khách";
            // 
            // tb_NS
            // 
            this.tb_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_NS.Location = new System.Drawing.Point(291, 69);
            this.tb_NS.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.tb_NS.Name = "tb_NS";
            this.tb_NS.Size = new System.Drawing.Size(100, 20);
            this.tb_NS.TabIndex = 40;
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(87, 450);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(85, 27);
            this.btn_change.TabIndex = 67;
            this.btn_change.Text = "Đổi tài khoản";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_o
            // 
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(11, 450);
            this.btn_o.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(71, 27);
            this.btn_o.TabIndex = 66;
            this.btn_o.Text = "Đăng xuất";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.AutoSize = true;
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(96, 46);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(54, 17);
            this.txt_contact.TabIndex = 65;
            this.txt_contact.Text = "Liên hệ";
            // 
            // txt_help
            // 
            this.txt_help.AutoSize = true;
            this.txt_help.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(96, 13);
            this.txt_help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_help.Name = "txt_help";
            this.txt_help.Size = new System.Drawing.Size(59, 17);
            this.txt_help.TabIndex = 64;
            this.txt_help.Text = "Trợ giúp";
            // 
            // txt_intro
            // 
            this.txt_intro.AutoSize = true;
            this.txt_intro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intro.Location = new System.Drawing.Point(18, 46);
            this.txt_intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(70, 17);
            this.txt_intro.TabIndex = 63;
            this.txt_intro.Text = "Giới thiệu";
            // 
            // txt_sys
            // 
            this.txt_sys.AutoSize = true;
            this.txt_sys.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sys.Location = new System.Drawing.Point(18, 13);
            this.txt_sys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sys.Name = "txt_sys";
            this.txt_sys.Size = new System.Drawing.Size(64, 17);
            this.txt_sys.TabIndex = 62;
            this.txt_sys.Text = "Hệ thống";
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(10, 103);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(160, 52);
            this.btn_cb.TabIndex = 61;
            this.btn_cb.Text = "Tuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // PhiCong
            // 
            this.PhiCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiCong.Location = new System.Drawing.Point(10, 279);
            this.PhiCong.Name = "PhiCong";
            this.PhiCong.Size = new System.Drawing.Size(160, 52);
            this.PhiCong.TabIndex = 60;
            this.PhiCong.Text = "Phi công";
            this.PhiCong.UseVisualStyleBackColor = true;
            this.PhiCong.Click += new System.EventHandler(this.PhiCong_Click);
            // 
            // DonViBay
            // 
            this.DonViBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViBay.Location = new System.Drawing.Point(10, 392);
            this.DonViBay.Name = "DonViBay";
            this.DonViBay.Size = new System.Drawing.Size(160, 52);
            this.DonViBay.TabIndex = 59;
            this.DonViBay.Text = "Đơn vị bay";
            this.DonViBay.UseVisualStyleBackColor = true;
            this.DonViBay.Click += new System.EventHandler(this.DonViBay_Click);
            // 
            // CTCB
            // 
            this.CTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCB.Location = new System.Drawing.Point(8, 336);
            this.CTCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(160, 52);
            this.CTCB.TabIndex = 58;
            this.CTCB.Text = "CTCB";
            this.CTCB.UseVisualStyleBackColor = true;
            this.CTCB.Click += new System.EventHandler(this.CTCB_Click);
            // 
            // ChuyenBay
            // 
            this.ChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenBay.Location = new System.Drawing.Point(10, 162);
            this.ChuyenBay.Name = "ChuyenBay";
            this.ChuyenBay.Size = new System.Drawing.Size(160, 52);
            this.ChuyenBay.TabIndex = 57;
            this.ChuyenBay.Text = "Chuyến bay";
            this.ChuyenBay.UseVisualStyleBackColor = true;
            this.ChuyenBay.Click += new System.EventHandler(this.ChuyenBay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 56;
            this.button1.Text = "Hành khách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(19, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 55;
            // 
            // frm_HanhKhach
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
            this.Controls.Add(this.ChuyenBay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.tb_NS);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tb_QT);
            this.Controls.Add(this.tb_DC);
            this.Controls.Add(this.tb_GT);
            this.Controls.Add(this.tb_THk);
            this.Controls.Add(this.tb_Mhk);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.txtTHk);
            this.Controls.Add(this.txtMHk);
            this.Name = "frm_HanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HanhKhach";
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
        private System.Windows.Forms.TextBox tb_QT;
        private System.Windows.Forms.TextBox tb_DC;
        private System.Windows.Forms.TextBox tb_GT;
        private System.Windows.Forms.TextBox tb_THk;
        private System.Windows.Forms.TextBox tb_Mhk;
        private System.Windows.Forms.Label txtQT;
        private System.Windows.Forms.Label txtDC;
        private System.Windows.Forms.Label txtGT;
        private System.Windows.Forms.Label txtNS;
        private System.Windows.Forms.Label txtTHk;
        private System.Windows.Forms.Label txtMHk;
        private System.Windows.Forms.DateTimePicker tb_NS;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}