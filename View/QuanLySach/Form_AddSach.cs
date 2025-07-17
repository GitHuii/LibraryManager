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
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Thêm thành công");
            this.Close();
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
