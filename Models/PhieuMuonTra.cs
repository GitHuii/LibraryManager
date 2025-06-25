using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class PhieuMuonTra
    {
        [Key]
        public int MaPhieuMuonTra { get; set; }

        [ForeignKey("DocGia")]
        public int MaDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DocGia DocGia { get; set; }
        public List<ChiTietPhieuMuonTra> ChiTietPhieuMuonTras { get; set; }
    }
}
