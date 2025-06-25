using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }
        public string Ten { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NXB { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public List<ChiTietPhieuMuonTra> ChiTietPhieuMuonTras { get; set; }
    }
}
