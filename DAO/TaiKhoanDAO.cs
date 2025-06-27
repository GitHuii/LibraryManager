using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAO
{
    public class TaiKhoanDAO
    {
        AppDbContext _context = new AppDbContext();

        public List<TaiKhoan> GetAllTaiKhoans()
        {
            return _context.TaiKhoans.ToList();
        }

        public void AddTaiKhoan(TaiKhoan tk)
        {
            _context.TaiKhoans.Add(tk);
            _context.SaveChanges();
        }

        public void UpdateTaiKhoan(TaiKhoan tk)
        {
            var existing = _context.TaiKhoans.Find(tk.UserName);
            if (existing != null)
            {
                existing.PassWord = tk.PassWord;
                _context.SaveChanges();
            }
        }

        public void DeleteTaiKhoan(string userName)
        {
            var existing = _context.TaiKhoans.Find(userName);
            if (existing != null)
            {
                _context.TaiKhoans.Remove(existing);
                _context.SaveChanges();
            }
        }

        public List<TaiKhoan> SearchTaiKhoan(string keyword)
        {
            return _context.TaiKhoans
                .Where(t => t.UserName.Contains(keyword))
                .ToList();
        }
    }
}
