using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class TaiKhoan
    {
        [Key]
        [Display(Name = "Tài Khoản")]
        public string? UserName { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string? PassWord { get; set; }

        [Display(Name = "Phân Quyền")]
        public string? Role { get; set; }
    }
}
