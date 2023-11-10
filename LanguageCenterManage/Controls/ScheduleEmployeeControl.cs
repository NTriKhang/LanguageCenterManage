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
        public ScheduleEmployeeControl()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            _db = new AppDbContext();
            var listSchedule = _db.Schedules
                                  .OrderBy(x => x.DateTime)
                                  .Include(nameof(Schedule.Room))
                                  .Include(nameof(Schedule.Teacher))
                                  .Include(nameof(Schedule.Class))
                                  .Select(x => new ScheduleDTO
                                  {
                                      RoomId = x.RoomId,
                                      DateTime = x.DateTime,
                                      Shift = x.Shift,
                                  }).ToList();

            scheduleDTOBindingSource.DataSource = listSchedule;
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
                var listStudent = _db.Schedules.Where(
                    x => x.RoomId.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = listStudent;
            }
            else
            {
                LoadData();
            }
        }

        private void ScheduleEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
