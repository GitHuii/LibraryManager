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
    }
}
