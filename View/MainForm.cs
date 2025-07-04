using Guna.UI2.WinForms;
using LibraryManager.DAO;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl uc)
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
            ShowUserControl(new UC_QuanLyPhieuMuonTra());
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LibraryManagerUI_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
