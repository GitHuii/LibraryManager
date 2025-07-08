using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAO
{
    internal class EnityData
    {
        public static List<TaiKhoan> GetData_TaiKhoan()
        {
            return new List<TaiKhoan>
            {
                new TaiKhoan { UserName = "admin", PassWord = "123456" },
                new TaiKhoan { UserName = "user1", PassWord = "Password@123" },
                new TaiKhoan { UserName = "user2", PassWord = "Abc123!" },
                new TaiKhoan { UserName = "user3", PassWord = "123456" },
                new TaiKhoan { UserName = "user4", PassWord = "qwerty" },
                new TaiKhoan { UserName = "user5", PassWord = "helloWorld!" },
                new TaiKhoan { UserName = "user6", PassWord = "Secret123" },
                new TaiKhoan { UserName = "user7", PassWord = "Test@2025" },
                new TaiKhoan { UserName = "user8", PassWord = "LetMeIn" },
                new TaiKhoan { UserName = "user9", PassWord = "Admin#001" },
                new TaiKhoan { UserName = "user10", PassWord = "P@ssw0rd" }
            };
        }
        public static List<DocGia> GetData_DocGia()
        {
            return new List<DocGia>
            {
                new DocGia { MaDocGia = 1,  Ten = "Nguyễn Văn A",   NgaySinh = new DateTime(1998, 1, 15).Date,  DiaChi = "Hà Nội",      Email = "vana1@gmail.com",      SDT = "0912345678" },
                new DocGia { MaDocGia = 2,  Ten = "Trần Thị B",     NgaySinh = new DateTime(1997, 2, 20).Date,  DiaChi = "TP.HCM",      Email = "thib2@yahoo.com",      SDT = "0987654321" },
                new DocGia { MaDocGia = 3,  Ten = "Lê Văn C",       NgaySinh = new DateTime(1995, 3, 10).Date,  DiaChi = "Đà Nẵng",     Email = "le.c3@hotmail.com",    SDT = "0901234567" },
                new DocGia { MaDocGia = 4,  Ten = "Phạm Thị D",     NgaySinh = new DateTime(2000, 4, 5).Date,   DiaChi = "Cần Thơ",     Email = "phamd4@gmail.com",     SDT = "0932123456" },
                new DocGia { MaDocGia = 5,  Ten = "Hoàng Văn E",    NgaySinh = new DateTime(1999, 5, 30).Date,  DiaChi = "Hải Phòng",   Email = "ehoang5@gmail.com",    SDT = "0967890123" },
                new DocGia { MaDocGia = 6,  Ten = "Đỗ Thị F",       NgaySinh = new DateTime(2001, 6, 18).Date,  DiaChi = "Quảng Ninh",  Email = "f.d6@gmail.com",       SDT = "0978901234" },
                new DocGia { MaDocGia = 7,  Ten = "Vũ Văn G",       NgaySinh = new DateTime(1996, 7, 7).Date,   DiaChi = "Huế",         Email = "gvu7@gmail.com",       SDT = "0911223344" },
                new DocGia { MaDocGia = 8,  Ten = "Ngô Thị H",      NgaySinh = new DateTime(1994, 8, 25).Date,  DiaChi = "Nghệ An",     Email = "hngo8@yahoo.com",      SDT = "0922334455" },
                new DocGia { MaDocGia = 9,  Ten = "Bùi Văn I",      NgaySinh = new DateTime(1993, 9, 12).Date,  DiaChi = "Bình Dương",  Email = "ibui9@gmail.com",      SDT = "0933445566" },
                new DocGia { MaDocGia = 10, Ten = "Đặng Thị K",     NgaySinh = new DateTime(1992, 10, 1).Date,  DiaChi = "Đắk Lắk",     Email = "kdang10@gmail.com",    SDT = "0944556677" },
                new DocGia { MaDocGia = 11, Ten = "Trịnh Văn L",    NgaySinh = new DateTime(1991, 11, 11).Date, DiaChi = "Hòa Bình",    Email = "ltrinh11@gmail.com",   SDT = "0955667788" },
                new DocGia { MaDocGia = 12, Ten = "Phan Thị M",     NgaySinh = new DateTime(1990, 12, 21).Date, DiaChi = "Ninh Bình",   Email = "mphan12@gmail.com",    SDT = "0966778899" },
                new DocGia { MaDocGia = 13, Ten = "Lý Văn N",       NgaySinh = new DateTime(1989, 1, 9).Date,   DiaChi = "Thanh Hóa",   Email = "nly13@gmail.com",      SDT = "0977889900" },
                new DocGia { MaDocGia = 14, Ten = "Tạ Thị O",       NgaySinh = new DateTime(1998, 2, 28).Date,  DiaChi = "Phú Thọ",     Email = "ota14@gmail.com",      SDT = "0988990011" },
                new DocGia { MaDocGia = 15, Ten = "Đinh Văn P",     NgaySinh = new DateTime(1997, 3, 16).Date,  DiaChi = "Nam Định",    Email = "p.dinh15@gmail.com",   SDT = "0999001122" },
                new DocGia { MaDocGia = 16, Ten = "Hà Thị Q",       NgaySinh = new DateTime(1996, 4, 24).Date,  DiaChi = "Thái Bình",   Email = "q.ha16@gmail.com",     SDT = "0900112233" },
                new DocGia { MaDocGia = 17, Ten = "Trương Văn R",   NgaySinh = new DateTime(1995, 5, 5).Date,   DiaChi = "Lào Cai",     Email = "rtruong17@gmail.com",  SDT = "0911223345" },
                new DocGia { MaDocGia = 18, Ten = "Cao Thị S",      NgaySinh = new DateTime(1994, 6, 30).Date,  DiaChi = "Bắc Giang",   Email = "scao18@gmail.com",     SDT = "0922334456" },
                new DocGia { MaDocGia = 19, Ten = "Kiều Văn T",     NgaySinh = new DateTime(1993, 7, 17).Date,  DiaChi = "Tuyên Quang", Email = "tkieu19@gmail.com",    SDT = "0933445567" },
                new DocGia { MaDocGia = 20, Ten = "Lâm Thị U",      NgaySinh = new DateTime(1992, 8, 8).Date,   DiaChi = "Yên Bái",     Email = "ulam20@gmail.com",     SDT = "0944556678" },
                new DocGia { MaDocGia = 21, Ten = "Châu Văn V",     NgaySinh = new DateTime(1991, 9, 9).Date,   DiaChi = "Hà Giang",    Email = "vchau21@gmail.com",    SDT = "0955667789" },
                new DocGia { MaDocGia = 22, Ten = "Trịnh Thị X",    NgaySinh = new DateTime(1990, 10, 10).Date, DiaChi = "Sơn La",      Email = "xtrinh22@gmail.com",   SDT = "0966778890" },
                new DocGia { MaDocGia = 23, Ten = "Tống Văn Y",     NgaySinh = new DateTime(1989, 11, 11).Date, DiaChi = "Lạng Sơn",    Email = "ytong23@gmail.com",    SDT = "0977889901" },
                new DocGia { MaDocGia = 24, Ten = "Mai Thị Z",      NgaySinh = new DateTime(1988, 12, 12).Date, DiaChi = "Bắc Ninh",    Email = "zmai24@gmail.com",     SDT = "0988990012" },
                new DocGia { MaDocGia = 25, Ten = "Nguyễn Văn AA",  NgaySinh = new DateTime(1999, 1, 1).Date,   DiaChi = "Quảng Nam",   Email = "aa.ng25@gmail.com",    SDT = "0999001123" },
                new DocGia { MaDocGia = 26, Ten = "Trần Thị BB",    NgaySinh = new DateTime(1998, 2, 2).Date,   DiaChi = "Bình Phước",  Email = "bbtran26@gmail.com",   SDT = "0900112234" },
                new DocGia { MaDocGia = 27, Ten = "Lê Văn CC",      NgaySinh = new DateTime(1997, 3, 3).Date,   DiaChi = "Tây Ninh",    Email = "ccle27@gmail.com",     SDT = "0911223346" },
                new DocGia { MaDocGia = 28, Ten = "Phạm Thị DD",    NgaySinh = new DateTime(1996, 4, 4).Date,   DiaChi = "Hậu Giang",   Email = "ddpham28@gmail.com",   SDT = "0922334457" },
                new DocGia { MaDocGia = 29, Ten = "Hoàng Văn EE",   NgaySinh = new DateTime(1995, 5, 5).Date,   DiaChi = "Vĩnh Long",   Email = "eehoang29@gmail.com",  SDT = "0933445568" },
                new DocGia { MaDocGia = 30, Ten = "Đỗ Thị FF",      NgaySinh = new DateTime(1994, 6, 6).Date,   DiaChi = "Trà Vinh",    Email = "ffdo30@gmail.com",     SDT = "0944556679" }
            };
        }

        public static List<Sach> GetData_Sach()
        {
            return new List<Sach>
            {
                new Sach { MaSach = 1,  Ten = "Harry Potter và Hòn Đá Phù Thủy",        TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Giáo dục",       NXB = "NXB Kim Đồng",   NamXuatBan = 2012,  SoLuong = 28 },
                new Sach { MaSach = 2,  Ten = "Đắc Nhân Tâm",                           TacGia = "Nam Cao",             TheLoai = "Tâm lý",         NXB = "NXB Trẻ",        NamXuatBan = 2020,  SoLuong = 45 },
                new Sach { MaSach = 3,  Ten = "Dế Mèn Phiêu Lưu Ký",                    TacGia = "To Hoai",             TheLoai = "Thiếu nhi",      NXB = "NXB Kim Đồng",   NamXuatBan = 2015,  SoLuong = 32 },
                new Sach { MaSach = 4,  Ten = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",         TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Văn học",        NXB = "NXB Trẻ",        NamXuatBan = 2016,  SoLuong = 40 },
                new Sach { MaSach = 5,  Ten = "Lão Hạc",                                TacGia = "Ngô Tất Tố",          TheLoai = "Truyện ngắn",    NXB = "NXB Giáo Dục",   NamXuatBan = 2010,  SoLuong = 18 },
                new Sach { MaSach = 6,  Ten = "Chiếc Thuyền Ngoài Xa",                  TacGia = "Nguyễn Du",           TheLoai = "Văn học",        NXB = "NXB Văn Học",    NamXuatBan = 2013,  SoLuong = 25 },
                new Sach { MaSach = 7,  Ten = "Tuổi Thơ Dữ Dội",                        TacGia = "Truyện Dân Gian",     TheLoai = "Lịch sử",        NXB = "NXB Trẻ",        NamXuatBan = 2014,  SoLuong = 38 },
                new Sach { MaSach = 8,  Ten = "Số Đỏ",                                  TacGia = "Nam Cao",             TheLoai = "Truyện ngắn",    NXB = "NXB Văn Học",    NamXuatBan = 2021,  SoLuong = 15 },
                new Sach { MaSach = 9,  Ten = "Chí Phèo",                               TacGia = "Ngô Tất Tố",          TheLoai = "Truyện ngắn",    NXB = "NXB Văn Học",    NamXuatBan = 2012,  SoLuong = 30 },
                new Sach { MaSach = 10, Ten = "Nhà Giả Kim",                            TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Văn học",        NXB = "NXB Trẻ",        NamXuatBan = 2019,  SoLuong = 20 },
                new Sach { MaSach = 11, Ten = "1984",                                   TacGia = "J.K. Rowling",        TheLoai = "Khoa học",       NXB = "NXB Giáo Dục",   NamXuatBan = 2004,  SoLuong = 16 },
                new Sach { MaSach = 12, Ten = "Bắt Trẻ Đồng Xanh",                      TacGia = "Nguyễn Du",           TheLoai = "Tâm lý",         NXB = "NXB Tổng hợp",   NamXuatBan = 2020,  SoLuong = 22 },
                new Sach { MaSach = 13, Ten = "Ông Già Và Biển Cả",                     TacGia = "To Hoai",             TheLoai = "Lịch sử",        NXB = "NXB Kim Đồng",   NamXuatBan = 2011,  SoLuong = 17 },
                new Sach { MaSach = 14, Ten = "Không Gia Đình",                         TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Truyện ngắn",    NXB = "NXB Trẻ",        NamXuatBan = 2005,  SoLuong = 29 },
                new Sach { MaSach = 15, Ten = "Cuộc Đời Của Pi",                        TacGia = "Nam Cao",             TheLoai = "Văn học",        NXB = "NXB Tổng hợp",   NamXuatBan = 2022,  SoLuong = 34 },
                new Sach { MaSach = 16, Ten = "Kính Vạn Hoa",                           TacGia = "To Hoai",             TheLoai = "Thiếu nhi",      NXB = "NXB Kim Đồng",   NamXuatBan = 2018,  SoLuong = 26 },
                new Sach { MaSach = 17, Ten = "Người Bán Hàng Vĩ Đại Nhất Thế Giới",    TacGia = "Nguyễn Du",           TheLoai = "Giáo dục",       NXB = "NXB Giáo Dục",   NamXuatBan = 2016,  SoLuong = 31 },
                new Sach { MaSach = 18, Ten = "Vượt Lên Người Khổng Lồ",                TacGia = "Truyện Dân Gian",     TheLoai = "Tâm lý",         NXB = "NXB Tổng hợp",   NamXuatBan = 2007,  SoLuong = 19 },
                new Sach { MaSach = 19, Ten = "Bí Mật Của Phan Thiên Ân",               TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Tâm lý",         NXB = "NXB Văn Học",    NamXuatBan = 2014,  SoLuong = 35 },
                new Sach { MaSach = 20, Ten = "Totto-chan Bên Cửa Sổ",                  TacGia = "To Hoai",             TheLoai = "Thiếu nhi",      NXB = "NXB Giáo Dục",   NamXuatBan = 2003,  SoLuong = 40 },
                new Sach { MaSach = 21, Ten = "Muôn Kiếp Nhân Sinh",                    TacGia = "Nam Cao",             TheLoai = "Văn học",        NXB = "NXB Trẻ",        NamXuatBan = 2017,  SoLuong = 22 },
                new Sach { MaSach = 22, Ten = "Truyện Kiều",                            TacGia = "Nguyễn Du",           TheLoai = "Văn học",        NXB = "NXB Giáo Dục",   NamXuatBan = 2015,  SoLuong = 44 },
                new Sach { MaSach = 23, Ten = "Mắt Biếc",                               TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Truyện ngắn",    NXB = "NXB Kim Đồng",   NamXuatBan = 2008,  SoLuong = 39 },
                new Sach { MaSach = 24, Ten = "Đồi Gió Hú",                             TacGia = "Nguyễn Du",           TheLoai = "Tâm lý",         NXB = "NXB Văn Học",    NamXuatBan = 2006,  SoLuong = 18 },
                new Sach { MaSach = 25, Ten = "Những Tấm Lòng Cao Cả",                  TacGia = "Ngô Tất Tố",          TheLoai = "Giáo dục",       NXB = "NXB Giáo Dục",   NamXuatBan = 2009,  SoLuong = 23 },
                new Sach { MaSach = 26, Ten = "Con Đường Hồi Giáo",                     TacGia = "Truyện Dân Gian",     TheLoai = "Lịch sử",        NXB = "NXB Văn Học",    NamXuatBan = 2011,  SoLuong = 24 },
                new Sach { MaSach = 27, Ten = "Tự Truyện Lý Tiểu Long",                 TacGia = "Nguyễn Nhật Ánh",     TheLoai = "Lịch sử",        NXB = "NXB Tổng hợp",   NamXuatBan = 2002,  SoLuong = 12 },
                new Sach { MaSach = 28, Ten = "Bố Già",                                 TacGia = "Nguyễn Du",           TheLoai = "Tâm lý",         NXB = "NXB Trẻ",        NamXuatBan = 2013,  SoLuong = 27 },
                new Sach { MaSach = 29, Ten = "Thiên Tài Bên Trái, Kẻ Điên Bên Phải",   TacGia = "Nam Cao",             TheLoai = "Khoa học",       NXB = "NXB Giáo Dục",   NamXuatBan = 2023,  SoLuong = 33 },
                new Sach { MaSach = 30, Ten = "Cuốn Theo Chiều Gió",                    TacGia = "To Hoai",             TheLoai = "Văn học",        NXB = "NXB Tổng hợp",   NamXuatBan = 2001,  SoLuong = 21 }
            };
        }

        public static List<PhieuMuonTra> GetData_PhieuMuonTra()
        {
            return new List<PhieuMuonTra>
            {
                new PhieuMuonTra { MaPhieuMuonTra = 1,  MaDocGia = 1,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 2,  MaDocGia = 2,  NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 3,  MaDocGia = 3,  NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 4,  MaDocGia = 3,  NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 7).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 5,  MaDocGia = 3,  NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 13).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 6,  MaDocGia = 4,  NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 21).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 7,  MaDocGia = 4,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 6).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 8,  MaDocGia = 4,  NgayMuon = new DateTime(2025, 7, 2).Date, HanTra = new DateTime(2025, 7, 16).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 9,  MaDocGia = 5,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 16).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 10, MaDocGia = 5,  NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 15).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 11, MaDocGia = 5,  NgayMuon = new DateTime(2025, 7, 2).Date, HanTra = new DateTime(2025, 7, 16).Date, NgayTraThucTe = new DateTime(2025, 7, 18).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 12, MaDocGia = 6,  NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 5).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 13, MaDocGia = 6,  NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 14, MaDocGia = 6,  NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 10).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 15, MaDocGia = 7,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 9).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 16, MaDocGia = 7,  NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 17, MaDocGia = 7,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 12).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 18, MaDocGia = 8,  NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 17).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 19, MaDocGia = 9,  NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 5).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 20, MaDocGia = 9,  NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 21, MaDocGia = 10, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 20).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 22, MaDocGia = 10, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 12).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 23, MaDocGia = 11, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 24, MaDocGia = 12, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 9).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 25, MaDocGia = 13, NgayMuon = new DateTime(2025, 7, 2).Date, HanTra = new DateTime(2025, 7, 16).Date, NgayTraThucTe = new DateTime(2025, 7, 14).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 26, MaDocGia = 14, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 5).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 27, MaDocGia = 14, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 28, MaDocGia = 15, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 10).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 29, MaDocGia = 16, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 17).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 30, MaDocGia = 16, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 31, MaDocGia = 17, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 6).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 32, MaDocGia = 17, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 18).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 33, MaDocGia = 18, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 34, MaDocGia = 18, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 11).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 35, MaDocGia = 19, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 8).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 36, MaDocGia = 20, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 37, MaDocGia = 20, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 14).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 38, MaDocGia = 20, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 8).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 39, MaDocGia = 21, NgayMuon = new DateTime(2025, 7, 2).Date, HanTra = new DateTime(2025, 7, 16).Date, NgayTraThucTe = new DateTime(2025, 7, 12).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 40, MaDocGia = 21, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 41, MaDocGia = 22, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = new DateTime(2025, 7, 19).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 42, MaDocGia = 23, NgayMuon = new DateTime(2025, 7, 2).Date, HanTra = new DateTime(2025, 7, 16).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 43, MaDocGia = 24, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 7).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 44, MaDocGia = 24, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = new DateTime(2025, 7, 12).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 45, MaDocGia = 25, NgayMuon = new DateTime(2025, 7, 1).Date, HanTra = new DateTime(2025, 7, 15).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 46, MaDocGia = 26, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = null,                             DaTra = false },
                new PhieuMuonTra { MaPhieuMuonTra = 47, MaDocGia = 27, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 9).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 48, MaDocGia = 28, NgayMuon = new DateTime(2025, 7, 4).Date, HanTra = new DateTime(2025, 7, 18).Date, NgayTraThucTe = new DateTime(2025, 7, 6).Date,    DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 49, MaDocGia = 29, NgayMuon = new DateTime(2025, 7, 3).Date, HanTra = new DateTime(2025, 7, 17).Date, NgayTraThucTe = new DateTime(2025, 7, 10).Date,   DaTra = true },
                new PhieuMuonTra { MaPhieuMuonTra = 50, MaDocGia = 30, NgayMuon = new DateTime(2025, 7, 5).Date, HanTra = new DateTime(2025, 7, 19).Date, NgayTraThucTe = null,                             DaTra = false }
            };
        }

        public static List<ChiTietPhieuMuonTra> GetData_ChiTietPhieuMuonTra()
        {
            return new List<ChiTietPhieuMuonTra>
            {
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 1,  MaSach = 5,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 1,  MaSach = 12, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 2,  MaSach = 3,  SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 3,  MaSach = 1,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 3,  MaSach = 6,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 4,  MaSach = 7,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 4,  MaSach = 9,  SoLuongMuon = 4 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 5,  MaSach = 2,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 6,  MaSach = 4,  SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 7,  MaSach = 15, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 7,  MaSach = 16, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 8,  MaSach = 8,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 9,  MaSach = 11, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 10, MaSach = 10, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 11, MaSach = 6,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 12, MaSach = 5,  SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 13, MaSach = 14, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 14, MaSach = 13, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 15, MaSach = 18, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 16, MaSach = 7,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 17, MaSach = 20, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 18, MaSach = 1,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 19, MaSach = 2,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 20, MaSach = 9,  SoLuongMuon = 4 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 21, MaSach = 3,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 22, MaSach = 4,  SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 23, MaSach = 6,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 24, MaSach = 5,  SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 25, MaSach = 8,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 26, MaSach = 10, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 27, MaSach = 11, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 28, MaSach = 13, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 29, MaSach = 12, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 30, MaSach = 15, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 31, MaSach = 17, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 32, MaSach = 19, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 33, MaSach = 21, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 34, MaSach = 23, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 35, MaSach = 22, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 36, MaSach = 24, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 37, MaSach = 25, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 38, MaSach = 26, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 39, MaSach = 27, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 40, MaSach = 28, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 41, MaSach = 29, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 42, MaSach = 30, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 43, MaSach = 16, SoLuongMuon = 1 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 44, MaSach = 14, SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 45, MaSach = 18, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 46, MaSach = 7,  SoLuongMuon = 2 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 47, MaSach = 18, SoLuongMuon = 3 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 48, MaSach = 19, SoLuongMuon = 4 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 49, MaSach = 20, SoLuongMuon = 5 },
                new ChiTietPhieuMuonTra { MaPhieuMuonTra = 50, MaSach = 21, SoLuongMuon = 6 }
            };
        }
    }
}
