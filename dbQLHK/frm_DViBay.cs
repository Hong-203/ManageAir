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
    public partial class frm_DViBay : Form
    {
        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from DONVIBAY";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }

        private void ClearTextBoxes()
        {
            tb_MDVb.Text = "";
            tb_TDVb.Text = "";
            tb_MPc.Text = "";
        }
        public frm_DViBay()
        {
            InitializeComponent();
        }

        private void frm_DViBay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //add
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MADVB = tb_MDVb.Text;
                string TENDVB = tb_TDVb.Text; 
                string MAPC = tb_MPc.Text;

                if (string.IsNullOrEmpty(MADVB) ||
                    string.IsNullOrEmpty(TENDVB) ||
                    string.IsNullOrEmpty(MAPC))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM DONVIBAY WHERE MAPC = @MAPC", connection);
                    checkCmd.Parameters.AddWithValue("@MAPC", MAPC);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("MAPC không hợp lệ hoặc không tồn tại trong cơ sở dữ liệu!");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("DViBay_Insert", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MADVB", MADVB);
                    cmd.Parameters.AddWithValue("@TENDVB", TENDVB);
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);

                    cmd.ExecuteNonQuery();
                    ClearTextBoxes();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        //update
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MADVB = tb_MDVb.Text;
            string TENDVB = tb_TDVb.Text;
            string MAPC = tb_MPc.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if the entered MADVB matches the existing record
                    string checkMadvbSql = "SELECT MADVB FROM DONVIBAY WHERE MADVB = @MADVB"; // Replace 'YourTableName' with your actual table name
                    SqlCommand checkMadvbCmd = new SqlCommand(checkMadvbSql, connection);
                    checkMadvbCmd.Parameters.AddWithValue("@MADVB", MADVB);

                    string existingMaDVB = (string)checkMadvbCmd.ExecuteScalar();

                    if (existingMaDVB == MADVB)
                    {
                        // Update only if MADVB matches
                        SqlCommand cmd = new SqlCommand("DViBay_Update", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MADVB", MADVB);
                        cmd.Parameters.AddWithValue("@TENDVB", TENDVB);
                        cmd.Parameters.AddWithValue("@MAPC", MAPC);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData();
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được cập nhật.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn vị bay (MDVB) không đúng. Vui lòng kiểm tra lại.");
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
            string MADVB = tb_MDVb.Text;
            string TENDVB = tb_TDVb.Text;
            string MAPC = tb_MPc.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if MADVB exists in CTCB table
                    string checkMaDVB = "SELECT MADVB FROM DONVIBAY WHERE MADVB = @MADVB";
                    SqlCommand checkMaDVBCmd = new SqlCommand(checkMaDVB, connection);
                    checkMaDVBCmd.Parameters.AddWithValue("@MADVB", MADVB);
                    object result = checkMaDVBCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // MADVB exists, proceed with deletion
                        SqlCommand cmd = new SqlCommand("DONVIBAY_Delete", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MADVB", MADVB);

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
            string MADVB = tb_MDVb.Text;
            string TENDVB = tb_TDVb.Text;
            string MAPC = tb_MPc.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("DONVIBAY_Select", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MADVB", MADVB);
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);

                    bool foundResult = false;
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["MADVB"].ToString() == MADVB || row["MAPC"].ToString() == MAPC)
                        {
                            // Hiển thị kết quả phù hợp trên TextBox
                            tb_MDVb.Text = row["MADVB"].ToString();
                            tb_TDVb.Text = row["TENDVB"].ToString();
                            tb_MPc.Text = row["MAPC"].ToString();

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
            tb_MDVb.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_TDVb.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_MPc.Text = listView.Rows[i].Cells[2].Value.ToString();
        }
    }
}
