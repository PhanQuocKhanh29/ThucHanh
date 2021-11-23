namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DoanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoanVien",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenDV = c.String(),
                        NgaySinh = c.String(),
                        QueQuan = c.String(),
                        GioiTinh = c.String(),
                        NgayvaoDoan = c.String(),
                        IDChiDoan = c.String(),
                    })
                .PrimaryKey(t => t.MaDV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DoanVien");
        }
    }
}
