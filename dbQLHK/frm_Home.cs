using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbQLHK
{
    public partial class frm_Home : Form
    {
        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from HANHKHACH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }

        public frm_Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_PhiCong frm_pc = new frm_PhiCong();
            this.Hide();
            frm_pc.ShowDialog();
            this.Close();
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            frm_PageLogin frm_Out = new frm_PageLogin();
            this.Hide();
            frm_Out.ShowDialog();
            this.Close();
        }

        private void btn_tb_Click(object sender, EventArgs e)
        {
            dvb frm_tb = new dvb();
            this.Hide();
            frm_tb.ShowDialog();
            this.Close();
        }

        private void btn_cb_Click(object sender, EventArgs e)
        {
            frm_ChuyenBay frm_cb = new frm_ChuyenBay();
            this.Hide();
            frm_cb.ShowDialog();
            this.Close();
        }

        private void btn_hk_Click(object sender, EventArgs e)
        {
            frm_HanhKhach frm_hk = new frm_HanhKhach();
            this.Hide();
            frm_hk.ShowDialog();
            this.Close();
        }

        private void btn_ctcb_Click(object sender, EventArgs e)
        {
            frm_CTCBay frm_ctcb = new frm_CTCBay();
            this.Hide();
            frm_ctcb.ShowDialog();
            this.Close();
        }

        private void btn_dvb_Click(object sender, EventArgs e)
        {
            frm_DViBay frm_dvb = new frm_DViBay();
            this.Hide();
            frm_dvb.ShowDialog();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string MAHK = cb_search.Text.Trim();

            if (!string.IsNullOrEmpty(MAHK))
            {
                GetPassengerInfo(MAHK);
            }
            else
            {
                MessageBox.Show("Please enter a valid Passenger ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetPassengerInfo(string passengerID)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetPassengerDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MAHK", passengerID);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        listView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
