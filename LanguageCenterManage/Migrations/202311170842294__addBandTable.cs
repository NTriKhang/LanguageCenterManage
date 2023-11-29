namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _addBandTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BandNumber = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CourseTypeId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourseTypes", t => t.CourseTypeId)
                .Index(t => t.CourseTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bands", "CourseTypeId", "dbo.CourseTypes");
            DropIndex("dbo.Bands", new[] { "CourseTypeId" });
            DropTable("dbo.Bands");
        }
    }
}
