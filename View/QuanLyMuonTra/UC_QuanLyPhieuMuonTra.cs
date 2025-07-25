using LibraryManager.DAO;
using LibraryManager.Models;
using LibraryManager.View.QuanLyMuonTra;
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
        private MainForm _mainForm;
        AppDbContext dbContext = DbContextProvider.Instance;
        public UC_QuanLyPhieuMuonTra(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }


        void LoadData()
        {
            dgvphieumuon.DataSource = dbContext.PhieuMuons.ToList();
            dgvphieumuon.Columns["DocGia"].Visible = false;

        }
        private void PhieuMuonTraUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            _mainForm.ShowUserControl(new UC_MuonSach(_mainForm));
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
            _mainForm.ShowUserControl(new UC_TraSach(_mainForm));
        }
        private void dgvqlpmt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbthongtin.Text = "Thông Tin - Chi Tiết Phiếu Mượn";
            int maPhieuMuon = int.Parse(dgvphieumuon.CurrentRow.Cells["MaPhieuMuon"].Value.ToString());
            dgvchitiet.DataSource = dbContext.ChiTietPhieuMuons
                .Where(ct => ct.MaPhieuMuon == maPhieuMuon)
                .Select(ct => new
                {
                    ct.MaSach,
                    Ten = dbContext.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach).Ten,
                    ct.SoLuongMuon,
                    ct.DaTra
                }).ToList();

            dgvphieutra.DataSource = dbContext.PhieuTras.Where(pt => pt.MaPhieuMuon.Equals(maPhieuMuon)).ToList();

            dgvchitiet.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvchitiet.Columns["Ten"].HeaderText = "Tên Sách";
            dgvchitiet.Columns["SoLuongMuon"].HeaderText = "Số Lượng Mượn";
            dgvchitiet.Columns["DaTra"].HeaderText = "Đã Trả";


            dgvphieutra.Columns["PhieuMuon"].Visible = false;

        }

        private void dgvphieutra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbthongtin.Text = "Thông Tin - Chi Tiết Phiếu Trả";
            int maPhieuTra = int.Parse(dgvphieutra.CurrentRow.Cells["MaPhieuTra"].Value.ToString());
            dgvchitiet.DataSource = dbContext.ChiTietPhieuTras
                .Where(ct => ct.MaPhieuTra == maPhieuTra)
                .Select(ct => new
                {
                    ct.MaSach,
                    Ten = dbContext.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach).Ten,
                    SoLuongTra = dbContext.ChiTietPhieuMuons.FirstOrDefault(ctpm => ctpm.MaSach == ct.MaSach).SoLuongMuon
                }).ToList();
            dgvchitiet.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvchitiet.Columns["Ten"].HeaderText = "Tên Sách";
            dgvchitiet.Columns["SoLuongTra"].HeaderText = "Số Lượng Trả";
        }

        private void dgvphieumuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvphieumuon.Columns[e.ColumnIndex].Name == "MaDocGia" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "DG" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
            if (dgvphieumuon.Columns[e.ColumnIndex].Name == "MaPhieuMuon" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "PM" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvphieutra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvphieutra.Columns[e.ColumnIndex].Name == "MaPhieuMuon" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "PM" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
            if (dgvphieutra.Columns[e.ColumnIndex].Name == "MaPhieuTra" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "PT" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvchitiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvchitiet.Columns[e.ColumnIndex].Name == "MaSach" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "SA" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
