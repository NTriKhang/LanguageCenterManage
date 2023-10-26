using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Models
{
    public class Schedule
    {
        [Key, Column(Order = 0)]
        public string RoomId { set; get; }
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; }
        [Key, Column(Order = 1)]
        public DateTime DateTime { set; get; }
        [Key, Column(Order = 2)]
        public int Shift { set; get; }

        public string TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public string ClassId { set; get; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; }

    }
}
