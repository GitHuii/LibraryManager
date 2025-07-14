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

namespace LibraryManager.View
{
    public partial class AddXuLyPhieuPhat : Form
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public AddXuLyPhieuPhat()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = new PhieuPhat
                {
                    MaDocGia = int.Parse(txtMaDocGia.Text),
                    NgayLap = dtpNgayLap.Value,
                    SoTienPhat = decimal.Parse(txtSoTienPhat.Text),
                    LyDo = txtLyDo.Text,
                    DaThuTien = chkDaThuTien.Checked
                };

                dbContext.PhieuPhats.Add(phieu);
                dbContext.SaveChanges();
                MessageBox.Show("Thêm phiếu phạt thành công!", "Thông báo");
                this.Close(); // đóng form sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
