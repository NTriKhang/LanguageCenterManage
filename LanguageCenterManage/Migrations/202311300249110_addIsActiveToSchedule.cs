namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsActiveToSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "IsActive");
        }
    }
}
