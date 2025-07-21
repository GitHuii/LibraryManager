using Guna.UI2.WinForms;
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

namespace LibraryManager.View.QuanLySach
{
    public partial class Form_AddSach : Form
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public Form_AddSach()
        {
            this.Size = new Size(500, 500);
            InitializeComponent();
            new Guna2ShadowForm().SetShadowForm(this);
            cboTheloai.SelectedIndex = 0; // Đặt giá trị mặc định cho cboTheloai
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtTacGia.Text) ||
                string.IsNullOrWhiteSpace(cboTheloai.Text) ||
                string.IsNullOrWhiteSpace(txtNhaXuatBan.Text) ||
                string.IsNullOrWhiteSpace(txtNamXuatBan.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                cboTheloai.SelectedIndex <= 0)
                {
                    MessageBoxHelper.ShowWarning("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                if (!int.TryParse(txtNamXuatBan.Text, out int namXuatBan) || namXuatBan < 0 || namXuatBan > DateTime.Today.Year ||
                    !int.TryParse(txtSoLuong.Text, out int soluong) || soluong <= 0 )
                {
                    MessageBoxHelper.ShowWarning("Dữ liệu nhập không hợp lệ");
                    return;
                }
                var sach = new Sach
                {
                    Ten = txtTen.Text,
                    TacGia = txtTacGia.Text,
                    TheLoai = cboTheloai.Text,
                    NXB = txtNhaXuatBan.Text,
                    NamXuatBan = int.Parse(txtNamXuatBan.Text),
                    SoLuong = int.Parse(txtSoLuong.Text)
                };
                dbContext.Saches.Add(sach);
                dbContext.SaveChanges();
                //MessageBox.Show("Thêm thành công");
                MessageBoxHelper.ShowSuccess("Thêm sách thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddSach_Load(object sender, EventArgs e)
        {

        }
    }
}
