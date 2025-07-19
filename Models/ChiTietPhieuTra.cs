using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class ChiTietPhieuTra
    {
        [DisplayName("Mã Phiếu Trả")]
        [ForeignKey("PhieuTra")]
        public int MaPhieuTra { get; set; }

        [ForeignKey("Sach")]
        [DisplayName("Mã Sách")]
        public int MaSach { get; set; }

        public Sach? Sach { get; set; }
        public PhieuTra? PhieuTra { get; set; }
    }
}
