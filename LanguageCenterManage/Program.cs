using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LanguageCenterManage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitialDatabase();

            Application.Run(new MDIParent1());
        }

        static void InitialDatabase()
        {
            AppDbContext dbContext = new AppDbContext();

            if(dbContext.Roles.Count() == 0)
            {
                List<Role> roles = new List<Role>()
                {
                    new Role() {Id = Guid.NewGuid().ToString().Substring(0,8), Name = utility.Manager},
                    new Role() {Id = Guid.NewGuid().ToString().Substring(0,8), Name = utility.Employee},
                };
                dbContext.Roles.AddRange(roles);
                dbContext.SaveChanges();
            }

            if(dbContext.Users.Count() == 0)
            {
                var user = new User()
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 8),
                    Email = "sa@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("sa123"),
                    RoleId = dbContext.Roles.Where(x => x.Name == utility.Manager).Select(x => x.Id).SingleOrDefault(),
                    Birth = DateTime.Now,
                    FirstName = "sa",
                    LastName = "account"
                };
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
