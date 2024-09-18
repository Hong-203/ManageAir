using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbQLHK
{
    public partial class frm_PhiCong : Form
    {
        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from PHICONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }

        private void ClearTextBoxes()
        {
            tb_MPC.Text = "";
            tb_TPC.Text = "";
            tb_MDVB.Text = "";
            tb_DC.Text = "";
            tb_DT.Text = "";
            tb_QT.Text = "";
            tb_MCB.Text = "";
        }

        public frm_PhiCong()
        {
            InitializeComponent();
        }

        private void frm_PhiCong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // clear
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        // add
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MAPC = tb_MPC.Text;
                string TENPC = tb_TPC.Text;
                string MADVB = tb_MDVB.Text;
                string DC = tb_DC.Text;
                string DT = tb_DT.Text;
                string QT = tb_QT.Text;
                string MACB = tb_MCB.Text;

                if (string.IsNullOrEmpty(MAPC) ||
                    string.IsNullOrEmpty(TENPC) ||
                    string.IsNullOrEmpty(MADVB) ||
                    string.IsNullOrEmpty(DC) ||
                    string.IsNullOrEmpty(DT) ||
                    string.IsNullOrEmpty(QT) ||
                    string.IsNullOrEmpty(MACB))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    SqlCommand checkCBCmd = new SqlCommand("SELECT COUNT(1) FROM PHICONG WHERE MACB = @MACB", connection);
                    SqlCommand checkDVBCmd = new SqlCommand("SELECT COUNT(1) FROM PHICONG WHERE MADVB = @MADVB", connection);
                    checkDVBCmd.Parameters.AddWithValue("@MADVB", MADVB);
                    checkCBCmd.Parameters.AddWithValue("@MACB", MACB);

                    int countCB = (int)checkCBCmd.ExecuteScalar();
                    int countDVB = (int)checkCBCmd.ExecuteScalar();
                    if (countCB == 0 || countDVB == 0)
                    {
                        MessageBox.Show("Mã chuyến bay hoặc Mã đơn vị bay không hợp lệ hoặc không tồn tại trong cơ sở dữ liệu!");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("PHICONG_Insert", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAPC", MAPC);
                    cmd.Parameters.AddWithValue("@TENPC", TENPC);
                    cmd.Parameters.AddWithValue("@MADVB", MADVB);
                    cmd.Parameters.AddWithValue("@DC", DC);
                    cmd.Parameters.AddWithValue("@DT", DT);
                    cmd.Parameters.AddWithValue("@QT", QT);
                    cmd.Parameters.AddWithValue("@MACB", MACB);

                    cmd.ExecuteNonQuery();
                    ClearTextBoxes();
                    LoadData();
                    MessageBox.Show("Thêm dữ liệu thành công");
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
            try
            {
                string MAPC = tb_MPC.Text;
                string TENPC = tb_TPC.Text;
                string MADVB = tb_MDVB.Text;
                string DC = tb_DC.Text;
                string DT = tb_DT.Text;
                string QT = tb_QT.Text;
                string MACB = tb_MCB.Text;

                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Combine the checks into one query
                    string checkSql = "SELECT COUNT(*) FROM PHICONG WHERE MADVB = @MADVB AND MACB = @MACB";
                    SqlCommand checkCmd = new SqlCommand(checkSql, connection);
                    checkCmd.Parameters.AddWithValue("@MADVB", MADVB);
                    checkCmd.Parameters.AddWithValue("@MACB", MACB);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Update record if both MADVB and MACB match
                        SqlCommand cmd = new SqlCommand("[PHICONG_Update]", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MAPC", MAPC);
                        cmd.Parameters.AddWithValue("@TENPC", TENPC);
                        cmd.Parameters.AddWithValue("@MADVB", MADVB);
                        cmd.Parameters.AddWithValue("@DC", DC);
                        cmd.Parameters.AddWithValue("@DT", DT);
                        cmd.Parameters.AddWithValue("@QT", QT);
                        cmd.Parameters.AddWithValue("@MACB", MACB);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData();
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được cập nhật. Vui lòng kiểm tra lại thông tin.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn vị bay (MADVB) hoặc mã cơ bản (MACB) không đúng. Vui lòng kiểm tra lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // delete
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MAPC = tb_MPC.Text;
            string TENPC = tb_TPC.Text;
            string MADVB = tb_MDVB.Text;
            string DC = tb_DC.Text;
            string DT = tb_DT.Text;
            string QT = tb_QT.Text;
            string MACB = tb_MCB.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if MAPC exists in PhiCong table
                    string checkMaPC = "SELECT MAPC FROM PHICONG WHERE MAPC = @MAPC";
                    SqlCommand checkMaPCCmd = new SqlCommand(checkMaPC, connection);
                    checkMaPCCmd.Parameters.AddWithValue("@MAPC", MAPC);
                    object result = checkMaPCCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // MAPC exists, proceed with deletion
                        SqlCommand cmd = new SqlCommand("PHICONG_Delete", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MAPC", MAPC);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            LoadData();
                            ClearTextBoxes();
                            MessageBox.Show("Xoá thành công!");
                        }
                        catch (SqlException ex)
                        {
                            // Handle foreign key constraint violation
                            if (ex.Number == 547) // Foreign key violation error code
                            {
                                MessageBox.Show("Không thể xoá vì mã chuyến bay có liên kết khoá chính/phụ!");
                            }
                            else
                            {
                                MessageBox.Show($"Lỗi SQL: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        // MADVB does not exist
                        MessageBox.Show("Không tồn tại mã chuyến bay");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        // select
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string MAPC = tb_MPC.Text;
            string TENPC = tb_TPC.Text;
            string MADVB = tb_MDVB.Text;
            string DC = tb_DC.Text;
            string DT = tb_DT.Text;
            string QT = tb_QT.Text;
            string MACB = tb_MCB.Text;


            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("PHICONG_Select", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAPC", MAPC);
                    cmd.Parameters.AddWithValue("@TENPC", TENPC);
                    cmd.Parameters.AddWithValue("@MADVB", MADVB);
                    cmd.Parameters.AddWithValue("@MACB", MACB);

                    bool foundResult = false;
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["TENPC"].ToString() == TENPC 
                            || row["MAPC"].ToString() == MAPC 
                            || row["MADVB"].ToString() == MADVB 
                            || row["MACB"].ToString() == MACB)
                        {
                            // Hiển thị kết quả phù hợp trên TextBox
                            tb_MPC.Text = row["MAPC"].ToString();
                            tb_TPC.Text = row["TENPC"].ToString();
                            tb_MDVB.Text = row["MADVB"].ToString();
                            tb_DC.Text = row["DC"].ToString();
                            tb_DT.Text = row["DT"].ToString();
                            tb_QT.Text = row["QT"].ToString();
                            tb_MCB.Text = row["MACB"].ToString();

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

        private void button2_Click(object sender, EventArgs e)
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
            tb_MPC.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_TPC.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_MDVB.Text = listView.Rows[i].Cells[2].Value.ToString();
            tb_DC.Text = listView.Rows[i].Cells[3].Value.ToString();
            tb_DT.Text = listView.Rows[i].Cells[4].Value.ToString();
            tb_QT.Text = listView.Rows[i].Cells[5].Value.ToString();
            tb_MCB.Text = listView.Rows[i].Cells[6].Value.ToString();
        }
    }
}
