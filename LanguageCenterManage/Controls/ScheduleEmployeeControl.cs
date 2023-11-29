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
    public partial class ScheduleEmployeeControl : UserControl
    {
        AppDbContext _db;
        List<ScheduleDTO> ListSchedule;
        public ScheduleEmployeeControl()
        {
            InitializeComponent();
            ListSchedule = new List<ScheduleDTO>();
        }
        private void LoadData()
        {
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter RoomID")
            {
                txtSearch.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                ListSchedule = _db.Schedules
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
                    .Where(
                    x => x.RoomId.Contains(searchString) ||
                    x.RoomName.Contains(searchString) ||
                    x.CourseName.Contains(searchString)
                ).ToList();
                scheduleDTOBindingSource.DataSource = ListSchedule;
            }
            else
            {
                LoadData();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }

        private void ScheduleEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadData();
            Sort_Combobox.SelectedIndex = 0;
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
