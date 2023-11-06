using LanguageCenterManage.DAL;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace LanguageCenterManage.Forms.SubForm
{
    public partial class RoomAvailableForm : MaterialForm
    {
        private AppDbContext _db;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private int _shift;
        private List<string> DatesOfWeek;
        private bool status = false;
        public string roomId { set; get; }
        public string roomName { set; get; }

        public RoomAvailableForm(DateTime date, int shift)
        {
            _db = new AppDbContext();
            _dateStart = date;
            _shift = shift;
            InitializeComponent();
        }
        public RoomAvailableForm(DateTime dateStart, DateTime dateEnd, int shift, List<string> DateOfWeek)
        {
            _db = new AppDbContext();
            _dateStart = dateStart;
            _dateEnd = dateEnd;
            _shift = shift;
            this.DatesOfWeek = DateOfWeek;
            status = true;
            InitializeComponent();
        }
        private void RoomAvailableForm_Load(object sender, EventArgs e)
        {
            if (status == false)
            {
                var listRoom = (from room in _db.Rooms
                                where !(from schedule in _db.Schedules
                                        where schedule.DateTime == _dateStart && schedule.Shift == _shift
                                        select schedule.RoomId)
                                        .Contains(room.Id)
                                select room)
                .OrderBy(x => x.Name)
                .ToList();

                roomBindingSource.DataSource = listRoom;
            }
            else
            {
                var room = _db.Rooms.AsNoTracking().ToList();
                for (DateTime date = _dateStart; date <= _dateEnd; date = date.AddDays(1))
                {
                    var dateOfWeek = date.DayOfWeek.ToString();
                    if (DatesOfWeek.Contains(dateOfWeek))
                    {
                        var roomNotAvailable = _db.Schedules.Where(x => x.DateTime == date && x.Shift == _shift)
                                                            .Select(x => x.RoomId)                                
                                                            .AsNoTracking()
                                                            .ToList();

                        room = room.Where(x => !roomNotAvailable.Contains(x.Id)).ToList();

                    }
                }
                roomBindingSource.DataSource = room.OrderBy(x => x.Name).ToList();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var room = (roomBindingSource.DataSource as List<Room>).ElementAt(e.RowIndex);
            roomName = room.Name;
            roomId = room.Id;
            Close();
        }
    }
}
