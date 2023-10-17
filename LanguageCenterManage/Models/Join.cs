using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Join
    {
        [Key, Column(Order = 0)]
        public string ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; }
        [Key, Column(Order = 1)]
        public string StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
        public decimal FirstGrade { get; set; }
        public decimal SecondGrade { get; set; }
        public decimal FinalGrade { get; set; }
        public bool TuiTionState { set; get; }

    }
}
