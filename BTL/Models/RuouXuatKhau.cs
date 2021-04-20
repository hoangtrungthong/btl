using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("RuouXuatKhaus")]
    public class RuouXuatKhau : KhoRuou
    {
        [Key]

        public int DonGia { get; set; }
        public string NguoiXuat{ get; set; }
        public string NguoiNhap { get; set; }
    }
}