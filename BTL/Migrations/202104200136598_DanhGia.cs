namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DanhGia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhGias",
                c => new
                    {
                        IDRuou = c.Int(nullable: false, identity: true),
                        NhanXet = c.String(),
                    })
                .PrimaryKey(t => t.IDRuou);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhGias");
        }
    }
}
