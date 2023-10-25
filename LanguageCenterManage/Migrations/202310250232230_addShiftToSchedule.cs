namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addShiftToSchedule : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Schedules");
            AddColumn("dbo.Schedules", "Shift", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Schedules", new[] { "RoomId", "DateTime", "Shift" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Schedules");
            DropColumn("dbo.Schedules", "Shift");
            AddPrimaryKey("dbo.Schedules", new[] { "RoomId", "DateTime" });
        }
    }
}
