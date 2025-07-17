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

namespace LibraryManager.View.QuanLyTaiKhoan
{
    public partial class Form_AddTaiKhoan : Form
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public Form_AddTaiKhoan()
        {
            this.Size = new Size(500, 500);
            InitializeComponent();
        }

        private void Form_AddTaiKhoan_Load(object sender, EventArgs e)  
        {

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttk.Text) || string.IsNullOrWhiteSpace(txtmk.Text) || string.IsNullOrWhiteSpace(txtnhaplaimk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmk.Text != txtnhaplaimk.Text)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tk = new TaiKhoan
            {
                UserName = txttk.Text,
                PassWord = txtmk.Text,
                Role = cbophanquyen.Text
            };
            dbContext.TaiKhoans.Add(tk);
            dbContext.SaveChanges();
            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
