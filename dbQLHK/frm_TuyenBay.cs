using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace dbQLHK
{
    public partial class dvb : Form
    {

        string str = @"Data Source=DESKTOP-LH60VD8\HAISEVER;Initial Catalog=db_qlhk;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from TUYENBAY";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            listView.DataSource = table;
        }

        public dvb()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MATB = tb_MTB.Text;
                string TENTB = tb_TenTB.Text;
                string NDI = tb_NoiDi.Text;
                string NDEN = tb_NoiDen.Text;
                string DGVeText = tb_DGVe.Text;
                string SoGioBayText = tb_SoGioBay.Text;

                if (string.IsNullOrEmpty(MATB) ||
                    string.IsNullOrEmpty(TENTB) ||
                    string.IsNullOrEmpty(NDI) ||
                    string.IsNullOrEmpty(NDEN))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                int DONGIAVE;
                int SOGIOBAY;

                if (!int.TryParse(DGVeText, out DONGIAVE) || !int.TryParse(SoGioBayText, out SOGIOBAY))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng kiểm tra lại.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("THEM", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATB", MATB);
                    cmd.Parameters.AddWithValue("@TENTB", TENTB);
                    cmd.Parameters.AddWithValue("@NDI", NDI);
                    cmd.Parameters.AddWithValue("@NDEN", NDEN);
                    cmd.Parameters.AddWithValue("@DONGIAVE", DONGIAVE);
                    cmd.Parameters.AddWithValue("@SOGIOBAY", SOGIOBAY);

                    connection.Open();
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
        private void ClearTextBoxes()
        {
            tb_MTB.Text = "";
            tb_TenTB.Text = "";
            tb_NoiDi.Text = "";
            tb_NoiDen.Text = "";
            tb_DGVe.Text = "";
            tb_SoGioBay.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MATB = tb_MTB.Text;
            string TENTB = tb_TenTB.Text;
            string NDI = tb_NoiDi.Text;
            string NDEN = tb_NoiDen.Text;
            int DONGIAVE = int.Parse(tb_DGVe.Text);
            int SOGIOBAY = int.Parse(tb_SoGioBay.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("SUA__TB", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATB", MATB);
                    cmd.Parameters.AddWithValue("@TENTB", TENTB);
                    cmd.Parameters.AddWithValue("@NDI", NDI);
                    cmd.Parameters.AddWithValue("@NDEN", NDEN);
                    cmd.Parameters.AddWithValue("@DONGIAVE", DONGIAVE);
                    cmd.Parameters.AddWithValue("@SOGIOBAY", SOGIOBAY);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    ClearTextBoxes();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MATB = tb_MTB.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("XOA", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATB", MATB);

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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string MATB = tb_MTB.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("TIMKIEM", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATB", MATB);

                    bool foundResult = false;
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["MATB"].ToString() == MATB)
                        {
                            // Hiển thị kết quả phù hợp trên TextBox
                            tb_MTB.Text = row["MATB"].ToString();
                            tb_TenTB.Text = row["TENTB"].ToString();
                            tb_NoiDi.Text = row["NDI"].ToString();
                            tb_NoiDen.Text = row["NDEN"].ToString();
                            tb_DGVe.Text = row["DONGIAVE"].ToString();
                            tb_SoGioBay.Text = row["SOGIOBAY"].ToString();

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
            catch (Exception ex) {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

        }
       
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_HanhKhach form2 = new frm_HanhKhach();
            // Hiển thị Form2 như một dialog
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void ChuyenBay_Click(object sender, EventArgs e)
        {
            frm_ChuyenBay frm_CB = new frm_ChuyenBay();
            this.Hide();
            frm_CB.ShowDialog();
            this.Close();
        }

        private void CTCB_Click(object sender, EventArgs e)
        {
            frm_CTCBay frm_CTCB = new frm_CTCBay();
            this.Hide();
            frm_CTCB.ShowDialog();
            this.Close();
        }

        private void DonViBay_Click(object sender, EventArgs e)
        {
            frm_DViBay frm_DVB = new frm_DViBay();
            this.Hide();
            frm_DVB.ShowDialog();
            this.Close();
        }

        private void PhiCong_Click(object sender, EventArgs e)
        {
            frm_PhiCong frm_PC = new frm_PhiCong();
            this.Hide();
            frm_PC.ShowDialog();
            this.Close();
        }

        private void btn_cb_Click(object sender, EventArgs e)
        {

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
            tb_MTB.Text = listView.Rows[i].Cells[0].Value.ToString();
            tb_TenTB.Text = listView.Rows[i].Cells[1].Value.ToString();
            tb_NoiDi.Text = listView.Rows[i].Cells[2].Value.ToString();
            tb_NoiDen.Text = listView.Rows[i].Cells[3].Value.ToString();
            tb_DGVe.Text = listView.Rows[i].Cells[4].Value.ToString();
            tb_SoGioBay.Text = listView.Rows[i].Cells[5].Value.ToString();
        }
    }
}
