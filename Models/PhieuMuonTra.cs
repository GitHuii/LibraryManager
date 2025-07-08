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
    public class PhieuMuonTra
    {
        [Key]
        [DisplayName("Mã Phiếu Mượn Trả")]
        public int MaPhieuMuonTra { get; set; }

        [ForeignKey("DocGia")] 
        [DisplayName("Mã Độc Giả")]
        public int MaDocGia { get; set; }

        [DisplayName("Ngày Mượn")]
        public DateTime NgayMuon { get; set; }

        [DisplayName("Hạn Trả")]
        public DateTime HanTra { get; set; }

        [DisplayName("Ngày Trả Thực Tế")]
        public DateTime? NgayTraThucTe { get; set; }

        [DisplayName("Đã Trả Sách")]
        public bool DaTra { get; set; }
        public DocGia DocGia { get; set; }
        public List<ChiTietPhieuMuonTra> ChiTietPhieuMuonTras { get; set; }
    }
}
