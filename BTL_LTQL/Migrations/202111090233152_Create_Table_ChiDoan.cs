namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ChiDoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiDoan",
                c => new
                    {
                        IDChiDoan = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenChiDoan = c.String(),
                    })
                .PrimaryKey(t => t.IDChiDoan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChiDoan");
        }
    }
}
