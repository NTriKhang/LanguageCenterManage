using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.DTO
{
    public class ClassDTO
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
    }
}
