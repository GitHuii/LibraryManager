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
    public partial class LibraryManagerUI : Form
    {
        public LibraryManagerUI()
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();           // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;             // Đổ đầy panel
            panelMain.Controls.Add(uc);           // Thêm vào
        }

        private void btnqldg_Click(object sender, EventArgs e)
        {
            ShowUserControl(new DocGiaUI());
        }

        private void btnqltk_Click(object sender, EventArgs e)
        {
            ShowUserControl(new TaiKhoanUI());
        }
    }
}
