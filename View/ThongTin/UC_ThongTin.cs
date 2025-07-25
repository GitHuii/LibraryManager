using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.View.ThongTin
{
    public partial class UC_ThongTin : UserControl
    {
        MainForm mainForm;
        public UC_ThongTin(MainForm _mainForm , TaiKhoan tk)
        {
            InitializeComponent();
            mainForm = _mainForm;
            lbltk.Text = tk.UserName;
            lblpq.Text = tk.Role;
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxHelper.ShowQuestion("Bạn có chắc chắn muốn đăng xuất không?");

            if (result == DialogResult.Yes)
            {
                mainForm.Close();

                var loginForm = new LoginForm();
                loginForm.ShowDialog();

            }
        }
    }
}
