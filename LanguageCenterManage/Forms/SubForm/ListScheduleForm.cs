using LanguageCenterManage.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms.SubForm
{
    public partial class ListScheduleForm : Form
    {
        List<ScheduleDTO> schedules;
        public ListScheduleForm(List<ScheduleDTO> scheduleDTOs)
        {
            InitializeComponent();
            this.schedules = scheduleDTOs;

            dataGridView1.DataSource = scheduleDTOs;
        }
    }
}
