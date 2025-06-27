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
    public partial class TaiKhoanUI : UserControl
    {
        public TaiKhoanUI()
        {
            InitializeComponent();
        }

        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        void LoadData()
        {
            dgvqltk.DataSource = taiKhoanDAO.GetAllTaiKhoans();
        }
        private void TaiKhoanUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvqltk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // TODO: thêm code xử lý ở đây (nếu cần)
        }
    }
}
