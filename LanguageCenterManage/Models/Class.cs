using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Class
    {
        [Key]
        public string Id { get; set; }  
        public string StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
        
        public string CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
        public decimal FirstGrade { get; set; }
        public decimal SecondGrade { get; set; }    
        public decimal FinalGrade { get; set; } 
        public decimal TuiTion { set; get; }
        public bool TuiTionState { set; get; }
    }
}
