using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }
        public DateTime? DatePay { get; set; }
        public string UserConfirmId { get; set; }
        [ForeignKey(nameof(UserConfirmId))]
        public User User { get; set; }
        public decimal Cost { get; set; }
        public bool State {  get; set; }
    }
}
