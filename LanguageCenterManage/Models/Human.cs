using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Human
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime Birth { get; set; }
        public string Phone { set; get; }
    }
}
