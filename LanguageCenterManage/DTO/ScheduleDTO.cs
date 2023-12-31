﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.DTO
{
    public class ScheduleDTO
    {
        public string RoomId { get; set; }
        public string RoomName { get; set; }
        public DateTime DateTime { get; set; }
        public string CourseName { get; set; }
        public int Shift { get; set; }
        public bool IsActive { get; set; }
    }
}
