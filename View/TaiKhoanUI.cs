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
    public partial class TaiKhoanUI : UserControl
    {
        public TaiKhoanUI()
        {
            InitializeComponent();
        }

        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        void LoadData()
        {
            dgvqltk.DataSource = taiKhoanDAO.GetAllTaiKhoans();
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
            taiKhoanDAO.AddTaiKhoan(tk);
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
            taiKhoanDAO.UpdateTaiKhoan(tk);
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var userName = txttk.Text;
            taiKhoanDAO.DeleteTaiKhoan(userName);
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

        private void dgvqltk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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
                dgvqltk.DataSource = taiKhoanDAO.SearchTaiKhoan(keyword);
            }

            txttimkiem.Clear();

        }
    }
}
