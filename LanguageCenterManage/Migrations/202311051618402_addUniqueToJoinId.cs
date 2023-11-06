namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUniqueToJoinId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "JoinId", "dbo.Joins");
            DropIndex("dbo.Bills", new[] { "JoinId" });
            AlterColumn("dbo.Bills", "JoinId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Bills", "JoinId", unique: true);
            AddForeignKey("dbo.Bills", "JoinId", "dbo.Joins", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "JoinId", "dbo.Joins");
            DropIndex("dbo.Bills", new[] { "JoinId" });
            AlterColumn("dbo.Bills", "JoinId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Bills", "JoinId");
            AddForeignKey("dbo.Bills", "JoinId", "dbo.Joins", "Id");
        }
    }
}
