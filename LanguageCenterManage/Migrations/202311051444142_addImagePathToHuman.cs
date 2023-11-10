namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImagePathToHuman : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImagePath", c => c.String());
            AddColumn("dbo.Students", "ImagePath", c => c.String());
            AddColumn("dbo.Teachers", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "ImagePath");
            DropColumn("dbo.Students", "ImagePath");
            DropColumn("dbo.Users", "ImagePath");
        }
    }
}
