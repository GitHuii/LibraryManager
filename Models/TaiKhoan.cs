﻿using System;
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
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
