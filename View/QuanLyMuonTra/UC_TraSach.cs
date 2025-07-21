using LibraryManager.DAO;
using LibraryManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.View.QuanLyMuonTra
{
    public partial class UC_TraSach : UserControl
    {
        private MainForm _mainForm;
        AppDbContext dbContext = DbContextProvider.Instance;

        bool isLoaded = false;

        List<object> list = new List<object>();
        public UC_TraSach(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        void Load_dgvchitietphieumuon()
        {
            dgvchitietphieumuon.DataSource = null;
            if (dgvchitietphieumuon.Columns.Contains("btnthem"))
            {
                dgvchitietphieumuon.Columns.Remove("btnthem");
            }
            dgvchitietphieumuon.DataSource = list;
            if(list.Count == 0)
            {
                //MessageBox.Show("Phiếu Mượn Đã Trả Hết Sách !");
                return;
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "btnthem";
            buttonColumn.HeaderText = "Thao tác";
            buttonColumn.Text = "Thêm";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvchitietphieumuon.Columns.Add(buttonColumn);
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            _mainForm.ShowUserControl(new UC_QuanLyPhieuMuonTra(_mainForm));
        }

        private void UC_TraSach_Load(object sender, EventArgs e)
        {
            cbomaphieumuon.DataSource = dbContext.PhieuMuons
                .OrderBy(pm => pm.MaPhieuMuon)
                .Select(pm => new
                {
                    Value = pm.MaPhieuMuon,                    // giá trị xử lý nội bộ
                    Display = "PM" + pm.MaPhieuMuon.ToString("D3")  // hiển thị đẹp
                })
                .ToList();

            cbomaphieumuon.DisplayMember = "Display";
            cbomaphieumuon.ValueMember = "Value";
            isLoaded = true;
            cbomaphieumuon.DropDownHeight = 500;
            cbomaphieumuon_SelectedIndexChanged(sender, e);
            dtpngaytra.Value = DateTime.Now.Date;

            if (!dgvchitietphieutra.Columns.Contains("btnxoa"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "btnxoa";
                buttonColumn.HeaderText = "Thao tác";
                buttonColumn.Text = "Xóa"; // Nội dung nút
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvchitietphieutra.Columns.Add(buttonColumn);
            }

            dgvchitietphieumuon.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvchitietphieumuon.Columns["Ten"].HeaderText = "Tên Sách";
            dgvchitietphieumuon.Columns["SoLuongMuon"].HeaderText = "Số Lượng Mượn";
            dgvchitietphieumuon.Columns["DaTra"].HeaderText = "Đã Trả";
        }

        private void cbomaphieumuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }
            dgvchitietphieutra.Rows.Clear();
            var phieumuon = dbContext.PhieuMuons.Include(pm => pm.DocGia)
                .FirstOrDefault(pm => pm.MaPhieuMuon == int.Parse(cbomaphieumuon.SelectedValue.ToString()));

            txttendocgia.Text = phieumuon.DocGia.Ten;
            dtphantra.Value = phieumuon.HanTra;
            list = dbContext.ChiTietPhieuMuons.Where(ct => ct.MaPhieuMuon == phieumuon.MaPhieuMuon && !ct.DaTra)
                .Select(ct => new
                {
                    ct.MaSach,
                    Ten = dbContext.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach).Ten,
                    ct.SoLuongMuon,
                    ct.DaTra
                })
                .Cast<object>()
                .ToList();
            Load_dgvchitietphieumuon();


        }

        private void dgvchitietphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvchitietphieumuon.Columns[e.ColumnIndex].Name == "btnthem")
            {
                int index = dgvchitietphieumuon.CurrentCell.RowIndex;
                string MaSach = dgvchitietphieumuon.Rows[index].Cells["MaSach"].Value.ToString();
                string TenSach = dgvchitietphieumuon.Rows[index].Cells["Ten"].Value.ToString();
                string SoLuong = dgvchitietphieumuon.Rows[index].Cells["SoLuongMuon"].Value.ToString();
                dgvchitietphieutra.Rows.Add(MaSach, TenSach, SoLuong);
                list.RemoveAt(e.RowIndex);

                Load_dgvchitietphieumuon();
            }
        }

        private void dgvchitietphieutra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvchitietphieutra.Columns[e.ColumnIndex].Name == "btnxoa")
            {
                int maSach = Convert.ToInt32(dgvchitietphieutra.Rows[e.RowIndex].Cells["MaSach"].Value);
                ChiTietPhieuMuon chiTietPhieuMuon = dbContext.ChiTietPhieuMuons.FirstOrDefault(ct => ct.MaSach == maSach && ct.DaTra == false);
                list.Add(new
                {
                    chiTietPhieuMuon.MaSach,
                    Ten = dbContext.Saches.FirstOrDefault(s => s.MaSach == chiTietPhieuMuon.MaSach).Ten,
                    SoLuongMuon = chiTietPhieuMuon.SoLuongMuon,
                    DaTra = chiTietPhieuMuon.DaTra
                });
                Load_dgvchitietphieumuon();
                dgvchitietphieutra.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void btntaophieutrasach_Click(object sender, EventArgs e)
        {
            try
            {
                List<ChiTietPhieuTra> chiTietList = new List<ChiTietPhieuTra>();

                if(dgvchitietphieutra.Rows.Count == 0)
                {
                    //MessageBox.Show("Vui lòng chọn sách để trả.");
                    MessageBoxHelper.ShowWarning("Vui lòng chọn sách để trả.");
                    return;
                }
                foreach (DataGridViewRow row in dgvchitietphieutra.Rows)
                {
                    int maSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                    int soLuongMuon = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    chiTietList.Add(new ChiTietPhieuTra
                    {
                        MaSach = maSach
                    });

                    var sach = dbContext.Saches.FirstOrDefault(s => s.MaSach == maSach);
                    sach.SoLuong += soLuongMuon; // Tăng số lượng sách khi trả

                    var chitietphieumuon = dbContext.ChiTietPhieuMuons.FirstOrDefault(ct => ct.MaSach == maSach && ct.MaPhieuMuon == int.Parse(cbomaphieumuon.SelectedValue.ToString()) && !ct.DaTra);
                    chitietphieumuon.DaTra = true; // Đánh dấu là đã trả sách
                }
                var phieutra = new PhieuTra
                {
                    MaPhieuMuon = int.Parse(cbomaphieumuon.SelectedValue.ToString()),
                    NgayTra = dtpngaytra.Value.Date,
                    ChiTietPhieuTras = chiTietList
                };

                dbContext.PhieuTras.Add(phieutra);
                //MessageBox.Show("Thêm phiếu Trả thành công!");
                MessageBoxHelper.ShowSuccess("Thêm phiếu Trả thành công!");

                var phieumuon = dbContext.PhieuMuons.FirstOrDefault(pm => pm.MaPhieuMuon == phieutra.MaPhieuMuon);
                if (phieutra.NgayTra > phieumuon.HanTra)
                {
                    int soNgayTre = (phieutra.NgayTra - phieumuon.HanTra)?.Days ?? 0;
                    var phieuPhat = new PhieuPhat
                    {
                        MaDocGia = phieumuon.MaDocGia,
                        NgayLap = DateTime.Now,
                        SoTienPhat = soNgayTre * 5000,
                        LyDo = $"Trả sách trễ hạn {soNgayTre} ngày",
                        DaThuTien = false
                    };
                    dbContext.PhieuPhats.Add(phieuPhat);
                    //MessageBox.Show($"Trả sách trễ hạn {soNgayTre} ngày !\nĐã Thêm Phiếu Phạt");
                    MessageBoxHelper.ShowWarning($"Trả sách trễ hạn {soNgayTre} ngày !\nĐã Thêm Phiếu Phạt");
                }


                dbContext.SaveChanges();
                _mainForm.ShowUserControl(new UC_QuanLyPhieuMuonTra(_mainForm));
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi thêm phiếu trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBoxHelper.ShowError("Lỗi khi thêm phiếu trả: " + ex.Message); 
            }
        }
    }
}