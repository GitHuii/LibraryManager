using LibraryManager.DAO;
using LibraryManager.Models;
using LibraryManager.View.QuanLyDocGia;
using LibraryManager.View.QuanLyTaiKhoan;
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

namespace LibraryManager.View
{


    public partial class UC_QuanLyDocGia : UserControl
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public UC_QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void dgvdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dgvdocgia.DataSource = dbContext.DocGias.ToList();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            new Form_AddDocGia().ShowDialog();
            loadData();
        }

        private void lblten_Click(object sender, EventArgs e)
        {

        }

        private void dgvdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvdocgia.CurrentRow.Index;
            txtTen.Text = dgvdocgia.Rows[row].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvdocgia.Rows[row].Cells[2].Value);
            txtDiaChi.Text = dgvdocgia.Rows[row].Cells[3].Value.ToString();
            txtEmail.Text = dgvdocgia.Rows[row].Cells[4].Value.ToString();
            txtSDT.Text = dgvdocgia.Rows[row].Cells[5].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(dgvdocgia.Rows[dgvdocgia.CurrentRow.Index].Cells[0].Value.ToString(), out int maDG))
                {
                    //MessageBox.Show("Vui lòng chọn độc giả hợp lệ để sửa.");
                    MessageBoxHelper.ShowWarning("Vui lòng chọn độc giả hợp lệ để sửa.");
                    return;
                }
                if( string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    //MessageBox.Show("Vui lòng điền đầy đủ thông tin độc giả.");
                    MessageBoxHelper.ShowWarning("Vui lòng điền đầy đủ thông tin độc giả.");
                    return;
                }
                DialogResult result = MessageBoxHelper.ShowQuestion($"Bạn có chắc muốn sửa thông tin độc giả DG{maDG.ToString("D3")} không?");
                if (result != DialogResult.Yes)
                {
                    return;
                }
                var dg = dbContext.DocGias.Find(maDG);
                if (dg != null)
                {
                    dg.Ten = txtTen.Text.Trim();
                    dg.NgaySinh = dtpNgaySinh.Value;
                    dg.DiaChi = txtDiaChi.Text.Trim();
                    dg.Email = txtEmail.Text.Trim();
                    dg.SDT = txtSDT.Text.Trim();
                    dbContext.SaveChanges();
                }
                else
                {
                    //throw new Exception("Không tìm thấy độc giả để sửa.");
                    MessageBoxHelper.ShowError("Không tìm thấy độc giả để sửa.");
                    return;
                }
                //MessageBox.Show("Cập nhật thông tin thành công!");
                MessageBoxHelper.ShowInfo("Cập nhật thông tin thành công!");
                loadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                MessageBoxHelper.ShowError("Lỗi khi cập nhật: " + ex.Message);
            }
        }





        void ClearForm()
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }


        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvdocgia.CurrentRow == null)
                {
                    //MessageBox.Show("Vui lòng chọn một độc giả để xóa.");
                    MessageBoxHelper.ShowWarning("Vui lòng chọn một độc giả để xóa.");
                    return;
                }

                if (!int.TryParse(dgvdocgia.Rows[dgvdocgia.CurrentRow.Index].Cells[0].Value.ToString(), out int maDG))
                {
                    //MessageBox.Show("Mã độc giả không hợp lệ.");
                    MessageBoxHelper.ShowWarning("Mã độc giả không hợp lệ.");
                    return;
                }
                
                //DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa độc giả này không?",
                //                                      "Xác nhận xóa",
                //                                      MessageBoxButtons.YesNo,
                //                                      MessageBoxIcon.Warning);
                DialogResult result = MessageBoxHelper.ShowQuestion($"Bạn có chắc muốn xóa độc giả DG{maDG.ToString("D3")} không?");

                if (result == DialogResult.Yes)
                {
                    var dg = dbContext.DocGias.Find(maDG);
                    if (dg == null)
                    {
                        MessageBoxHelper.ShowWarning("Không tìm thấy độc giả.");
                        return;
                    }

                    dbContext.DocGias.Remove(dg);
                    dbContext.SaveChanges();
                    MessageBoxHelper.ShowInfo("Xóa độc giả thành công!");
                    loadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowWarning("Lỗi khi xóa độc giả: " + ex.Message);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            loadData();
            ClearForm();
        }

        private void dgvdocgia_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();
            var result = dbContext.DocGias.Where(d => d.Ten.Contains(keyword)).ToList();
            dgvdocgia.DataSource = result;

        }

        private void dgvdocgia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvdocgia.Columns[e.ColumnIndex].Name == "MaDocGia" && e.Value != null)
            {
                int so;
                if (int.TryParse(e.Value.ToString(), out so))
                {
                    e.Value = "DG" + so.ToString("D3");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
