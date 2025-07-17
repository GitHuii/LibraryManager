using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Sach
    {
        [Key]
        [Display(Name = "Mã Sách")]
        public int MaSach { get; set; }

        [Display(Name = "Tên Sách")]
        public string? Ten { get; set; }

        [Display(Name = "Tác Giả")]
        public string? TacGia { get; set; }

        [Display(Name = "Thể Loại")]
        public string? TheLoai { get; set; }

        [Display(Name = "Nhà Xuất Bản")]
        public string? NXB { get; set; }

        [Display(Name = "Năm Xuất Bản")]
        public int NamXuatBan { get; set; }

        [Display(Name = "Số Lượng")]
        public int SoLuong { get; set; }
        public List<ChiTietPhieuMuon>? ChiTietPhieuMuons { get; set; }
    }
}
