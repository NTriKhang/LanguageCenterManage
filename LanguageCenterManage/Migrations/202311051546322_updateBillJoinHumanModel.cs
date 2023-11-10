namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBillJoinHumanModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Joins", "BillId", "dbo.Bills");
            DropIndex("dbo.Joins", new[] { "BillId" });
            AddColumn("dbo.Users", "ImagePath", c => c.String());
            AddColumn("dbo.Joins", "Id", c => c.String());
            AddColumn("dbo.Students", "ImagePath", c => c.String());
            AddColumn("dbo.Teachers", "ImagePath", c => c.String());
            DropColumn("dbo.Joins", "BillId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Joins", "BillId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Teachers", "ImagePath");
            DropColumn("dbo.Students", "ImagePath");
            DropColumn("dbo.Joins", "Id");
            DropColumn("dbo.Users", "ImagePath");
            CreateIndex("dbo.Joins", "BillId", unique: true);
            AddForeignKey("dbo.Joins", "BillId", "dbo.Bills", "Id", cascadeDelete: true);
        }
    }
}
