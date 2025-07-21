using LibraryManager.DAO;
using LibraryManager.Models;
using LibraryManager.View.QuanLySach;
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
    public partial class UC_QuanLySach : UserControl
    {
        public UC_QuanLySach()
        {
            InitializeComponent();
        }
        int ma = 0;
        AppDbContext dbContext = DbContextProvider.Instance;
        private void LoadData()
        {
            dgvSach.DataSource = dbContext.Saches.ToList();
            dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvSach.Columns["Ten"].HeaderText = "Tên Sách";
            dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvSach.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvSach.Columns["NXB"].HeaderText = "Nhà Xuất Bản";
            dgvSach.Columns["NamXuatBan"].HeaderText = "Năm Xuất Bản";
            dgvSach.Columns["SoLuong"].HeaderText = "Số Lượng";
            formclear();
        }

        private void SachUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new Form_AddSach().ShowDialog();
            LoadData();

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSach.Rows[e.RowIndex];
                ma = Convert.ToInt32(row.Cells["MaSach"].Value.ToString());
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                cboTheloai.Text = row.Cells["TheLoai"].Value.ToString();
                txtNhaXuatBan.Text = row.Cells["NXB"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtTacGia.Text) || string.IsNullOrWhiteSpace(cboTheloai.Text) || string.IsNullOrWhiteSpace(txtNhaXuatBan.Text) || string.IsNullOrWhiteSpace(txtNamXuatBan.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    //MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBoxHelper.ShowWarning("Vui lòng nhập đầy đủ thông tin sách.");
                    return;
                }
                DialogResult result = MessageBoxHelper.ShowQuestion($"Sửa thông tin sách {txtTen.Text} ?");
                if (result != DialogResult.Yes)
                {
                    return;
                }
                var sach = dbContext.Saches.Find(Convert.ToInt32(dgvSach.CurrentRow.Cells[0].Value));
                if (sach != null)
                {
                    sach.Ten = txtTen.Text;
                    sach.TacGia = txtTacGia.Text;
                    sach.TheLoai = cboTheloai.Text;
                    sach.NXB = txtNhaXuatBan.Text;
                    sach.NamXuatBan = int.Parse(txtNamXuatBan.Text);
                    sach.SoLuong = int.Parse(txtSoLuong.Text);
                }
                ;
                dbContext.SaveChanges();
                //MessageBox.Show("Sửa thành công");
                MessageBoxHelper.ShowSuccess("Cập nhật thông tin sách thành công");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message);
            }
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var sach = dbContext.Saches.Find(dgvSach.CurrentRow.Cells[0].Value);
                //var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không", "Yes", MessageBoxButtons.YesNo);
                DialogResult result = MessageBoxHelper.ShowQuestion($"Xóa sách {sach.Ten} ?");
                if (result == DialogResult.Yes)
                {
                    dbContext.Saches.Remove(sach);
                    dbContext.SaveChanges();
                    //MessageBox.Show("Xóa thành công");
                    MessageBoxHelper.ShowSuccess("Xóa sách thành công");
                    LoadData();
                    formclear();
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message);
            }


        }
        void formclear()
        {
            txtTen.Clear();
            txtTacGia.Clear();
            cboTheloai.SelectedItem = "--- Chọn Thể Loại ---";
            txtNhaXuatBan.Clear();
            txtNamXuatBan.Clear();
            txtSoLuong.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var tk = txtTimKiem.Text;
            var result = dbContext.Saches.Where(s => s.Ten.ToLower().Contains(tk.ToLower())).ToList();
            dgvSach.DataSource = result;

        }

        private void dgvSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSach.Columns[e.ColumnIndex].Name == "MaSach" && e.Value != null)
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
