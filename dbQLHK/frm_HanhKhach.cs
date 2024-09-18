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

namespace dbQLHK
{
    public partial class frm_HanhKhach : Form
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
        public frm_HanhKhach()
        {
            InitializeComponent();
        }

        private void frm_ChuyenBay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void ClearTextBoxes()
        {
            tb_Mhk.Text = "";
            tb_THk.Text = "";
            tb_NS.Text = "";
            tb_GT.Text = "";
            tb_DC.Text = "";
            tb_QT.Text = "";
        }
        // view data
        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        // add
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MAHK = tb_Mhk.Text;
                string TENHK = tb_THk.Text;
                DateTime NS = tb_NS.Value;
                string GT = tb_GT.Text;
                string DC = tb_DC.Text;
                string QT = tb_QT.Text;

                if (string.IsNullOrEmpty(MAHK) ||
                    string.IsNullOrEmpty(TENHK) ||
                    string.IsNullOrEmpty(GT) ||
                    string.IsNullOrEmpty(DC) ||
                    string.IsNullOrEmpty(QT))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("THEM_HK", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAHK", MAHK);
                    cmd.Parameters.AddWithValue("@TENHK", TENHK);
                    cmd.Parameters.AddWithValue("@NS", NS);
                    cmd.Parameters.AddWithValue("@GT", GT);
                    cmd.Parameters.AddWithValue("@DC", DC);
                    cmd.Parameters.AddWithValue("@QT", QT);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    ClearTextBoxes();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        // update
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MAHK = tb_Mhk.Text;
            string TENHK = tb_THk.Text;
            DateTime NS = tb_NS.Value;
            string GT = tb_GT.Text;
            string DC = tb_DC.Text;
            string QT = tb_QT.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("SUA__HK", connection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@MAHK", MAHK);
                    cmd.Parameters.AddWithValue("@TENHK", TENHK);
                    cmd.Parameters.AddWithValue("@NS", NS);
                    cmd.Parameters.AddWithValue("@GT", GT);
                    cmd.Parameters.AddWithValue("@DC", DC);
                    cmd.Parameters.AddWithValue("@QT", QT);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // DELETE
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MAHK = tb_Mhk.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("XOA__HK", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAHK", MAHK);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearTextBoxes();
                    MessageBox.Show("Xoá thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        // Select
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string MAHK = tb_Mhk.Text;
            string TENHK = tb_THk.Text;
            DateTime NS = tb_NS.Value;
            string GT = tb_GT.Text;
            string DC = tb_DC.Text;
            string QT = tb_QT.Text;


            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("TIMKIEM__HK", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAHK", MAHK);

                    bool foundResult = false;
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["MAHK"].ToString() == MAHK)
                        {
                            // Hiển thị kết quả phù hợp trên TextBox
                            tb_Mhk.Text = row["MAHK"].ToString();
                            tb_THk.Text = row["TENHK"].ToString();
                            tb_NS.Text = row["NS"].ToString();
                            tb_GT.Text = row["GT"].ToString();
                            tb_DC.Text = row["DC"].ToString();
                            tb_QT.Text = row["QT"].ToString();

                            foundResult = true;
                            break; // Dừng lặp khi tìm thấy kết quả
                        }
                    }

                    if (!foundResult)
                    {
                        MessageBox.Show("Không tìm thấy kết quả.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // Clear boxxx
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btn_cb_Click(object sender, EventArgs e)
        {
            dvb frm_tb = new dvb();
            this.Hide();
            frm_tb.ShowDialog();
            this.Close();
        }

        private void ChuyenBay_Click(object sender, EventArgs e)
        {
            frm_ChuyenBay frm_cb = new frm_ChuyenBay();
            this.Hide();
            frm_cb.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_HanhKhach frm_hk = new frm_HanhKhach();
            this.Hide();
            frm_hk.ShowDialog();
            this.Close();
        }

        private void PhiCong_Click(object sender, EventArgs e)
        {
            frm_PhiCong frm_pc = new frm_PhiCong();
            this.Hide();
            frm_pc.ShowDialog();
            this.Close();
        }

        private void CTCB_Click(object sender, EventArgs e)
        {
            frm_CTCBay frm_ctcb = new frm_CTCBay();
            this.Hide();
            frm_ctcb.ShowDialog();
            this.Close();
        }

        private void DonViBay_Click(object sender, EventArgs e)
        {
            frm_DViBay frm_dvb = new frm_DViBay();
            this.Hide();
            frm_dvb.ShowDialog();
            this.Close();
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            frm_PageLogin frm_Out = new frm_PageLogin();
            this.Hide();
            frm_Out.ShowDialog();
            this.Close();
        }

        private void listView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = listView.CurrentRow.Index;
            tb_Mhk.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_THk.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_NS.Text = listView.Rows[i].Cells[2].Value.ToString();
            tb_GT.Text = listView.Rows[i].Cells[3].Value.ToString();
            tb_DC.Text = listView.Rows[i].Cells[4].Value.ToString();
            tb_QT.Text = listView.Rows[i].Cells[5].Value.ToString();
        }
    }
}
