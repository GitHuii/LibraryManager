using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class ChiTietPhieuMuonTra
    {
        [Key]
        public int MaChiTietPhieuMuon { get; set; }
        [ForeignKey("PhieuMuonTra")]
        public int MaPhieuMuonTra { get; set; }
        [ForeignKey("Sach")]
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        
        public PhieuMuonTra PhieuMuonTra { get; set; }
        public Sach Sach { get; set; }
    }
}
