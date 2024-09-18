using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbQLHK
{
    public partial class frm_PageLogin : Form
    {
        public frm_PageLogin()
        {
            InitializeComponent();
        }

        private void txtNamePage_Click(object sender, EventArgs e)
        {

        }

        private void frm_PageLogin_Load(object sender, EventArgs e)
        {
            Image backgroundImage = Properties.Resources.bg_LoginPage; // or Image.FromFile("background.jpg");

            pictureBox1.BackgroundImage = backgroundImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            TextBox textBox1 = new TextBox();

            // Set the size of the TextBox
            textBox1.Size = new System.Drawing.Size(200, 30); // Width = 200, Height = 30
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_Click(object sender, EventArgs e)
        {

        }

        private void txtTit_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = tb_user.Text;
            string password = tb_PW.Text;
            if (user == "admin" && password == "admin") {
                frm_Home frm_H = new frm_Home();
                this.Hide();
                frm_H.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Tài khoản mật khẩu sai");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
