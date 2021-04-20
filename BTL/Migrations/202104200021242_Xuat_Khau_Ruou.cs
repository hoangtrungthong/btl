namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Xuat_Khau_Ruou : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RuouXuatKhaus",
                c => new
                    {
                        IDRuou = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Exporter = c.String(),
                        Inporter = c.String(),
                    })
                .PrimaryKey(t => t.IDRuou)
                .ForeignKey("dbo.KhoRuous", t => t.IDRuou)
                .Index(t => t.IDRuou);
            
            AddColumn("dbo.KhoRuous", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.KhoRuous", "DonVi_Chai", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RuouXuatKhaus", "IDRuou", "dbo.KhoRuous");
            DropIndex("dbo.RuouXuatKhaus", new[] { "IDRuou" });
            DropColumn("dbo.KhoRuous", "DonVi_Chai");
            DropColumn("dbo.KhoRuous", "SoLuong");
            DropTable("dbo.RuouXuatKhaus");
        }
    }
}
