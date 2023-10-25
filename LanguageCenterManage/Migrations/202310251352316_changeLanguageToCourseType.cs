namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeLanguageToCourseType : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Languages", newName: "CourseTypes");
            AddColumn("dbo.Courses", "Band", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Band");
            RenameTable(name: "dbo.CourseTypes", newName: "Languages");
        }
    }
}
