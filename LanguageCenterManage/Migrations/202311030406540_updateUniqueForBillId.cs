namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUniqueForBillId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Joins", "BillId", "dbo.Bills");
            DropIndex("dbo.Joins", new[] { "BillId" });
            AlterColumn("dbo.Joins", "BillId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Joins", "BillId", unique: true);
            AddForeignKey("dbo.Joins", "BillId", "dbo.Bills", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Joins", "BillId", "dbo.Bills");
            DropIndex("dbo.Joins", new[] { "BillId" });
            AlterColumn("dbo.Joins", "BillId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Joins", "BillId");
            AddForeignKey("dbo.Joins", "BillId", "dbo.Bills", "Id");
        }
    }
}
