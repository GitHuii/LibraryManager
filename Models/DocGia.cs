using System;
using System.Collections.Generic;
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
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDocGia { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public List<PhieuMuonTra> PhieuMuonTras { get; set; }
        public List<PhieuPhat> PhieuThuTienPhats { get; set; }
    }
}
