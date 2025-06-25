using System;
using System.Collections.Generic;
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
        public string MaPhieuPhat { get; set; }

        [ForeignKey("DocGia")]  
        public int MaDocGia { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal SoTienPhat { get; set; }
        public string LyDo { get; set; }
        public bool DaThuTien { get; set; }
        public DocGia DocGia { get; set; }
    }
}
