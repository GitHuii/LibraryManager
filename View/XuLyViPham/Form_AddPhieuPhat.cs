using Guna.UI2.WinForms;
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

namespace LibraryManager.View.XuLyViPham
{
    public partial class Form_AddPhieuPhat : Form
    {
        AppDbContext dbContext = DbContextProvider.Instance;

        bool isLoaded = false;
        public Form_AddPhieuPhat()
        {
            this.Size = new Size(500, 500);
            InitializeComponent();
            new Guna2ShadowForm().SetShadowForm(this);

            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(cbomadocgia.Text) || 
                    string.IsNullOrWhiteSpace(txtSoTienPhat.Text) ||
                    string.IsNullOrWhiteSpace(txtLyDo.Text))
                {
                    //MessageBox.Show("Vui lòng chọn Mã Độc Giả", "Thông báo");
                    MessageBoxHelper.ShowWarning("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                var phieu = new PhieuPhat
                {
                    MaDocGia = int.Parse(cbomadocgia.SelectedValue.ToString()),
                    NgayLap = dtpNgayLap.Value,
                    SoTienPhat = decimal.Parse(txtSoTienPhat.Text),
                    LyDo = txtLyDo.Text,
                };

                dbContext.PhieuPhats.Add(phieu);
                dbContext.SaveChanges();
                //MessageBox.Show("Thêm phiếu phạt thành công!", "Thông báo");
                MessageBoxHelper.ShowSuccess("Thêm phiếu phạt thành công!", "Thông báo");
                this.Close(); // đóng form sau khi lưu
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                MessageBoxHelper.ShowError("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void Form_AddPhieuPhat_Load(object sender, EventArgs e)
        {
            dtpNgayLap.Value = DateTime.Now.Date;
            cbomadocgia.DataSource = dbContext.DocGias
                .OrderBy(pm => pm.MaDocGia)
                .Select(pm => new
                {
                    Value = pm.MaDocGia,                    // giá trị xử lý nội bộ
                    Display = "DG" + pm.MaDocGia.ToString("D3")  // hiển thị đẹp
                })
                .ToList();

            cbomadocgia.DisplayMember = "Display";
            cbomadocgia.ValueMember = "Value";
            cbomadocgia.DropDownHeight = 500;
            cbomadocgia.SelectedIndex = -1;
            isLoaded = true; // Chọn mục đầu tiên
        }

        private void cbomadocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }
            DocGia docGia = dbContext.DocGias.FirstOrDefault(dg => dg.MaDocGia == int.Parse(cbomadocgia.SelectedValue.ToString()));
            txtTen.Text = docGia?.Ten ?? string.Empty;
        }
    }
}
