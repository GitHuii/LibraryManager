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
    public partial class PhieuMuonTraUI : UserControl
    {
        public PhieuMuonTraUI()
        {
            InitializeComponent();
        }

        PhieuMuonTraDAO phieuMuonTraDAO = new PhieuMuonTraDAO();

        void LoadData()
        {
            dgvqlpmt.DataSource = phieuMuonTraDAO.GetAllPhieuMuonTra();
            dgvqlpmt.Columns["DocGia"].Visible = false;
        }
        private void PhieuMuonTraUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            new PhieuMuonTraUIAdd().Show();
        }
    }
}
