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
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txttk.Text) || string.IsNullOrWhiteSpace(txtmk.Text) || string.IsNullOrWhiteSpace(txtnhaplaimk.Text) || string.IsNullOrWhiteSpace(cbophanquyen.Text))
                {
                    //MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBoxHelper.ShowWarning("Vui lòng nhập đầy đủ thông tin tài khoản.");
                    return;
                }
                if (txtmk.Text != txtnhaplaimk.Text)
                {
                    //MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBoxHelper.ShowWarning("Mật khẩu không khớp, vui lòng nhập lại.");
                    return;
                }

                var existingAccount = dbContext.TaiKhoans.FirstOrDefault(tk => tk.UserName == txttk.Text);
                if(existingAccount!=null)
                {
                    MessageBoxHelper.ShowError("Tài khoản đã tồn tại, vui lòng chọn tên tài khoản khác.");
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
                MessageBoxHelper.ShowInfo("Thêm tài khoản thành công!");
                //MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Lỗi khi thêm tài khoản: " + ex.Message);
                //MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
