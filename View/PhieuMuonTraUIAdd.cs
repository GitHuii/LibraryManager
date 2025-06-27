using LibraryManager.DAO;
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

namespace LibraryManager.View
{
    public partial class PhieuMuonTraUIAdd : Form
    {
        public PhieuMuonTraUIAdd()
        {
            InitializeComponent();
        }
        PhieuMuonTraDAO PhieuMuonTraDAO = new PhieuMuonTraDAO();
        AppDbContext dbContext = new AppDbContext();
        private void PhieuMuonTraUIAdd_Load(object sender, EventArgs e)
        {
            txtngaymuon.Text = DateTime.Now.Date.ToString();
            dgvtimkiem.DataSource = dbContext.Saches.ToList();
            dgvtimkiem.Columns["NXB"].Visible = false;
            dgvtimkiem.Columns["TheLoai"].Visible = false;
            dgvtimkiem.Columns["NamXuatBan"].Visible = false;
            dgvtimkiem.Columns["TacGia"].Visible = false;
            dgvtimkiem.Columns["SoLuong"].HeaderText = "Còn Lại";
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = dbContext.Saches.Where(s => s.Ten.ToLower().Contains(txttimkiem.Text.ToLower())).ToList();
            dgvtimkiem.Columns["NXB"].Visible = false;
            dgvtimkiem.Columns["TheLoai"].Visible = false;
            dgvtimkiem.Columns["NamXuatBan"].Visible = false;
            dgvtimkiem.Columns["TacGia"].Visible = false;
            dgvtimkiem.Columns["SoLuong"].HeaderText = "Còn Lại";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int index = dgvtimkiem.CurrentCell.RowIndex;
            string MaSach = dgvtimkiem.Rows[index].Cells["MaSach"].Value.ToString();
            string TenSach = dgvtimkiem.Rows[index].Cells["Ten"].Value.ToString();
            string SoLuong = txtsoluong.Text;
            dgvsach.Rows.Add(MaSach, TenSach, SoLuong);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuMuonTra> chiTietList = new List<ChiTietPhieuMuonTra>();

            foreach (DataGridViewRow row in dgvsach.Rows)
            {
                int maSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                chiTietList.Add(new ChiTietPhieuMuonTra
                {
                    MaSach = maSach,
                    SoLuong = soLuong
                });
            }

            var phieuMoi = new PhieuMuonTra
            {
                MaDocGia = 1,
                NgayMuon = DateTime.Now,
                HanTra = DateTime.Now.AddDays(7),
                DaTra = false,
                ChiTietPhieuMuonTras = chiTietList
            };
            using (var context = new AppDbContext())
            {
                // Lặp qua từng sách mượn
                foreach (var ct in phieuMoi.ChiTietPhieuMuonTras)
                {
                    var sach = context.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach);
                    if (sach == null)
                    {
                        throw new Exception($"Không tìm thấy sách với mã {ct.MaSach}");
                    }

                    if (sach.SoLuong < ct.SoLuong)
                    {
                        throw new Exception($"Không đủ số lượng sách {sach.Ten}. Còn lại: {sach.SoLuong}");
                    }

                    // Trừ số lượng sách
                    sach.SoLuong -= ct.SoLuong;
                }
                // Thêm phiếu mượn
                context.PhieuMuonTras.Add(phieuMoi);
                context.SaveChanges();
            }
            MessageBox.Show("Lưu thành công phiếu mượn trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
