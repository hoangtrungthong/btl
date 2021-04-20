using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL.Models
{
    public partial class KhoDbContext : DbContext
    {
        public KhoDbContext()
            : base("name=KhoDbContext")
        {
        }
        public virtual DbSet<KhoRuou> KhoRuous { get; set; }

        public virtual DbSet<RuouXuatKhau> RuouXuatKhaus { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<BTL.Models.DanhGia> DanhGias { get; set; }
    }
}
