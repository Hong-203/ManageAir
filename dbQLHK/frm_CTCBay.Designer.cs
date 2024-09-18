namespace dbQLHK
{
    partial class frm_CTCBay
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
            this.tb_Gb = new System.Windows.Forms.DateTimePicker();
            this.tb_Nb = new System.Windows.Forms.DateTimePicker();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNb = new System.Windows.Forms.Label();
            this.txtMHk = new System.Windows.Forms.Label();
            this.txtMCb = new System.Windows.Forms.Label();
            this.tb_MCB = new System.Windows.Forms.ComboBox();
            this.tb_MHk = new System.Windows.Forms.ComboBox();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Gb
            // 
            this.tb_Gb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tb_Gb.Location = new System.Drawing.Point(460, 50);
            this.tb_Gb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Gb.Name = "tb_Gb";
            this.tb_Gb.Size = new System.Drawing.Size(102, 20);
            this.tb_Gb.TabIndex = 58;
            // 
            // tb_Nb
            // 
            this.tb_Nb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_Nb.Location = new System.Drawing.Point(460, 11);
            this.tb_Nb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Nb.Name = "tb_Nb";
            this.tb_Nb.Size = new System.Drawing.Size(102, 20);
            this.tb_Nb.TabIndex = 57;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(726, 40);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 54;
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
            this.listView.Location = new System.Drawing.Point(207, 105);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(664, 341);
            this.listView.TabIndex = 53;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellClick);
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_CellContentClick_1);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(726, 11);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 52;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(638, 69);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(638, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(638, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số giờ bay";
            // 
            // txtNb
            // 
            this.txtNb.AutoSize = true;
            this.txtNb.Location = new System.Drawing.Point(405, 15);
            this.txtNb.Name = "txtNb";
            this.txtNb.Size = new System.Drawing.Size(52, 13);
            this.txtNb.TabIndex = 45;
            this.txtNb.Text = "Ngày bay";
            // 
            // txtMHk
            // 
            this.txtMHk.AutoSize = true;
            this.txtMHk.Location = new System.Drawing.Point(209, 50);
            this.txtMHk.Name = "txtMHk";
            this.txtMHk.Size = new System.Drawing.Size(82, 13);
            this.txtMHk.TabIndex = 44;
            this.txtMHk.Text = "Mã hành khách";
            // 
            // txtMCb
            // 
            this.txtMCb.AutoSize = true;
            this.txtMCb.Location = new System.Drawing.Point(208, 15);
            this.txtMCb.Name = "txtMCb";
            this.txtMCb.Size = new System.Drawing.Size(80, 13);
            this.txtMCb.TabIndex = 43;
            this.txtMCb.Text = "Mã chuyến bay";
            // 
            // tb_MCB
            // 
            this.tb_MCB.FormattingEnabled = true;
            this.tb_MCB.Items.AddRange(new object[] {
            "QH-1281",
            "QH-2386",
            "VJ-455",
            "VJ-541",
            "VN-1203",
            "VN-1370",
            "VN-1557",
            "VN-223",
            "VN-7208",
            "VN-8204"});
            this.tb_MCB.Location = new System.Drawing.Point(288, 11);
            this.tb_MCB.Name = "tb_MCB";
            this.tb_MCB.Size = new System.Drawing.Size(100, 21);
            this.tb_MCB.TabIndex = 59;
            // 
            // tb_MHk
            // 
            this.tb_MHk.FormattingEnabled = true;
            this.tb_MHk.Items.AddRange(new object[] {
            "H9",
            "H6",
            "H4",
            "H7",
            "H8",
            "H3",
            "H2",
            "H1",
            "H10",
            "H5"});
            this.tb_MHk.Location = new System.Drawing.Point(288, 48);
            this.tb_MHk.Name = "tb_MHk";
            this.tb_MHk.Size = new System.Drawing.Size(100, 21);
            this.tb_MHk.TabIndex = 60;
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(88, 452);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(85, 27);
            this.btn_change.TabIndex = 73;
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
            this.btn_o.TabIndex = 72;
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
            this.txt_contact.TabIndex = 71;
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
            this.txt_help.TabIndex = 70;
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
            this.txt_intro.TabIndex = 69;
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
            this.txt_sys.TabIndex = 68;
            this.txt_sys.Text = "Hệ thống";
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(11, 105);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(160, 52);
            this.btn_cb.TabIndex = 67;
            this.btn_cb.Text = "Tuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // PhiCong
            // 
            this.PhiCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiCong.Location = new System.Drawing.Point(11, 280);
            this.PhiCong.Name = "PhiCong";
            this.PhiCong.Size = new System.Drawing.Size(160, 52);
            this.PhiCong.TabIndex = 66;
            this.PhiCong.Text = "Phi công";
            this.PhiCong.UseVisualStyleBackColor = true;
            this.PhiCong.Click += new System.EventHandler(this.PhiCong_Click);
            // 
            // DonViBay
            // 
            this.DonViBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViBay.Location = new System.Drawing.Point(11, 394);
            this.DonViBay.Name = "DonViBay";
            this.DonViBay.Size = new System.Drawing.Size(160, 52);
            this.DonViBay.TabIndex = 65;
            this.DonViBay.Text = "Đơn vị bay";
            this.DonViBay.UseVisualStyleBackColor = true;
            this.DonViBay.Click += new System.EventHandler(this.DonViBay_Click);
            // 
            // CTCB
            // 
            this.CTCB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCB.Location = new System.Drawing.Point(9, 337);
            this.CTCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(160, 52);
            this.CTCB.TabIndex = 64;
            this.CTCB.Text = "CTCB";
            this.CTCB.UseVisualStyleBackColor = false;
            this.CTCB.Click += new System.EventHandler(this.CTCB_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 52);
            this.button2.TabIndex = 63;
            this.button2.Text = "Chuyến bay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(11, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 52);
            this.button3.TabIndex = 62;
            this.button3.Text = "Hành khách";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 61;
            // 
            // frm_CTCBay
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
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tb_MHk);
            this.Controls.Add(this.tb_MCB);
            this.Controls.Add(this.tb_Gb);
            this.Controls.Add(this.tb_Nb);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNb);
            this.Controls.Add(this.txtMHk);
            this.Controls.Add(this.txtMCb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_CTCBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CTCBay";
            this.Load += new System.EventHandler(this.frm_CTCBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tb_Gb;
        private System.Windows.Forms.DateTimePicker tb_Nb;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtNb;
        private System.Windows.Forms.Label txtMHk;
        private System.Windows.Forms.Label txtMCb;
        private System.Windows.Forms.ComboBox tb_MCB;
        private System.Windows.Forms.ComboBox tb_MHk;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}