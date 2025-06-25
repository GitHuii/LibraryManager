using LibraryManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAO
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sach> Saches { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<PhieuMuonTra> PhieuMuonTras { get; set; }
        public DbSet<ChiTietPhieuMuonTra> ChiTietPhieuMuonTras { get; set; }
        public DbSet<PhieuPhat> PhieuPhats { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HUII;Initial Catalog=LibraryManager;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 📘 DocGia
            modelBuilder.Entity<DocGia>().HasData(
                new DocGia { MaDocGia = 1, Ten = "Nguyễn Văn A", NgaySinh = new DateTime(2000, 1, 1), DiaChi = "Hà Nội", Email = "a@example.com", SDT = "0911111111" },
                new DocGia { MaDocGia = 2, Ten = "Trần Thị B", NgaySinh = new DateTime(1999, 5, 12), DiaChi = "TP.HCM", Email = "b@example.com", SDT = "0922222222" },
                new DocGia { MaDocGia = 3, Ten = "Lê Văn C", NgaySinh = new DateTime(2001, 3, 20), DiaChi = "Đà Nẵng", Email = "c@example.com", SDT = "0933333333" },
                new DocGia { MaDocGia = 4, Ten = "Phạm Thị D", NgaySinh = new DateTime(2002, 8, 8), DiaChi = "Huế", Email = "d@example.com", SDT = "0944444444" },
                new DocGia { MaDocGia = 5, Ten = "Hoàng Văn E", NgaySinh = new DateTime(1998, 10, 30), DiaChi = "Cần Thơ", Email = "e@example.com", SDT = "0955555555" }
            );

            // 📕 Sach
            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach = 1, Ten = "Lập trình C#", TacGia = "Nguyễn Văn T", TheLoai = "CNTT", NXB = "NXB Trẻ", NamXuatBan = 2021, SoLuong = 10 },
                new Sach { MaSach = 2, Ten = "Toán cao cấp", TacGia = "Phạm Văn P", TheLoai = "Giáo trình", NXB = "NXB Giáo dục", NamXuatBan = 2020, SoLuong = 15 },
                new Sach { MaSach = 3, Ten = "Kỹ năng sống", TacGia = "Trần Thị Q", TheLoai = "Kỹ năng", NXB = "NXB Thanh Niên", NamXuatBan = 2019, SoLuong = 8 },
                new Sach { MaSach = 4, Ten = "Tiếng Anh giao tiếp", TacGia = "Lê Văn K", TheLoai = "Ngoại ngữ", NXB = "NXB Văn hóa", NamXuatBan = 2018, SoLuong = 12 },
                new Sach { MaSach = 5, Ten = "Tư duy phản biện", TacGia = "Nguyễn Thị H", TheLoai = "Kỹ năng", NXB = "NXB Lao động", NamXuatBan = 2022, SoLuong = 6 }
            );

            // 📄 PhieuMuonTra
            modelBuilder.Entity<PhieuMuonTra>().HasData(
                new PhieuMuonTra { MaPhieuMuonTra = 1, MaDocGia = 1, NgayMuon = DateTime.Today.AddDays(-5), HanTra = DateTime.Today.AddDays(5) },
                new PhieuMuonTra { MaPhieuMuonTra = 2, MaDocGia = 2, NgayMuon = DateTime.Today.AddDays(-4), HanTra = DateTime.Today.AddDays(6) },
                new PhieuMuonTra { MaPhieuMuonTra = 3, MaDocGia = 3, NgayMuon = DateTime.Today.AddDays(-3), HanTra = DateTime.Today.AddDays(7) },
                new PhieuMuonTra { MaPhieuMuonTra = 4, MaDocGia = 4, NgayMuon = DateTime.Today.AddDays(-2), HanTra = DateTime.Today.AddDays(8) },
                new PhieuMuonTra { MaPhieuMuonTra = 5, MaDocGia = 5, NgayMuon = DateTime.Today.AddDays(-1), HanTra = DateTime.Today.AddDays(9) }
            );

            // 📎 ChiTietPhieuMuonTra
            modelBuilder.Entity<ChiTietPhieuMuonTra>().HasData(
                new ChiTietPhieuMuonTra { MaChiTietPhieuMuon = 1, MaPhieuMuonTra = 1, MaSach = 1, SoLuong = 2 },
                new ChiTietPhieuMuonTra { MaChiTietPhieuMuon = 2, MaPhieuMuonTra = 1, MaSach = 2, SoLuong = 1 },
                new ChiTietPhieuMuonTra { MaChiTietPhieuMuon = 3, MaPhieuMuonTra = 2, MaSach = 3, SoLuong = 1 },
                new ChiTietPhieuMuonTra { MaChiTietPhieuMuon = 4, MaPhieuMuonTra = 3, MaSach = 4, SoLuong = 1 },
                new ChiTietPhieuMuonTra { MaChiTietPhieuMuon = 5, MaPhieuMuonTra = 4, MaSach = 5, SoLuong = 2 }
            );

            // 💸 PhieuPhat
            modelBuilder.Entity<PhieuPhat>().HasData(
                new PhieuPhat { MaPhieuPhat = "PP001", MaDocGia = 1, NgayLap = DateTime.Today, SoTienPhat = 5000, LyDo = "Trả trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = "PP002", MaDocGia = 2, NgayLap = DateTime.Today, SoTienPhat = 7000, LyDo = "Mất sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = "PP003", MaDocGia = 3, NgayLap = DateTime.Today, SoTienPhat = 10000, LyDo = "Trả sai sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = "PP004", MaDocGia = 4, NgayLap = DateTime.Today, SoTienPhat = 3000, LyDo = "Sách rách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = "PP005", MaDocGia = 5, NgayLap = DateTime.Today, SoTienPhat = 8000, LyDo = "Không trả sách", DaThuTien = true }
            );

            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan { UserName = "huii", PassWord = "123"},
                new TaiKhoan { UserName = "huiii", PassWord = "1234" },
                new TaiKhoan { UserName = "huiiiii", PassWord = "12345" }
                );
        }

    }
}
