using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class User : Human
    {
        public string PasswordHash { set; get; }
        public string RoleId { set; get; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
    }
}
