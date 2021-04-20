namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kho_Ruou : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhoRuous",
                c => new
                    {
                        IDRuou = c.Int(nullable: false, identity: true),
                        TenRuou = c.String(),
                        NongDo = c.Int(nullable: false),
                        DanhGia = c.String(),
                        TinhChat = c.String(),
                        NguonGoc = c.String(),
                    })
                .PrimaryKey(t => t.IDRuou);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhoRuous");
        }
    }
}
