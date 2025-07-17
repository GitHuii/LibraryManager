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
    public class ChiTietPhieuMuon
    {
        [DisplayName("Mã Phiếu Mượn")]
        [ForeignKey("PhieuMuon")]
        public int MaPhieuMuon { get; set; }

        [ForeignKey("Sach")]
        [DisplayName("Mã Sách")]
        public int MaSach { get; set; }
        [DisplayName("Số Lượng Mượn")]
        public int SoLuongMuon { get; set; }

        [DisplayName("Đã Trả")]
        public bool DaTra { get; set; }
        public PhieuMuon? PhieuMuon { get; set; }
        public Sach? Sach { get; set; }
    }
}
