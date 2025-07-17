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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManager.View.QuanLyMuonTra
{
    public partial class UC_MuonSach : UserControl
    {

        private MainForm _mainForm;
        AppDbContext dbContext = DbContextProvider.Instance;

        bool isLoaded = false;

        public UC_MuonSach(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        void Load_dgvtimkiem()
        {
            var sachList = dbContext.Saches.
                Select(s => new Sach
                {
                    MaSach = s.MaSach,
                    Ten = s.Ten,
                    SoLuong = s.SoLuong,
                    NamXuatBan = s.NamXuatBan,
                    NXB = s.NXB,
                    TheLoai = s.TheLoai,
                    TacGia = s.TacGia
                    // các trường khác nếu cần
                }).ToList();
            dgvtimkiem.DataSource = sachList;
        }
        private void UC_MuonSach_Load(object sender, EventArgs e)
        {
            dtpngaymuon.Value = DateTime.Now.Date;
            //cbomadocgia.Items.AddRange(dbContext.DocGias.Select(dg => (object)dg.MaDocGia).ToArray());
            cbomadocgia.DataSource = dbContext.DocGias
                .Select(dg => new
                {
                    Value = dg.MaDocGia,
                    Display = "DG" + dg.MaDocGia.ToString("D3")
                })
                .ToList();

            cbomadocgia.DisplayMember = "Display";
            cbomadocgia.ValueMember = "Value";
            isLoaded = true;
            cbomadocgia.DropDownHeight = 500;
            cbomadocgia_SelectedIndexChanged(sender, e);
            Load_dgvtimkiem();

            if (!dgvsach.Columns.Contains("btnxoa"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "btnxoa";
                buttonColumn.HeaderText = "Thao tác";
                buttonColumn.Text = "Xóa"; // Nội dung nút
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvsach.Columns.Add(buttonColumn);
            }

        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = dbContext.Saches.Where(s => s.Ten.ToLower().Contains(txttimkiem.Text.ToLower())).ToList();
        }


        private void cbomadocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }
            string tmp = cbomadocgia.SelectedValue.ToString();
            DocGia docGia = dbContext.DocGias.FirstOrDefault(dg => dg.MaDocGia == int.Parse(cbomadocgia.SelectedValue.ToString()));
            txtTen.Text = docGia?.Ten ?? string.Empty;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dgvtimkiem.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách để mượn.");
                return;
            }
            int index = dgvtimkiem.CurrentCell.RowIndex;
            string MaSach = dgvtimkiem.Rows[index].Cells["MaSach"].Value.ToString();
            string TenSach = dgvtimkiem.Rows[index].Cells["Ten"].Value.ToString();
            string SoLuong = txtsoluong.Text;
            dgvsach.Rows.Add(MaSach, TenSach, SoLuong);
            dgvtimkiem.Rows[index].Cells["SoLuong"].Value = Convert.ToInt32(dgvtimkiem.Rows[index].Cells["SoLuong"].Value) - Convert.ToInt32(SoLuong);
        }

        private void btntaophieumuon_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuMuon> chiTietList = new List<ChiTietPhieuMuon>();

            foreach (DataGridViewRow row in dgvsach.Rows)
            {
                int maSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                chiTietList.Add(new ChiTietPhieuMuon
                {
                    MaSach = maSach,
                    SoLuongMuon = soLuong
                });
            }

            var phieuMoi = new PhieuMuon
            {
                MaDocGia = int.Parse(cbomadocgia.SelectedValue.ToString()),
                NgayMuon = DateTime.Now,
                HanTra = dtphantra.Value.Date,
                ChiTietPhieuMuons = chiTietList
            };
            // Lặp qua từng sách mượn
            foreach (var ct in phieuMoi.ChiTietPhieuMuons)
            {
                var sach = dbContext.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach);
                if (sach == null)
                {
                    throw new Exception($"Không tìm thấy sách với mã {ct.MaSach}");
                }

                if (sach.SoLuong < ct.SoLuongMuon)
                {
                    throw new Exception($"Không đủ số lượng sách {sach.Ten}. Còn lại: {sach.SoLuong}");
                }

                // Trừ số lượng sách
                sach.SoLuong -= ct.SoLuongMuon;
            }
            // Thêm phiếu mượn
            dbContext.PhieuMuons.Add(phieuMoi);
            dbContext.SaveChanges();
            MessageBox.Show("Thêm phiếu mượn thành công!");
            _mainForm.ShowUserControl(new UC_QuanLyPhieuMuonTra(_mainForm));

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            _mainForm.ShowUserControl(new UC_QuanLyPhieuMuonTra(_mainForm));
        }

        private void dgvsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvsach.Columns[e.ColumnIndex].Name == "btnxoa")
            {
                // Xác nhận trước khi xóa
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int maSach = Convert.ToInt32(dgvsach.Rows[e.RowIndex].Cells["MaSach"].Value);
                    int soLuongMuon = Convert.ToInt32(dgvsach.Rows[e.RowIndex].Cells["SoLuong"].Value);
                    foreach (DataGridViewRow row in dgvtimkiem.Rows)
                    {
                        if (row.Cells["MaSach"].Value != null && Convert.ToInt32(row.Cells["MaSach"].Value) == maSach)
                        {
                            row.Cells["SoLuong"].Value = Convert.ToInt32(row.Cells["SoLuong"].Value) + soLuongMuon;
                            break;
                        }
                    }
                    // Xóa dòng trong DataGridView
                    dgvsach.Rows.RemoveAt(e.RowIndex);

                    // Nếu bạn cần xóa trong database hoặc danh sách dữ liệu => xử lý thêm tại đây
                }
            }
        }

        private void dgvtimkiem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvtimkiem.Columns[e.ColumnIndex].Name == "MaSach" && e.Value != null)
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
