namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nhap_Khau_Ruou : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhapKhauRuous",
                c => new
                    {
                        IDRuou = c.Int(nullable: false),
                        MaRuou = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDRuou)
                .ForeignKey("dbo.RuouXuatKhaus", t => t.IDRuou)
                .Index(t => t.IDRuou);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhapKhauRuous", "IDRuou", "dbo.RuouXuatKhaus");
            DropIndex("dbo.NhapKhauRuous", new[] { "IDRuou" });
            DropTable("dbo.NhapKhauRuous");
        }
    }
}
