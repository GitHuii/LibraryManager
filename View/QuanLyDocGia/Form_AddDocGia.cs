﻿using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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

namespace LibraryManager.View.QuanLyDocGia
{
    public partial class Form_AddDocGia : Form
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public Form_AddDocGia()
        {
            this.Size = new Size(500, 500);
            InitializeComponent();
            new Guna2ShadowForm().SetShadowForm(this);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    //MessageBox.Show("Vui lòng nhập đầy đủ thông tin độc giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBoxHelper.ShowWarning("Vui lòng nhập đầy đủ thông tin độc giả.");
                    return;
                }
                DocGia dg = new DocGia()
                {
                    Ten = txtTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value.Date,
                    DiaChi = txtDiaChi.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SDT = txtDiaChi.Text.Trim()
                };

                dbContext.DocGias.Add(dg);
                dbContext.SaveChanges();
                //MessageBox.Show("Thêm độc giả thành công!");
                MessageBoxHelper.ShowSuccess("Thêm độc giả thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi thêm độc giả: " + ex.Message);
                MessageBoxHelper.ShowError("Lỗi khi thêm độc giả: " + ex.Message);
            }
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
