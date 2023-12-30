namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusToJoin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Joins", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Joins", "Status");
        }
    }
}
