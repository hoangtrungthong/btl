using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL.Models
{
    [Table("DanhGias")]
    public class DanhGia
    {
        [Key]
        public int IDRuou { get; set; }
        [AllowHtml]
        public string NhanXet { get; set; }
    }
}