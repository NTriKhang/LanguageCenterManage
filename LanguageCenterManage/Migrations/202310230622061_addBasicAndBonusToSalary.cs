namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBasicAndBonusToSalary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalaryInfoes", "Basic", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SalaryInfoes", "Bonus", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SalaryInfoes", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalaryInfoes", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SalaryInfoes", "Bonus");
            DropColumn("dbo.SalaryInfoes", "Basic");
        }
    }
}
