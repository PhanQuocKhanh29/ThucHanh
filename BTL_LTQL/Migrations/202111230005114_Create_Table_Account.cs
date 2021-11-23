namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Account : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DoanVien");
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            AlterColumn("dbo.DoanVien", "MaDV", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.DoanVien", "MaDV");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.DoanVien");
            AlterColumn("dbo.DoanVien", "MaDV", c => c.String(nullable: false, maxLength: 128, unicode: false));
            DropTable("dbo.Accounts");
            AddPrimaryKey("dbo.DoanVien", "MaDV");
        }
    }
}
