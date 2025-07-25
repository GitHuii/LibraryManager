using Guna.UI2.WinForms;
using LibraryManager.DAO;
using LibraryManager.Models;
using LibraryManager.View.ThongTin;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.View
{
    public partial class MainForm : Form
    {
        TaiKhoan tk = null;
        public MainForm()
        {
            this.Size = new Size(1500, 800); // Kích thước mặc định của form
            InitializeComponent();
        }
        public MainForm(TaiKhoan _tk)
        {

            this.Size = new Size(1500, 800); // Kích thước mặc định của form
            InitializeComponent();
            tk = _tk; // Lưu thông tin tài khoản đăng nhập
            if (!tk.Role.Equals("Admin"))
            {
                btnqltk.Visible = false;
            }
        }

        public void ShowUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();           // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;             // Đổ đầy panel
            panelMain.Controls.Add(uc);           // Thêm vào
            //guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            //guna2Transition1.MaxAnimationTime = 100;
            //guna2Transition1.TimeStep = 0.01f;
            //guna2Transition1.HideSync(panelMain);

            //panelMain.Controls.Clear();
            //uc.Dock = DockStyle.Fill;
            //panelMain.Controls.Add(uc);

            //// Hiệu ứng hiện panel mới
            //guna2Transition1.ShowSync(panelMain);
        }
        private void btnqldg_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_QuanLyDocGia());
        }

        private void btnqltk_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_QuanLyTaiKhoan());
        }
        private void btnqls_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_QuanLySach());
        }
        private void btnqlpmt_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_QuanLyPhieuMuonTra(this));
        }

        private void LibraryManagerUI_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }


        private void btnxulivipham_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_XuLiViPham());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất không?",
        "Xác nhận đăng xuất",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                var loginForm = new LoginForm();
                loginForm.ShowDialog();

                //Application.Exit();
            }
        }
        private void btnbctk_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_BaoCaoThongKe());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnthongtin_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_ThongTin(this,tk));
        }
    }
}
