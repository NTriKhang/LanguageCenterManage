using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class CourseType
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
