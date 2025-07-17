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
    public class DocGia
    {
        [Key]
        [DisplayName("Mã Độc Giả")]
        public int MaDocGia { get; set; }

        [DisplayName("Tên Độc Giả")]
        public string? Ten { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Địa Chỉ")]
        public string? DiaChi { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string? SDT { get; set; }
        public List<PhieuMuon>? PhieuMuons { get; set; }
        public List<PhieuPhat>? PhieuThuTienPhats { get; set; }
    }
}
