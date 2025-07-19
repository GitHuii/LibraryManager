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
                new TaiKhoan { UserName = "admin1", PassWord = "123456", Role = "Admin" },
                new TaiKhoan { UserName = "admin2", PassWord = "admin@2025", Role = "Admin" },
                new TaiKhoan { UserName = "manager1", PassWord = "manager123", Role = "Manager" },
                new TaiKhoan { UserName = "manager2", PassWord = "qwerty", Role = "Manager" },
                new TaiKhoan { UserName = "admin3", PassWord = "admin789", Role = "Admin" },
                new TaiKhoan { UserName = "manager3", PassWord = "m@2025", Role = "Manager" },
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

        public static List<PhieuMuon> GetData_PhieuMuon()
        {
            return new List<PhieuMuon>
            {
                
            };
        }

        public static List<ChiTietPhieuMuon> GetData_ChiTietPhieuMuon()
        {
            return new List<ChiTietPhieuMuon>
            {
                
            };
        }

        public static List<PhieuTra> GetData_PhieuTra()
        {
            return new List<PhieuTra>
            {
                
            };
        }

        public static List<ChiTietPhieuTra> GetData_ChiTietPhieuTra()
        {
            return new List<ChiTietPhieuTra>
            {
                
            };
        }

        public static List<PhieuPhat> GetData_PhieuPhat()
        {
            return new List<PhieuPhat>
            {
                new PhieuPhat { MaPhieuPhat = 1, MaDocGia = 1, NgayLap = new DateTime(2025, 1, 5), SoTienPhat = 15000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 2, MaDocGia = 2, NgayLap = new DateTime(2025, 1, 15), SoTienPhat = 20000, LyDo = "Làm hỏng sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 3, MaDocGia = 3, NgayLap = new DateTime(2025, 2, 1), SoTienPhat = 5000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 4, MaDocGia = 4, NgayLap = new DateTime(2025, 2, 12), SoTienPhat = 10000, LyDo = "Mất sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 5, MaDocGia = 5, NgayLap = new DateTime(2025, 3, 8), SoTienPhat = 25000, LyDo = "Làm hỏng sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 6, MaDocGia = 6, NgayLap = new DateTime(2025, 3, 17), SoTienPhat = 5000, LyDo = "Trả sách trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 7, MaDocGia = 7, NgayLap = new DateTime(2025, 4, 2), SoTienPhat = 30000, LyDo = "Không trả sách đầy đủ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 8, MaDocGia = 8, NgayLap = new DateTime(2025, 4, 20), SoTienPhat = 10000, LyDo = "Ghi chú sai thông tin", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 9, MaDocGia = 9, NgayLap = new DateTime(2025, 5, 9), SoTienPhat = 15000, LyDo = "Trả sách trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 10, MaDocGia = 10, NgayLap = new DateTime(2025, 5, 25), SoTienPhat = 20000, LyDo = "Làm hỏng sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 11, MaDocGia = 11, NgayLap = new DateTime(2025, 6, 3), SoTienPhat = 10000, LyDo = "Trả sách trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 12, MaDocGia = 12, NgayLap = new DateTime(2025, 6, 15), SoTienPhat = 20000, LyDo = "Mất sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 13, MaDocGia = 13, NgayLap = new DateTime(2025, 6, 29), SoTienPhat = 25000, LyDo = "Làm hỏng sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 14, MaDocGia = 14, NgayLap = new DateTime(2025, 7, 10), SoTienPhat = 30000, LyDo = "Không trả sách đầy đủ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 15, MaDocGia = 15, NgayLap = new DateTime(2025, 7, 21), SoTienPhat = 5000, LyDo = "Trả sách trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 16, MaDocGia = 16, NgayLap = new DateTime(2025, 8, 1), SoTienPhat = 15000, LyDo = "Làm hỏng sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 17, MaDocGia = 17, NgayLap = new DateTime(2025, 8, 12), SoTienPhat = 20000, LyDo = "Mất sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 18, MaDocGia = 18, NgayLap = new DateTime(2025, 8, 28), SoTienPhat = 10000, LyDo = "Ghi chú sai thông tin", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 19, MaDocGia = 19, NgayLap = new DateTime(2025, 9, 5), SoTienPhat = 15000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 20, MaDocGia = 20, NgayLap = new DateTime(2025, 9, 16), SoTienPhat = 30000, LyDo = "Không trả sách đầy đủ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 21, MaDocGia = 21, NgayLap = new DateTime(2025, 10, 2), SoTienPhat = 5000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 22, MaDocGia = 22, NgayLap = new DateTime(2025, 10, 11), SoTienPhat = 20000, LyDo = "Mất sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 23, MaDocGia = 23, NgayLap = new DateTime(2025, 10, 25), SoTienPhat = 25000, LyDo = "Làm hỏng sách", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 24, MaDocGia = 24, NgayLap = new DateTime(2025, 11, 3), SoTienPhat = 15000, LyDo = "Trả sách trễ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 25, MaDocGia = 25, NgayLap = new DateTime(2025, 11, 18), SoTienPhat = 10000, LyDo = "Ghi chú sai thông tin", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 26, MaDocGia = 26, NgayLap = new DateTime(2025, 11, 28), SoTienPhat = 5000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 27, MaDocGia = 27, NgayLap = new DateTime(2025, 12, 1), SoTienPhat = 30000, LyDo = "Không trả sách đầy đủ", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 28, MaDocGia = 28, NgayLap = new DateTime(2025, 12, 10), SoTienPhat = 15000, LyDo = "Trả sách trễ", DaThuTien = true },
                new PhieuPhat { MaPhieuPhat = 29, MaDocGia = 29, NgayLap = new DateTime(2025, 12, 18), SoTienPhat = 20000, LyDo = "Làm hỏng sách", DaThuTien = false },
                new PhieuPhat { MaPhieuPhat = 30, MaDocGia = 30, NgayLap = new DateTime(2025, 12, 26), SoTienPhat = 10000, LyDo = "Mất sách", DaThuTien = true },

            };
        }
    }
}
