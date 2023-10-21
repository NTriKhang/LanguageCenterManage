namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editCourseClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "TuiTion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Classes", "TuiTion");
            DropColumn("dbo.Courses", "Quanlity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Quanlity", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "TuiTion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Courses", "TuiTion");
            DropColumn("dbo.Classes", "Quantity");
        }
    }
}
