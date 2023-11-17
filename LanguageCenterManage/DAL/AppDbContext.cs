using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CenterConnectionString")
        {
            
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseType { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        //public DbSet<SalaryInfo> SalaryInfos { get; set;}
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Join> Joins { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Band> Bands { get; set; }
    }
}
