using LanguageCenterManage.DAL;
using LanguageCenterManage.Forms.SubForm;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms
{
    public partial class ScheduleDetailForm : MaterialForm
    {
        private AppDbContext _db;
        private Schedule _schedule;
        public ScheduleDetailForm()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }
        public ScheduleDetailForm(string roomId, DateTime date, int shift)
        {
            _db = new AppDbContext();
            _schedule = _db.Schedules.Where(x => x.RoomId == roomId && x.DateTime == date && x.Shift == shift).FirstOrDefault();

            InitializeComponent();
        }

        private void ShowRoomBtn_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.Date;
            var shift = Convert.ToInt16(ShiftTxt.Text);
            RoomAvailableForm roomAvailableForm = new RoomAvailableForm(date, shift);
            roomAvailableForm.ShowDialog();
            RoomIdTxt.Text = roomAvailableForm.roomId;
            roomNameTxt.Text = roomAvailableForm.roomName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule()
            {
                RoomId = RoomIdTxt.Text,
                ClassId = ClassIdCb.Text,
                TeacherId = TeacherCb.Text,
                DateTime = dateTimePicker1.Value.Date,
                Shift = Convert.ToInt32(ShiftTxt.Text),
            };
            _db.Schedules.Add(schedule);
            _db.SaveChanges();
        }

        private void ScheduleDetailForm_Load(object sender, EventArgs e)
        {
            ClassIdCb.Items.AddRange(_db.Classes.Include(nameof(Class.Course))
                                                .Where(x => x.Course.Status == utility.CourseOpen)
                                                .Select(x => x.Id)
                                                .ToArray());
            TeacherCb.Items.AddRange(_db.Teachers.Select(x => x.Id).ToArray());
            if(_schedule == null)
            {
                DeleteBtn.Visible = false;
                UpdateBtn.Visible = false;
                ShiftTxt.Text = "1";
            }
            else
            {
                btnAdd.Visible = false;
                dateTimePicker1.Value = _schedule.DateTime;
                ShiftTxt.Text = _schedule.Shift.ToString();
                RoomIdTxt.Text = _schedule.RoomId;
                roomNameTxt.Text = _db.Rooms.Where(x => x.Id == _schedule.RoomId).Select(x => x.Name).SingleOrDefault();
                CourseNameTxt.Text = _db.Classes.Where(x => x.Id == _schedule.RoomId)
                                                .Include(x => x.Course)
                                                .Select(x => x.Course.Name)
                                                .SingleOrDefault();
                ClassIdCb.Text = _schedule.ClassId;
                TeacherCb.Text = _schedule.TeacherId;
                TeacherNametxt.Text = _db.Teachers.Where(x => x.Id == _schedule.TeacherId)
                                                    .Select(x => x.FirstName + " " + x.LastName).SingleOrDefault();
            }
        }

        private void ClassIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassIdtxt.Text = _db.Classes.Where(x => x.Id == ClassIdCb.Text)
            CourseNameTxt.Text = _db.Classes.Where(x => x.Id == ClassIdCb.Text)
                                            .Include(x => x.Course)
                                            .Select(x => x.Course.Name)
                                            .SingleOrDefault();
        }

        private void TeacherCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherNametxt.Text = _db.Teachers.Where(x => x.Id == TeacherCb.Text)
                                                .Select(x => x.FirstName + " " + x.LastName).SingleOrDefault();
        }

        private void ClassIdCb_DropDown(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _db.Schedules.Remove(_schedule);
                _db.SaveChanges();
                Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _schedule.RoomId = RoomIdTxt.Text;
            _schedule.ClassId = ClassIdCb.Text;
            _schedule.TeacherId = TeacherCb.Text;
            _schedule.DateTime = dateTimePicker1.Value.Date;
            _schedule.Shift = Convert.ToInt32(ShiftTxt.Text);
            _db.SaveChanges();
        }
    }
}
