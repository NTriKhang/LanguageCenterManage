using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.DTO
{
    public class CourseDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseType { get; set; }
        public double Band {  get; set; }
        public string Status { get; set; }
    }
}
