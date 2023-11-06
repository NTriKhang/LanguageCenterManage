namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editBillJoinModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Joins", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Joins", "StudentId", "dbo.Students");
            DropIndex("dbo.Joins", new[] { "ClassId" });
            DropIndex("dbo.Joins", new[] { "StudentId" });
            DropPrimaryKey("dbo.Joins");
            AddColumn("dbo.Bills", "JoinId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Joins", "ClassId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Joins", "StudentId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Joins", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Joins", "Id");
            CreateIndex("dbo.Bills", "JoinId");
            CreateIndex("dbo.Joins", "ClassId");
            CreateIndex("dbo.Joins", "StudentId");
            AddForeignKey("dbo.Bills", "JoinId", "dbo.Joins", "Id");
            AddForeignKey("dbo.Joins", "ClassId", "dbo.Classes", "Id");
            AddForeignKey("dbo.Joins", "StudentId", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Joins", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Joins", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Bills", "JoinId", "dbo.Joins");
            DropIndex("dbo.Joins", new[] { "StudentId" });
            DropIndex("dbo.Joins", new[] { "ClassId" });
            DropIndex("dbo.Bills", new[] { "JoinId" });
            DropPrimaryKey("dbo.Joins");
            AlterColumn("dbo.Joins", "Id", c => c.String());
            AlterColumn("dbo.Joins", "StudentId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Joins", "ClassId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Bills", "JoinId");
            AddPrimaryKey("dbo.Joins", new[] { "ClassId", "StudentId" });
            CreateIndex("dbo.Joins", "StudentId");
            CreateIndex("dbo.Joins", "ClassId");
            AddForeignKey("dbo.Joins", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Joins", "ClassId", "dbo.Classes", "Id", cascadeDelete: true);
        }
    }
}
