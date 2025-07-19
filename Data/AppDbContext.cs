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
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

        public DbSet<PhieuTra> PhieuTras { get; set; }
        public DbSet<ChiTietPhieuTra> ChiTietPhieuTras { get; set; }
        public DbSet<PhieuPhat> PhieuPhats { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=HUII;Initial Catalog=LibraryManager;Integrated Security=True;Trust Server Certificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChiTietPhieuMuon>().HasKey(p => new { p.MaPhieuMuon, p.MaSach });
            modelBuilder.Entity<ChiTietPhieuTra>().HasKey(p => new { p.MaPhieuTra, p.MaSach });

            modelBuilder.Entity<TaiKhoan>().HasData(EnityData.GetData_TaiKhoan());

            modelBuilder.Entity<DocGia>().HasData(EnityData.GetData_DocGia());

            modelBuilder.Entity<Sach>().HasData(EnityData.GetData_Sach());

            modelBuilder.Entity<PhieuMuon>().HasData(EnityData.GetData_PhieuMuon());

            modelBuilder.Entity<ChiTietPhieuMuon>().HasData(EnityData.GetData_ChiTietPhieuMuon());

            modelBuilder.Entity<PhieuTra>().HasData(EnityData.GetData_PhieuMuon());

            modelBuilder.Entity<ChiTietPhieuTra>().HasData(EnityData.GetData_ChiTietPhieuMuon());

            modelBuilder.Entity<PhieuPhat>().HasData(EnityData.GetData_PhieuPhat());

        }

    }
}
