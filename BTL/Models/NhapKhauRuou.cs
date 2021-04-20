using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("NhapKhauRuous")]
    public class NhapKhauRuou : RuouXuatKhau
    {
        [Key]
        public int MaRuou { get; set; }
    }
}