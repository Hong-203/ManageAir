namespace dbQLHK
{
    partial class frm_Home
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_tb = new System.Windows.Forms.Button();
            this.btn_cb = new System.Windows.Forms.Button();
            this.btn_hk = new System.Windows.Forms.Button();
            this.btn_pc = new System.Windows.Forms.Button();
            this.btn_dvb = new System.Windows.Forms.Button();
            this.btn_ctcb = new System.Windows.Forms.Button();
            this.tb_Group = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_tb
            // 
            this.btn_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tb.Location = new System.Drawing.Point(3, 143);
            this.btn_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tb.Name = "btn_tb";
            this.btn_tb.Size = new System.Drawing.Size(213, 64);
            this.btn_tb.TabIndex = 2;
            this.btn_tb.Text = "Tuyến bay";
            this.btn_tb.UseVisualStyleBackColor = true;
            this.btn_tb.Click += new System.EventHandler(this.btn_tb_Click);
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cb.Location = new System.Drawing.Point(3, 213);
            this.btn_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(213, 64);
            this.btn_cb.TabIndex = 3;
            this.btn_cb.Text = "Chuyến bay";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // btn_hk
            // 
            this.btn_hk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hk.Location = new System.Drawing.Point(3, 284);
            this.btn_hk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hk.Name = "btn_hk";
            this.btn_hk.Size = new System.Drawing.Size(213, 64);
            this.btn_hk.TabIndex = 4;
            this.btn_hk.Text = "Hành khách";
            this.btn_hk.UseVisualStyleBackColor = true;
            this.btn_hk.Click += new System.EventHandler(this.btn_hk_Click);
            // 
            // btn_pc
            // 
            this.btn_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pc.Location = new System.Drawing.Point(3, 353);
            this.btn_pc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pc.Name = "btn_pc";
            this.btn_pc.Size = new System.Drawing.Size(213, 64);
            this.btn_pc.TabIndex = 5;
            this.btn_pc.Text = "Phi công";
            this.btn_pc.UseVisualStyleBackColor = true;
            this.btn_pc.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_dvb
            // 
            this.btn_dvb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dvb.Location = new System.Drawing.Point(3, 493);
            this.btn_dvb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dvb.Name = "btn_dvb";
            this.btn_dvb.Size = new System.Drawing.Size(213, 64);
            this.btn_dvb.TabIndex = 6;
            this.btn_dvb.Text = "Đơn vị bay";
            this.btn_dvb.UseVisualStyleBackColor = true;
            this.btn_dvb.Click += new System.EventHandler(this.btn_dvb_Click);
            // 
            // btn_ctcb
            // 
            this.btn_ctcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ctcb.Location = new System.Drawing.Point(3, 423);
            this.btn_ctcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ctcb.Name = "btn_ctcb";
            this.btn_ctcb.Size = new System.Drawing.Size(213, 64);
            this.btn_ctcb.TabIndex = 7;
            this.btn_ctcb.Text = "Chi tiết chuyến bay";
            this.btn_ctcb.UseVisualStyleBackColor = true;
            this.btn_ctcb.Click += new System.EventHandler(this.btn_ctcb_Click);
            // 
            // tb_Group
            // 
            this.tb_Group.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tb_Group.BackColor = System.Drawing.Color.DodgerBlue;
            this.tb_Group.Controls.Add(this.label4);
            this.tb_Group.Controls.Add(this.label1);
            this.tb_Group.Controls.Add(this.listView);
            this.tb_Group.Controls.Add(this.btn_search);
            this.tb_Group.Controls.Add(this.cb_search);
            this.tb_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Group.ForeColor = System.Drawing.Color.Red;
            this.tb_Group.Location = new System.Drawing.Point(243, 163);
            this.tb_Group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Group.Size = new System.Drawing.Size(927, 394);
            this.tb_Group.TabIndex = 11;
            this.tb_Group.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(233, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quản lý hàng không";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tìm kiếm theo mã khách hàng";
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.AllowUserToOrderColumns = true;
            this.listView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView.Location = new System.Drawing.Point(5, 180);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.ReadOnly = true;
            this.listView.RowHeadersWidth = 51;
            this.listView.Size = new System.Drawing.Size(917, 209);
            this.listView.TabIndex = 38;
            this.listView.UseWaitCursor = true;
            this.listView.VirtualMode = true;
            // 
            // btn_search
            // 
            this.btn_search.AccessibleName = "";
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(316, 138);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_search
            // 
            this.cb_search.AccessibleName = "";
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(5, 138);
            this.cb_search.Margin = new System.Windows.Forms.Padding(4);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(303, 26);
            this.cb_search.TabIndex = 1;
            // 
            // btn_o
            // 
            this.btn_o.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(3, 574);
            this.btn_o.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(95, 33);
            this.btn_o.TabIndex = 13;
            this.btn_o.Text = "Đăng xuất";
            this.btn_o.UseVisualStyleBackColor = false;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(104, 574);
            this.btn_change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(112, 33);
            this.btn_change.TabIndex = 14;
            this.btn_change.Text = "Đổi tài khoản";
            this.btn_change.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 17;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::dbQLHK.Properties.Resources.TRONGDONG;
            this.button1.Font = new System.Drawing.Font("Trajan Pro", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-27, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1268, 137);
            this.button1.TabIndex = 18;
            this.button1.Text = "NoiBai International Airport";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1196, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_o);
            this.Controls.Add(this.btn_ctcb);
            this.Controls.Add(this.btn_dvb);
            this.Controls.Add(this.btn_pc);
            this.Controls.Add(this.btn_hk);
            this.Controls.Add(this.btn_cb);
            this.Controls.Add(this.btn_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.tb_Group.ResumeLayout(false);
            this.tb_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_tb;
        private System.Windows.Forms.Button btn_cb;
        private System.Windows.Forms.Button btn_hk;
        private System.Windows.Forms.Button btn_pc;
        private System.Windows.Forms.Button btn_dvb;
        private System.Windows.Forms.Button btn_ctcb;
        private System.Windows.Forms.GroupBox tb_Group;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}