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
    public partial class frm_ChuyenBay : Form
    {
        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from CHUYENBAY";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }

        private void ClearTextBoxes()
        {
            tb_MCB.Text = "";
            tb_TenCB.Text = "";
            tb_LoaiMB.Text = "";
            tb_MPC.Text = "";
            tb_MTB.Text = "";
        }

        public frm_ChuyenBay()
        {
            InitializeComponent();
        }

        private void frm_ChuyenBay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();

        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // insert
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MACB = tb_MCB.Text;
                string TENCB = tb_TenCB.Text;
                string LOAIMB = tb_LoaiMB.Text;
                string MAPC = tb_MPC.Text;
                string MATB = tb_MTB.Text;

                if (string.IsNullOrEmpty(MACB) ||
                    string.IsNullOrEmpty(TENCB) ||
                    string.IsNullOrEmpty(LOAIMB) ||
                    string.IsNullOrEmpty(MAPC) ||
                    string.IsNullOrEmpty(MATB))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("Insert_CB", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MACB", MACB);
                    cmd.Parameters.AddWithValue("@TENCB", TENCB);
                    cmd.Parameters.AddWithValue("@LOAIMB", LOAIMB);
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);
                    cmd.Parameters.AddWithValue("@MATB", MATB);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    ClearTextBoxes();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: Vui lòng xem lại dữ liệu vừa nhập");
            }
        }

        private bool CheckParentKeyExists(string MAPC)
        {
            bool exists = false;
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ParentTable WHERE MAPC = @MAPC", connection);
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    exists = (count > 0);
                }

            return exists;
        }


        // update

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MACB = tb_MCB.Text;
            string TENCB = tb_TenCB.Text;
            string LOAIMB = tb_LoaiMB.Text;
            string MAPC = tb_MPC.Text;
            string MATB = tb_MTB.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if the entered MATB matches the existing record
                    string checkMatbSql = "SELECT MATB FROM CHUYENBAY WHERE MACB = @MACB"; // Replace 'YourTableName' with your actual table name
                    SqlCommand checkMatbCmd = new SqlCommand(checkMatbSql, connection);
                    checkMatbCmd.Parameters.AddWithValue("@MACB", MACB);

                    string existingMatb = (string)checkMatbCmd.ExecuteScalar();

                    if (existingMatb == MATB)
                    {
                        // Update only if MATB matches
                        SqlCommand cmd = new SqlCommand("Update_CB", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MACB", MACB);
                        cmd.Parameters.AddWithValue("@TENCB", TENCB);
                        cmd.Parameters.AddWithValue("@LOAIMB", LOAIMB);
                        cmd.Parameters.AddWithValue("@MAPC", MAPC);
                        cmd.Parameters.AddWithValue("@MATB", MATB);

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
                        MessageBox.Show("Mã tuyến bay (MATB) không đúng. Vui lòng kiểm tra lại.");
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
            string MACB = tb_MCB.Text.Trim();  // Trim to remove leading/trailing spaces

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Check if MACB exists in CHUYENBAY
                    string checkMaCB = "SELECT TOP 1 1 FROM CHUYENBAY WHERE MACB = @MACB";
                    SqlCommand checkMaCbCmd = new SqlCommand(checkMaCB, connection);
                    checkMaCbCmd.Parameters.AddWithValue("@MACB", MACB);

                    // ExecuteScalar to check existence
                    object result = checkMaCbCmd.ExecuteScalar();

                    if (result == null)  // If MACB does not exist
                    {
                        MessageBox.Show("Không tồn tại mã chuyến bay này.");
                    }
                    else
                    {
                        // MACB exists, proceed with deletion
                        SqlCommand cmd = new SqlCommand("Delete_CB", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MACB", MACB);

                        // Execute deletion
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xoá thành công!");
                            LoadData();         // Refresh data after deletion
                            ClearTextBoxes();   // Clear textboxes after successful deletion
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá chuyến bay này.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại");
            }
        }

        // select

        public DataTable SelectCB()
        {
            string MACB = tb_MCB.Text;
            string TENCB = tb_TenCB.Text;
            string LOAIMB = tb_LoaiMB.Text;
            string MAPC = tb_MPC.Text;
            string MATB = tb_MTB.Text;

            DataTable table1 = new DataTable();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("CB_Select", connection);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MACB", string.IsNullOrEmpty(MACB) ? (object)DBNull.Value : MACB);
                    cmd.Parameters.AddWithValue("@TENCB", string.IsNullOrEmpty(TENCB) ? (object)DBNull.Value : TENCB);
                    cmd.Parameters.AddWithValue("@LOAIMB", string.IsNullOrEmpty(LOAIMB) ? (object)DBNull.Value : LOAIMB);
                    cmd.Parameters.AddWithValue("@MAPC", string.IsNullOrEmpty(MAPC) ? (object)DBNull.Value : MAPC);
                    cmd.Parameters.AddWithValue("@MATB", string.IsNullOrEmpty(MATB) ? (object)DBNull.Value : MATB);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table1);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi tìm dữ liệu: " + e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return table1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable result = SelectCB();
            listView.DataSource = result;
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào.");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LoadData();
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
            tb_MCB.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_TenCB.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_LoaiMB.Text = listView.Rows[i].Cells[2].Value.ToString();
            tb_MPC.Text = listView.Rows[i].Cells[3].Value.ToString();
            tb_MTB.Text = listView.Rows[i].Cells[4].Value.ToString();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            frm_Home frm_Home = new frm_Home();
            this.Hide();
            frm_Home.ShowDialog();
            this.Close();
        }
    }
}
