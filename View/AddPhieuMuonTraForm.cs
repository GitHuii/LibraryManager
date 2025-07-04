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
    public partial class AddPhieuMuonTraForm : Form
    {
        public AddPhieuMuonTraForm()
        {
            InitializeComponent();
            PhieuMuonTraUIAdd_Load(null, null);
        }
        AppDbContext dbContext = DbContextProvider.Instance;
        private void PhieuMuonTraUIAdd_Load(object sender, EventArgs e)
        {
            txtngaymuon.Text = DateTime.Now.Date.ToString();

            var ds = dbContext.Sachs.ToList();
            dgvtimkiem.DataSource = null ;
            dgvtimkiem.DataSource = ds;
            dgvtimkiem.Columns["NXB"].Visible = false;
            dgvtimkiem.Columns["TheLoai"].Visible = false;
            dgvtimkiem.Columns["NamXuatBan"].Visible = false;
            dgvtimkiem.Columns["TacGia"].Visible = false;
            dgvtimkiem.Columns["SoLuong"].HeaderText = "Còn Lại";
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = dbContext.Sachs.Where(s => s.Ten.ToLower().Contains(txttimkiem.Text.ToLower())).ToList();
            dgvtimkiem.Columns["NXB"].Visible = false;
            dgvtimkiem.Columns["TheLoai"].Visible = false;
            dgvtimkiem.Columns["NamXuatBan"].Visible = false;
            dgvtimkiem.Columns["TacGia"].Visible = false;
            dgvtimkiem.Columns["SoLuong"].HeaderText = "Còn Lại";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int index = dgvtimkiem.CurrentCell.RowIndex;
            string MaSach = dgvtimkiem.Rows[index].Cells["MaSach"].Value.ToString();
            string TenSach = dgvtimkiem.Rows[index].Cells["Ten"].Value.ToString();
            string SoLuong = txtsoluong.Text;
            dgvsach.Rows.Add(MaSach, TenSach, SoLuong);
            dgvtimkiem.Rows[index].Cells["SoLuong"].Value = Convert.ToInt32(dgvtimkiem.Rows[index].Cells["SoLuong"].Value) - Convert.ToInt32(SoLuong);
        }

        public void ShowCustomMessage(string message, string title)
        {
            Form msgForm = new Form();
            msgForm.FormBorderStyle = FormBorderStyle.None;
            msgForm.StartPosition = FormStartPosition.Manual;
            msgForm.Size = new Size(350, 180);
            msgForm.BackColor = Color.WhiteSmoke;
            msgForm.TopMost = true;

            // Tọa độ giữa màn hình
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            msgForm.Location = new Point(
                screen.Left + (screen.Width - msgForm.Width) / 2,
                screen.Top + (screen.Height - msgForm.Height) / 2
            );

            // Label
            var label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label.Text = message;
            label.Font = new Font("Segoe UI", 11F);
            label.Location = new Point(30, 40);
            label.Size = new Size(290, 60);
            msgForm.Controls.Add(label);

            // Nút OK
            var btnOK = new Guna.UI2.WinForms.Guna2Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(msgForm.Width / 2 - 45, 110);
            btnOK.Size = new Size(90, 35);
            btnOK.Click += (s, e) => msgForm.Close();
            msgForm.Controls.Add(btnOK);

            msgForm.ShowDialog();


        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuMuonTra> chiTietList = new List<ChiTietPhieuMuonTra>();

            foreach (DataGridViewRow row in dgvsach.Rows)
            {
                int maSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                chiTietList.Add(new ChiTietPhieuMuonTra
                {
                    MaSach = maSach,
                    SoLuong = soLuong
                });
            }

            var phieuMoi = new PhieuMuonTra
            {
                MaDocGia = int.Parse(txtmadocgia.Text),
                NgayMuon = DateTime.Now,
                HanTra = dtphantra.Value.Date,
                DaTra = false,
                ChiTietPhieuMuonTras = chiTietList
            };
            using (var context = new AppDbContext())
            {
                // Lặp qua từng sách mượn
                foreach (var ct in phieuMoi.ChiTietPhieuMuonTras)
                {
                    var sach = context.Sachs.FirstOrDefault(s => s.MaSach == ct.MaSach);
                    if (sach == null)
                    {
                        throw new Exception($"Không tìm thấy sách với mã {ct.MaSach}");
                    }

                    if (sach.SoLuong < ct.SoLuong)
                    {
                        throw new Exception($"Không đủ số lượng sách {sach.Ten}. Còn lại: {sach.SoLuong}");
                    }

                    // Trừ số lượng sách
                    sach.SoLuong -= ct.SoLuong;
                }
                // Thêm phiếu mượn
                context.PhieuMuonTras.Add(phieuMoi);
                context.SaveChanges();
            }
            ShowCustomMessage("Bạn đã lưu thành công!", "Thông báo");
            this.Close();
        }

        private void dgvtimkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
