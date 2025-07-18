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
using LibraryManager.View.XuLyViPham;
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
        private void dgvPhieuPhat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuPhat.Columns[e.ColumnIndex].Name == "SoTienPhat" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal tienPhat))
                {
                    e.Value = tienPhat.ToString("#,0", new System.Globalization.CultureInfo("vi-VN"));
                    e.FormattingApplied = true;
                }
            }
            if (dgvPhieuPhat.Columns[e.ColumnIndex].Name == "MaDocGia" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "DG" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
            if (dgvPhieuPhat.Columns[e.ColumnIndex].Name == "MaPhieuPhat" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "PP" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            new Form_AddPhieuPhat().ShowDialog();
            LoadData(); // tải lại danh sách sau khi thêm
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieu = int.Parse(dgvPhieuPhat.CurrentRow.Cells["MaPhieuPhat"].Value.ToString());

                var phieu = dbContext.PhieuPhats.Find(maPhieu);
                if (phieu == null)
                {
                    MessageBoxHelper.ShowWarning("Phiếu phạt không tồn tại.");
                    return;
                }
                if (phieu.DaThuTien)
                {
                    MessageBoxHelper.ShowWarning("Phiếu phạt đã được thu tiền.");
                    return;
                }
                DialogResult result = MessageBoxHelper.ShowQuestion($"Thu tiền phiếu phạt PP{maPhieu.ToString("D3")}");
                if (result != DialogResult.Yes)
                {
                    return; // nếu không đồng ý thì thoát
                }
                if (phieu != null)
                {
                    phieu.DaThuTien = true;
                    dbContext.SaveChanges();
                    MessageBoxHelper.ShowInfo("Đã thu tiền phiếu phạt thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message, "Thông báo");
            }

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieu = int.Parse(dgvPhieuPhat.CurrentRow.Cells["MaPhieuPhat"].Value.ToString());
                DialogResult result = MessageBoxHelper.ShowQuestion($"Xóa phiết phạt PP{maPhieu.ToString("D3")} ?");
                if (result != DialogResult.Yes)
                {
                    return; // nếu không đồng ý thì thoát
                }
                var phieu = dbContext.PhieuPhats.Find(maPhieu);
                if (phieu != null)
                {
                    dbContext.PhieuPhats.Remove(phieu);
                    dbContext.SaveChanges();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message, "Thông báo");
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
            txtMaDocGia.Clear();
            txtSoTienPhat.Clear();
            txtLyDo.Clear();
            chkDaThuTien.Checked = false;
            dtpNgayLap.Value = DateTime.Now;
            txtTimKiem.Clear();
            LoadData();
        }


        private void dgvPhieuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhieuPhat.CurrentRow != null && dgvPhieuPhat.CurrentRow.Index >= 0)
            {
                var row = dgvPhieuPhat.CurrentRow;

                txtMaDocGia.Text = "DG" + Convert.ToInt32(row.Cells["MaDocGia"].Value).ToString("D3");
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                txtSoTienPhat.Text = row.Cells["SoTienPhat"].Value.ToString();
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                chkDaThuTien.Checked = Convert.ToBoolean(row.Cells["DaThuTien"].Value);
            }
        }
    }
}

