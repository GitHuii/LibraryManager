using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAO
{
    public class PhieuMuonTraDAO
    {
        AppDbContext _context = new AppDbContext();

        public List<PhieuMuonTra> GetAllPhieuMuonTra()
        {
            return _context.PhieuMuonTras.ToList();
        }
        public void ThemPhieuMoi(int maDocGia, List<(int maSach, int soLuong)> danhSachSach)
        {
            var phieu = new PhieuMuonTra
            {
                MaDocGia = maDocGia,
                NgayMuon = DateTime.Now,
                HanTra = DateTime.Now.AddDays(7),
                ChiTietPhieuMuonTras = danhSachSach.Select(s => new ChiTietPhieuMuonTra
                {
                    MaSach = s.maSach,
                    SoLuong = s.soLuong,
                }).ToList()
            };

            _context.PhieuMuonTras.Add(phieu);
            _context.SaveChanges();
        }


    }
}
