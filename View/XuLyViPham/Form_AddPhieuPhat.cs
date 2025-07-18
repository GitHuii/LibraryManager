﻿using Guna.UI2.WinForms;
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
                    MaDocGia = int.Parse(cbomadocgia.Text),
                    NgayLap = dtpNgayLap.Value,
                    SoTienPhat = decimal.Parse(txtSoTienPhat.Text),
                    LyDo = txtLyDo.Text,
                };

                dbContext.PhieuPhats.Add(phieu);
                dbContext.SaveChanges();
                //MessageBox.Show("Thêm phiếu phạt thành công!", "Thông báo");
                MessageBoxHelper.ShowInfo("Thêm phiếu phạt thành công!", "Thông báo");
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
            cbomadocgia.Items.AddRange(dbContext.DocGias.Select(dg => (object)dg.MaDocGia).ToArray());
            cbomadocgia.DropDownHeight = 500;
        }

        private void cbomadocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomadocgia.SelectedIndex == 0)
            {
                txtTen.Text = "Chọn Mã Độc Giả Trước";
                return;
            }
            DocGia docGia = dbContext.DocGias.FirstOrDefault(dg => dg.MaDocGia == int.Parse(cbomadocgia.Text));
            txtTen.Text = docGia?.Ten ?? string.Empty;
        }
    }
}
