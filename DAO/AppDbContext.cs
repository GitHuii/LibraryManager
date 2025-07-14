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
            optionsBuilder.UseSqlServer(@"Data Source=KHIGH\SQLEXPRESS;Initial Catalog=LibraryManager;Integrated Security=True;Trust Server Certificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaiKhoan>().HasData(EnityData.GetData_TaiKhoan());

            modelBuilder.Entity<DocGia>().HasData(EnityData.GetData_DocGia());

            modelBuilder.Entity<Sach>().HasData(EnityData.GetData_Sach());

            modelBuilder.Entity<PhieuMuonTra>().HasData(EnityData.GetData_PhieuMuonTra());

            modelBuilder.Entity<ChiTietPhieuMuonTra>().HasKey(p => new { p.MaPhieuMuonTra, p.MaSach });
            modelBuilder.Entity<ChiTietPhieuMuonTra>().HasData(EnityData.GetData_ChiTietPhieuMuonTra());

        }

    }
}
