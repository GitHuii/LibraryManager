using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.DAO;
using LibraryManager.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.View
{
    public partial class UC_XuLiViPham : UserControl
    {
        AppDbContext dbContext = DbContextProvider.Instance;

        public UC_XuLiViPham()
        {
            InitializeComponent();
        }

        

        private void UC_XuLiViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvPhieuPhat.DataSource = dbContext.PhieuPhats.ToList();
            dgvPhieuPhat.Columns["DocGia"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            var form = new AddXuLyPhieuPhat();
            form.ShowDialog(); // mở dưới dạng form con (modal)
            LoadData(); // tải lại danh sách sau khi thêm
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(txtMaPhieuPhat.Text);
            var phieu = dbContext.PhieuPhats.Find(maPhieu);
            if (phieu != null)
            {
                phieu.MaDocGia = int.Parse(txtMaDocGia.Text);
                phieu.NgayLap = dtpNgayLap.Value;
                phieu.SoTienPhat = decimal.Parse(txtSoTienPhat.Text);
                phieu.LyDo = txtLyDo.Text;
                phieu.DaThuTien = chkDaThuTien.Checked;
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtMaPhieuPhat.Clear();
            txtMaDocGia.Clear();
            txtSoTienPhat.Clear();
            txtLyDo.Clear();
            chkDaThuTien.Checked = false;
            dtpNgayLap.Value = DateTime.Now;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(txtMaPhieuPhat.Text);
            var phieu = dbContext.PhieuPhats.Find(maPhieu);
            if (phieu != null)
            {
                dbContext.PhieuPhats.Remove(phieu);
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text.Trim();

            var result = dbContext.PhieuPhats
                .Where(p => p.MaDocGia.ToString().Contains(tk))
                .ToList();

            dgvPhieuPhat.DataSource = result;

        }

        private void btnHienThi_Click_2(object sender, EventArgs e)
        {
            txtMaPhieuPhat.Clear();
            txtMaDocGia.Clear();
            txtSoTienPhat.Clear();
            txtLyDo.Clear();
            chkDaThuTien.Checked = false;
            dtpNgayLap.Value = DateTime.Now;

            txtTimKiem.Clear();
            LoadData();
        }

        private void dgvPhieuPhat_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.CurrentRow != null && dgvPhieuPhat.CurrentRow.Index >= 0)
            {
                var row = dgvPhieuPhat.CurrentRow;
                txtMaPhieuPhat.Text = row.Cells["MaPhieuPhat"].Value.ToString();
                txtMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                txtSoTienPhat.Text = row.Cells["SoTienPhat"].Value.ToString();
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                chkDaThuTien.Checked = Convert.ToBoolean(row.Cells["DaThuTien"].Value);
            }

        }
    }
}

