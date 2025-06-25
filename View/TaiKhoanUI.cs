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
    }
}
