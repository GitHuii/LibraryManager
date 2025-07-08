using LibraryManager.DAO;
using LibraryManager.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class UC_QuanLyPhieuMuonTra : UserControl
    {
        public UC_QuanLyPhieuMuonTra()
        {
            InitializeComponent();
        }

        AppDbContext dbContext = DbContextProvider.Instance;

        void LoadData()
        {
            dgvqlpmt.DataSource = dbContext.PhieuMuonTras.ToList();
            dgvqlpmt.Columns["DocGia"].Visible = false;
        }
        private void PhieuMuonTraUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            new AddPhieuMuonTraForm().ShowDialog();
            LoadData();
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
            int maPhieuMuonTra = int.Parse(dgvqlpmt.CurrentRow.Cells["MaPhieuMuonTra"].Value.ToString());
            var phieu = dbContext.PhieuMuonTras
                      .Include(p => p.ChiTietPhieuMuonTras)
                      .FirstOrDefault(p => p.MaPhieuMuonTra == maPhieuMuonTra);
            if (phieu == null)
            {
                // Không tìm thấy phiếu mượn
                throw new Exception("Không tìm thấy phiếu mượn trả.");
            }

            if (phieu.DaTra)
            {
                // Phiếu đã được trả trước đó
                throw new Exception("Phiếu này đã được trả trước đó.");
            }

            phieu.NgayTraThucTe = DateTime.Now;
            phieu.DaTra = true;

            foreach (var chiTiet in phieu.ChiTietPhieuMuonTras)
            {
                int sl = chiTiet.SoLuongMuon;
                var sach = dbContext.Saches.FirstOrDefault(s => s.MaSach == chiTiet.MaSach);
                if (sach != null)
                {
                    sach.SoLuong += sl;
                }
            }

            if (phieu.NgayTraThucTe > phieu.HanTra)
            {
                var phieuPhat = new PhieuPhat
                {
                    MaDocGia = phieu.MaDocGia,
                    NgayLap = DateTime.Now,
                    SoTienPhat = 363636,
                    LyDo = "Trả sách trễ hạn",
                    DaThuTien = false
                };
                dbContext.PhieuPhats.Add(phieuPhat);
            }

            dbContext.SaveChanges();
            LoadData();
        }

        private void dgvqlpmt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maPhieuMuonTra = int.Parse(dgvqlpmt.CurrentRow.Cells["MaPhieuMuonTra"].Value.ToString());
            //var phieu = dbContext.PhieuMuonTras
            //          .Include(p => p.ChiTietPhieuMuonTras)
            //          .FirstOrDefault(p => p.MaPhieuMuonTra == maPhieuMuonTra);
            dgvchitietphieumuontra.DataSource = dbContext.ChiTietPhieuMuonTras
                .Where(ct => ct.MaPhieuMuonTra == maPhieuMuonTra)
                .Select(ct => new
                {
                    ct.MaSach,
                    Ten = dbContext.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach).Ten,
                    ct.SoLuongMuon
                }).ToList();
        }
    }
}
