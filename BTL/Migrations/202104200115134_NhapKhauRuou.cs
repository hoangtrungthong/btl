namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhapKhauRuou : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RuouXuatKhaus", "DonGia", c => c.Int(nullable: false));
            AddColumn("dbo.RuouXuatKhaus", "NguoiXuat", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "NguoiNhap", c => c.String());
            DropColumn("dbo.RuouXuatKhaus", "Price");
            DropColumn("dbo.RuouXuatKhaus", "Exporter");
            DropColumn("dbo.RuouXuatKhaus", "Inporter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RuouXuatKhaus", "Inporter", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "Exporter", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.RuouXuatKhaus", "NguoiNhap");
            DropColumn("dbo.RuouXuatKhaus", "NguoiXuat");
            DropColumn("dbo.RuouXuatKhaus", "DonGia");
        }
    }
}
