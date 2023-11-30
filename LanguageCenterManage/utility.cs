using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage
{
    public class utility
    {
        public static string CourseOpen { get; } = "Open";
        public static string CourseProcessing { get; } = "Processing";
        public static string CourseClose { get; } = "Close";

        public static string Admin = "Admin";
        public static string Manager = "Manager";
        public static string Employee = "Employee";
    }
    public static class USER
    {
        public static string UserId { get; set; }
        public static string FirstName { get; set;}
        public static string LastName { get; set; }
        public static string Email { get; set; }
    }
}
