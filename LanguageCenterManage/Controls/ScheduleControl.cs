using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LanguageCenterManage.Forms;

namespace LanguageCenterManage.Controls
{
    public partial class ScheduleControl : UserControl
    {
        private AppDbContext _db;
        List<ScheduleDTO> ListSchedule;
        public ScheduleControl()
        {
            InitializeComponent();
            ListSchedule = new List<ScheduleDTO>();
        }
        private void LoadData()
        {
            scheduleDTOBindingSource.DataSource = null;
            _db = new AppDbContext();
            ListSchedule = _db.Schedules
                                  .OrderBy(x => x.DateTime)
                                  .Include(nameof(Schedule.Room))
                                  .Include(nameof(Schedule.Teacher))
                                  .Include(nameof(Schedule.Class))
                                  .Select(x => new ScheduleDTO
                                  {
                                      RoomName = x.Room.Name,
                                      RoomId = x.RoomId,
                                      DateTime = x.DateTime,
                                      Shift = x.Shift,
                                      CourseName = x.Class.Course.Name
                                  }).ToList();

            scheduleDTOBindingSource.DataSource = ListSchedule;
        }
        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            LoadData();
            Sort_Combobox.SelectedIndex = 0;
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            ScheduleDetailForm scheduleDetailForm = new ScheduleDetailForm();
            scheduleDetailForm.ShowDialog();
            scheduleDetailForm.FormClosed += scheduleDetailForm_Closed;
        }
        private void scheduleDetailForm_Closed(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Refresh();
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var schedule = (scheduleDTOBindingSource.DataSource as List<ScheduleDTO>).ElementAt(e.RowIndex);
            ScheduleDetailForm scheduleDetailForm = new ScheduleDetailForm(schedule.RoomId, schedule.DateTime, schedule.Shift);
            scheduleDetailForm.ShowDialog();
            scheduleDetailForm.FormClosed += scheduleDetailForm_Closed;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                ListSchedule = _db.Schedules
                                  .OrderBy(x => x.DateTime)
                                  .Include(nameof(Schedule.Room))
                                  .Include(nameof(Schedule.Teacher))
                                  .Include(nameof(Schedule.Class))
                                  .Select(x => new ScheduleDTO
                                  {
                                      RoomName = x.Room.Name,
                                      RoomId = x.RoomId,
                                      DateTime = x.DateTime,
                                      Shift = x.Shift,
                                      CourseName = x.Class.Course.Name
                                  })
                                  .Where(x => x.RoomId.Contains(searchString) ||
                                    x.RoomName.Contains(searchString) ||
                                    x.CourseName.Contains(searchString)
                                    ).ToList();
                dataGridView1.DataSource = ListSchedule;
            }
            else
            {
                LoadData();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListSchedule = ListSchedule.OrderBy(x => x.GetType()
                                         .GetProperty(value)
                                         .GetValue(x, null)).ToList();
                dataGridView1.DataSource = ListSchedule;
            }
            else
            {
                LoadData();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
