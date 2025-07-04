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
    public partial class UC_QuanLySach : UserControl
    {
        public UC_QuanLySach()
        {
            InitializeComponent();
        }
        int ma = 0;
        private void LoadData()
        {
            using (var db = new AppDbContext())
            {
                dgvSach.DataSource = db.Sachs.ToList();
            }
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
            using (var db = new AppDbContext())
            {
                var sach = new Sach
                {
                    Ten = txtTen.Text,
                    TacGia = txtTacGia.Text,
                    TheLoai = txtTheLoai.Text,
                    NXB = txtNhaXuatBan.Text,
                    NamXuatBan = int.Parse(txtNamXuatBan.Text),
                    SoLuong = int.Parse(txtSoLuong.Text)
                };
                db.Sachs.Add(sach);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
                LoadData();
            }

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSach.Rows[e.RowIndex];
                ma = Convert.ToInt32(row.Cells["MaSach"].Value.ToString());
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                txtNhaXuatBan.Text = row.Cells["NXB"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var sach = db.Sachs.Find(ma);
                if (sach != null)
                {
                    sach.Ten = txtTen.Text;
                    sach.TacGia = txtTacGia.Text;
                    sach.TheLoai = txtTheLoai.Text;
                    sach.NXB = txtNhaXuatBan.Text;
                    sach.NamXuatBan = int.Parse(txtNamXuatBan.Text);
                    sach.SoLuong = int.Parse(txtSoLuong.Text);
                }
                ;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công");
                LoadData();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var sach = db.Sachs.Find(ma);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không", "Yes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Sachs.Remove(sach);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                    formclear();
                }

            }
        }
        void formclear()
        {
            txtTen.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNhaXuatBan.Clear();
            txtNamXuatBan.Clear();
            txtSoLuong.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var tk = txtTimKiem.Text;
                var result = db.Sachs.Where(s => s.Ten.ToLower().Contains(tk.ToLower())).ToList();
                dgvSach.DataSource = result;
            }
        }
    }
}
