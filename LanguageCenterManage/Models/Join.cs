﻿using System;
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
        [Key]
        public string Id { get; set; }
        public string ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; }
        public string StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
        public decimal FirstGrade { get; set; }
        public decimal SecondGrade { get; set; }
        public decimal FinalGrade { get; set; }
        public string Status { get; set; }
    }
}
