namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XuatKhau : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RuouXuatKhaus", "IDRuou", "dbo.KhoRuous");
            DropForeignKey("dbo.NhapKhauRuous", "IDRuou", "dbo.RuouXuatKhaus");
            DropIndex("dbo.RuouXuatKhaus", new[] { "IDRuou" });
            DropPrimaryKey("dbo.RuouXuatKhaus");
            CreateTable(
                "dbo.KhoRuous",
                c => new
                    {
                        IDRuou = c.Int(nullable: false, identity: true),
                        TenRuou = c.String(),
                        NongDo = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonVi_Chai = c.String(),
                        DanhGia = c.String(),
                        TinhChat = c.String(),
                        NguonGoc = c.String(),
                    })
                .PrimaryKey(t => t.IDRuou);
            
            AddColumn("dbo.RuouXuatKhaus", "TenRuou", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "NongDo", c => c.Int(nullable: false));
            AddColumn("dbo.RuouXuatKhaus", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.RuouXuatKhaus", "DonVi_Chai", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "DanhGia", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "TinhChat", c => c.String());
            AddColumn("dbo.RuouXuatKhaus", "NguonGoc", c => c.String());
            AlterColumn("dbo.RuouXuatKhaus", "IDRuou", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RuouXuatKhaus", "IDRuou");
            AddForeignKey("dbo.NhapKhauRuous", "IDRuou", "dbo.RuouXuatKhaus", "IDRuou");
            DropTable("dbo.KhoRuous");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KhoRuous",
                c => new
                    {
                        IDRuou = c.Int(nullable: false, identity: true),
                        TenRuou = c.String(),
                        NongDo = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonVi_Chai = c.String(),
                        DanhGia = c.String(),
                        TinhChat = c.String(),
                        NguonGoc = c.String(),
                    })
                .PrimaryKey(t => t.IDRuou);
            
            DropForeignKey("dbo.NhapKhauRuous", "IDRuou", "dbo.RuouXuatKhaus");
            DropPrimaryKey("dbo.RuouXuatKhaus");
            AlterColumn("dbo.RuouXuatKhaus", "IDRuou", c => c.Int(nullable: false));
            DropColumn("dbo.RuouXuatKhaus", "NguonGoc");
            DropColumn("dbo.RuouXuatKhaus", "TinhChat");
            DropColumn("dbo.RuouXuatKhaus", "DanhGia");
            DropColumn("dbo.RuouXuatKhaus", "DonVi_Chai");
            DropColumn("dbo.RuouXuatKhaus", "SoLuong");
            DropColumn("dbo.RuouXuatKhaus", "NongDo");
            DropColumn("dbo.RuouXuatKhaus", "TenRuou");
            DropTable("dbo.KhoRuous");
            AddPrimaryKey("dbo.RuouXuatKhaus", "IDRuou");
            CreateIndex("dbo.RuouXuatKhaus", "IDRuou");
            AddForeignKey("dbo.NhapKhauRuous", "IDRuou", "dbo.RuouXuatKhaus", "IDRuou");
            AddForeignKey("dbo.RuouXuatKhaus", "IDRuou", "dbo.KhoRuous", "IDRuou");
        }
    }
}
