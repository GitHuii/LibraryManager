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
    public class ChiTietPhieuMuonTra
    {
        [DisplayName("Mã Phiếu Mượn Trả")]
        [ForeignKey("PhieuMuonTra")]
        public int MaPhieuMuonTra { get; set; }

        [ForeignKey("Sach")]
        [DisplayName("Mã Sách")]
        public int MaSach { get; set; }
        [DisplayName("Số Lượng Mượn")]
        public int SoLuongMuon { get; set; }
        
        public PhieuMuonTra PhieuMuonTra { get; set; }
        public Sach Sach { get; set; }
    }
}
