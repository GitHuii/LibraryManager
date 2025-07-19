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
    public class PhieuTra
    {
        [Key]
        [DisplayName("Mã Phiếu Trả")]
        public int MaPhieuTra { get; set; }

        [ForeignKey("PhieuMuon")]
        [DisplayName("Mã Phiếu Mượn")]
        public int MaPhieuMuon { get; set; }

        [DisplayName("Ngày Trả")]
        public DateTime? NgayTra { get; set; }

        public List<ChiTietPhieuTra>? ChiTietPhieuTras { get; set; }
        public PhieuMuon? PhieuMuon { get; set; }
    }
}
