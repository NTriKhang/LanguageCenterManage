using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class SalaryInfo
    {
        [Key, Column(Order = 0)]
        public string TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        [Key, Column(Order = 1)]
        public DateTime DatePay { get; set; }
        public decimal Amount { get; set; }
    }
}
