using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Course
    {
        [Key]
        public string Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int Quanlity { set; get; }   
        public DateTime DateStart { set; get; }
        public DateTime DateEnd { set; get; }
        public string LanguageId { set; get; }
        [ForeignKey(nameof(LanguageId))]
        public Language Language { set; get; }
        public string Status { set; get; } 
    }
}
