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
    public class PhieuMuon
    {
        [Key]
        [DisplayName("Mã Phiếu Mượn")]
        public int MaPhieuMuon { get; set; }

        [ForeignKey("DocGia")] 
        [DisplayName("Mã Độc Giả")]
        public int MaDocGia { get; set; }

        [DisplayName("Ngày Mượn")]
        public DateTime NgayMuon { get; set; }

        [DisplayName("Hạn Trả")]
        public DateTime HanTra { get; set; }

        public DocGia? DocGia { get; set; }
        public List<ChiTietPhieuMuon>? ChiTietPhieuMuons { get; set; }
        public List<PhieuTra>? PhieuTras { get; set; }
    }
}
