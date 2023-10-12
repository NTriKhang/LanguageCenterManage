namespace LanguageCenterManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StudentId = c.String(maxLength: 128),
                        CourseId = c.String(maxLength: 128),
                        FirstGrade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SecondGrade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalGrade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TuiTion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TuiTionState = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        Quanlity = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        LanguageId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Languages", t => t.LanguageId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalaryInfoes",
                c => new
                    {
                        TeacherId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        DatePay = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.UserId, t.DatePay })
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PasswordHash = c.String(),
                        RoleId = c.String(maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        RoomId = c.String(nullable: false, maxLength: 128),
                        DateTime = c.DateTime(nullable: false),
                        TeacherId = c.String(maxLength: 128),
                        ClassId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoomId, t.DateTime })
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.RoomId)
                .Index(t => t.TeacherId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Schedules", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Schedules", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.SalaryInfoes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.SalaryInfoes", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Classes", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Classes", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Schedules", new[] { "ClassId" });
            DropIndex("dbo.Schedules", new[] { "TeacherId" });
            DropIndex("dbo.Schedules", new[] { "RoomId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.SalaryInfoes", new[] { "UserId" });
            DropIndex("dbo.SalaryInfoes", new[] { "TeacherId" });
            DropIndex("dbo.Courses", new[] { "LanguageId" });
            DropIndex("dbo.Classes", new[] { "CourseId" });
            DropIndex("dbo.Classes", new[] { "StudentId" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Users");
            DropTable("dbo.Teachers");
            DropTable("dbo.SalaryInfoes");
            DropTable("dbo.Rooms");
            DropTable("dbo.Roles");
            DropTable("dbo.Students");
            DropTable("dbo.Languages");
            DropTable("dbo.Courses");
            DropTable("dbo.Classes");
        }
    }
}
