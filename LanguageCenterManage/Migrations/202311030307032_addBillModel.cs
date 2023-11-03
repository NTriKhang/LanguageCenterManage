namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBillModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalaryInfoes", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.SalaryInfoes", new[] { "TeacherId" });
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DatePay = c.DateTime(),
                        UserConfirmId = c.String(maxLength: 128),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserConfirmId)
                .Index(t => t.UserConfirmId);
            
            AddColumn("dbo.Joins", "BillId", c => c.String(maxLength: 128));
            //CreateIndex("dbo.Joins", "BillId", unique: true);
            AddForeignKey("dbo.Joins", "BillId", "dbo.Bills", "Id");
            DropColumn("dbo.Joins", "TuiTionState");
            DropTable("dbo.SalaryInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SalaryInfoes",
                c => new
                    {
                        TeacherId = c.String(nullable: false, maxLength: 128),
                        DatePay = c.DateTime(nullable: false),
                        Basic = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bonus = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.DatePay });
            
            AddColumn("dbo.Joins", "TuiTionState", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Joins", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "UserConfirmId", "dbo.Users");
            DropIndex("dbo.Joins", new[] { "BillId" });
            DropIndex("dbo.Bills", new[] { "UserConfirmId" });
            DropColumn("dbo.Joins", "BillId");
            DropTable("dbo.Bills");
            CreateIndex("dbo.SalaryInfoes", "TeacherId");
            AddForeignKey("dbo.SalaryInfoes", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
        }
    }
}
