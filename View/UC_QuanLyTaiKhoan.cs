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
    public partial class UC_QuanLyTaiKhoan : UserControl
    {
        public UC_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        AppDbContext dbContext = DbContextProvider.Instance;
        void LoadData()
        {
            dgvqltk.DataSource = dbContext.TaiKhoans.ToList();
        }
        private void TaiKhoanUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var tk = new TaiKhoan
            {
                UserName = txttk.Text,
                PassWord = txtmk.Text
            };
            dbContext.TaiKhoans.Add(tk);
            dbContext.SaveChanges();

            LoadData();
            txttk.Clear();
            txtmk.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var tk = new TaiKhoan
            {
                UserName = txttk.Text,
                PassWord = txtmk.Text
            };
            var existing = dbContext.TaiKhoans.Find(tk.UserName);
            if (existing != null)
            {
                existing.PassWord = tk.PassWord;
                dbContext.SaveChanges();
            }
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var userName = txttk.Text;
            var existing = dbContext.TaiKhoans.Find(userName);
            if (existing != null)
            {
                dbContext.TaiKhoans.Remove(existing);
                dbContext.SaveChanges();
            }
            LoadData();
            txttk.Clear();
            txtmk.Clear();
        }

        private void dgvqltk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txttk.Text = dgvqltk.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtmk.Text = dgvqltk.Rows[e.RowIndex].Cells["PassWord"].Value.ToString();
            }
        }



        private void btntimkiem_Click(object sender, EventArgs e)
        {

            string keyword = txttimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                dgvqltk.DataSource = dbContext.TaiKhoans.Where(t => t.UserName.Contains(keyword)).ToList(); ;
            }

            txttimkiem.Clear();

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                dgvqltk.DataSource = dbContext.TaiKhoans.Where(t => t.UserName.Contains(keyword)).ToList(); ;
            }

            txttimkiem.Clear();
        }

        private void dgvqltk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvqltk.Columns[e.ColumnIndex].Name == "PassWord" && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
            }
        }
    }
}
