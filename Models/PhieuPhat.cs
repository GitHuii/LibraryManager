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
    public class PhieuPhat
    {
        [Key]
        [DisplayName("Mã Phiếu Phạt")]
        public int MaPhieuPhat { get; set; }

        [ForeignKey("DocGia")]  
        [DisplayName("Mã Độc Giả")]
        public int MaDocGia { get; set; }

        [DisplayName("Ngày Lập")]
        public DateTime NgayLap { get; set; }

        [DisplayName("Số Tiền Phạt")]
        public decimal SoTienPhat { get; set; }

        [DisplayName("Lý Do")]
        public string LyDo { get; set; }

        [DisplayName("Đã Thu Tiền")]
        public bool DaThuTien { get; set; }
        public DocGia DocGia { get; set; }
    }
}
