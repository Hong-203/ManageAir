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
    public partial class frm_CTCBay : Form
    {
        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from CTCB";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }
        public frm_CTCBay()
        {
            InitializeComponent();
        }

        private void frm_CTCBay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
        private void ClearTextBoxes()
        {
            tb_MCB.Text = "";
            tb_MHk.Text = "";
            tb_Nb.Text = "";
            tb_Gb.Text = "";
        }

        private void listView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        // add
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MACB = tb_MCB.Text;
                string MAHK = tb_MHk.Text;
                DateTime NGAYBAY = tb_Nb.Value;
                DateTime GIOBAY = tb_Gb.Value;

                if (!string.IsNullOrEmpty(MACB) ||
                    !string.IsNullOrEmpty(MAHK))
                {
                    MessageBox.Show("Vui lòng không thay đổi thông tin Mặc định này!");
                    return;
                }
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("CTCB_Insert", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("@MACB", MACB);
                    //cmd.Parameters.AddWithValue("@MAHK", MAHK);
                    cmd.Parameters.AddWithValue("@NGAYBAY", NGAYBAY);
                    cmd.Parameters.AddWithValue("@GIOBAY", GIOBAY);

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

        //upate
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MACB = tb_MCB.Text;
            string MAHK = tb_MHk.Text;
            DateTime NGAYBAY = tb_Nb.Value;
            DateTime GIOBAY = tb_Gb.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if the combination of MACB and MAHK exists in CTCB
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CTCB WHERE MACB = @MACB AND MAHK = @MAHK", connection);
                    checkCmd.Parameters.AddWithValue("@MACB", MACB);
                    checkCmd.Parameters.AddWithValue("@MAHK", MAHK);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("MACB và MAHK không tồn tại trong bảng CTCB!");
                        return;
                    }

                    // If the combination exists, proceed with the update
                    SqlCommand cmd = new SqlCommand("CTCB_Update", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MACB", MACB);
                    cmd.Parameters.AddWithValue("@MAHK", MAHK);
                    cmd.Parameters.AddWithValue("@NGAYBAY", NGAYBAY);
                    cmd.Parameters.AddWithValue("@GIOBAY", GIOBAY);

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


        // select
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string MACB = tb_MCB.Text;
            string MAHK = tb_MHk.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("Select_CB", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MACB", MACB);
                    cmd.Parameters.AddWithValue("@MAHK", MAHK);

                    bool foundResult = false;
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["MACB"].ToString() == MACB || row["MAHK"].ToString() == MAHK)
                        {
                            // Hiển thị kết quả phù hợp trên TextBox
                            tb_MCB.Text = row["MACB"].ToString();
                            tb_MHk.Text = row["MAHK"].ToString();
                            tb_Nb.Text = row["NGAYBAY"].ToString();
                            tb_Gb.Text = row["GIOBAY"].ToString();

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MACB = tb_MCB.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string checkMaCB = "SELECT MATB FROM CTCB WHERE MACB = @MACB";
                    SqlCommand checkMaCbCmd = new SqlCommand(checkMaCB, connection);

                    SqlCommand cmd = new SqlCommand("Delete_CB", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    checkMaCbCmd.Parameters.AddWithValue("@MACB", MACB);
                    string existingMaCB = (string)checkMaCbCmd.ExecuteScalar();

                    if (existingMaCB == MACB)
                    {
                        cmd.Parameters.AddWithValue("@MACB", MACB);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearTextBoxes();
                        MessageBox.Show("Xoá thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Ko tồn tại mã chuyến bay");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không thể xoá Thông tin chuyến bay này vì vẫn còn dữ liệu chuyến bay và hành khách");
            }
        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ChuyenBay frm_cb = new frm_ChuyenBay();
            this.Hide();
            frm_cb.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
            tb_MCB.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_MHk.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_Nb.Text = listView.Rows[i].Cells[2].Value.ToString();
            tb_Gb.Text = listView.Rows[i].Cells[3].Value.ToString();
        }
    }
}
