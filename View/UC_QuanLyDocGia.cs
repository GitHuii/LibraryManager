﻿using LibraryManager.DAO;
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
            try
            {
                DocGia dg = new DocGia()
                {
                    Ten = txtTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    DiaChi = txtDiaChi.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SDT = txtSDT.Text.Trim()
                };

                dbContext.DocGias.Add(dg);
                dbContext.SaveChanges();
                MessageBox.Show("Thêm độc giả thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm độc giả: " + ex.Message);
            }
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
                    MessageBox.Show("Vui lòng chọn độc giả hợp lệ để sửa.");
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
                    throw new Exception("Không tìm thấy độc giả để sửa.");
                }
                MessageBox.Show("Cập nhật thông tin thành công!");
                loadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
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
                    MessageBox.Show("Vui lòng chọn một độc giả để xóa.");
                    return;
                }

                if (!int.TryParse(dgvdocgia.Rows[dgvdocgia.CurrentRow.Index].Cells[0].Value.ToString(), out int maDG))
                {
                    MessageBox.Show("Mã độc giả không hợp lệ.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa độc giả này không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var dg = dbContext.DocGias.Find(maDG);
                    if (dg == null)
                    {
                        MessageBox.Show("Không tìm thấy độc giả để xóa trong CSDL.");
                        return;
                    }

                    dbContext.DocGias.Remove(dg);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa độc giả thành công!");
                    loadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa độc giả: " + ex.Message);
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

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.");
                return;
            }

            var result = dbContext.DocGias.Where(d => d.Ten.Contains(keyword)).ToList(); ;

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy độc giả nào.");
            }

            dgvdocgia.DataSource = result;

        }
    }
}
