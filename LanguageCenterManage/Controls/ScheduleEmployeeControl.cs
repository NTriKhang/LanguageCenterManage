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
using System.Diagnostics;

namespace LanguageCenterManage.Controls
{
    public partial class ScheduleEmployeeControl : UserControl
    {
        AppDbContext _db;
        List<ScheduleDTO> ListSchedule;
        Dictionary<string, Button> CalenderButtons;
        public ScheduleEmployeeControl()
        {
            InitializeComponent();
            ListSchedule = new List<ScheduleDTO>();
            LoadCalendarButtons();
        }
        private void LoadCalendarButtons()
        {
            CalenderButtons = new Dictionary<string, Button>();
            CalenderButtons.Add(Monday1.Name, Monday1);
            CalenderButtons.Add(Monday2.Name, Monday2);
            CalenderButtons.Add(Monday3.Name, Monday3);
            CalenderButtons.Add(Monday4.Name, Monday4);
            CalenderButtons.Add(Monday5.Name, Monday5);

            CalenderButtons.Add(Tuesday1.Name, Tuesday1);
            CalenderButtons.Add(Tuesday2.Name, Tuesday2);
            CalenderButtons.Add(Tuesday3.Name, Tuesday3);
            CalenderButtons.Add(Tuesday4.Name, Tuesday4);
            CalenderButtons.Add(Tuesday5.Name, Tuesday5);

            CalenderButtons.Add(Wednesday1.Name, Wednesday1);
            CalenderButtons.Add(Wednesday2.Name, Wednesday2);
            CalenderButtons.Add(Wednesday3.Name, Wednesday3);
            CalenderButtons.Add(Wednesday4.Name, Wednesday4);
            CalenderButtons.Add(Wednesday5.Name, Wednesday5);

            CalenderButtons.Add(Thursday1.Name, Thursday1);
            CalenderButtons.Add(Thursday2.Name, Thursday2);
            CalenderButtons.Add(Thursday3.Name, Thursday3);
            CalenderButtons.Add(Thursday4.Name, Thursday4);
            CalenderButtons.Add(Thursday5.Name, Thursday5);

            CalenderButtons.Add(Friday1.Name, Friday1);
            CalenderButtons.Add(Friday2.Name, Friday2);
            CalenderButtons.Add(Friday3.Name, Friday3);
            CalenderButtons.Add(Friday4.Name, Friday4);
            CalenderButtons.Add(Friday5.Name, Friday5);

            CalenderButtons.Add(Saturday1.Name, Saturday1);
            CalenderButtons.Add(Saturday2.Name, Saturday2);
            CalenderButtons.Add(Saturday3.Name, Saturday3);
            CalenderButtons.Add(Saturday4.Name, Saturday4);
            CalenderButtons.Add(Saturday5.Name, Saturday5);

            CalenderButtons.Add(Sunday1.Name, Sunday1);
            CalenderButtons.Add(Sunday2.Name, Sunday2);
            CalenderButtons.Add(Sunday3.Name, Sunday3);
            CalenderButtons.Add(Sunday4.Name, Sunday4);
            CalenderButtons.Add(Sunday5.Name, Sunday5);
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
                                      CourseName = x.Class.Course.Name,
                                      IsActive = x.IsActive,
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
                        CourseName = x.Class.Course.Name,
                        IsActive = x.IsActive
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
        private void InitialCalendar()
        {
            var dayOfWeek = DateTime.Now.Date.DayOfWeek;
            int i = 0;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                i++;
                dayOfWeek = DateTime.Now.AddDays(-i).DayOfWeek;
            }
            var mondayDateOfWeek = DateTime.Now.AddDays(-i);
            LoadCalendar(mondayDateOfWeek);
        }
        private void ScheduleEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadData();
            InitialCalendar();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private DateTime GetMondayDateOfWeek(DateTime date)
        {
            var dayOfWeek = date.DayOfWeek;
            Debug.WriteLine(dayOfWeek);

            int modifyDay = 0;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                modifyDay++;
                dayOfWeek = date.AddDays(-modifyDay).DayOfWeek;
            }
            return date.AddDays(-modifyDay);
        }
        private void ClearCalendar()
        {
            var date = GetMondayDateOfWeek(DateTime.Now.Date);
            var dayOfWeek = DayOfWeek.Monday;
            while (dayOfWeek != DayOfWeek.Sunday)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var btnName = date.DayOfWeek.ToString() + "" + i.ToString();
                    var btn = CalenderButtons[btnName];

                    btn.Text = string.Empty;

                }
                date = date.AddDays(1);
                dayOfWeek = date.DayOfWeek;

            }
        }
        private void LoadCalendar(DateTime mondayDateOfWeek)
        {
            var calendarList = ListSchedule.Where(x => x.DateTime >= mondayDateOfWeek && x.DateTime < mondayDateOfWeek.AddDays(7));
            foreach (var calendar in calendarList)
            {
                Debug.WriteLine(calendar.DateTime);
                var nameBtn = calendar.DateTime.DayOfWeek.ToString() + "" + calendar.Shift.ToString();
                var btn = CalenderButtons[nameBtn];
                if (!calendar.IsActive)
                {
                    btn.Text += "Close - ";
                }
                btn.Text += calendar.RoomName + ' ' + calendar.CourseName + ' ' + calendar.DateTime.ToString("dd/MM/yyyy") + '\n';

            }
        }

        private void BasicRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BasicRBtn.Checked)
            {
                dataGridView1.Visible = true;
                tableLayoutPanel1.Visible = false;
            }
        }

        private void Calender_CheckedChanged(object sender, EventArgs e)
        {
            if (Calender.Checked)
            {
                dataGridView1.Visible = false;
                tableLayoutPanel1.Visible = true;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ClearCalendar();
            var date = GetMondayDateOfWeek(dateTimePicker1.Value);
            Debug.WriteLine(date);
            LoadCalendar(date.Date);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
