namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyRelationBetweenJoinAndBill : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Joins", "BillId", "dbo.Bills");
            DropIndex("dbo.Joins", new[] { "BillId" });
            AddColumn("dbo.Joins", "Id", c => c.String());
            DropColumn("dbo.Joins", "BillId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Joins", "BillId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Joins", "Id");
            CreateIndex("dbo.Joins", "BillId", unique: true);
            AddForeignKey("dbo.Joins", "BillId", "dbo.Bills", "Id", cascadeDelete: true);
        }
    }
}
