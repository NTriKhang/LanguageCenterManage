using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
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
    public partial class RoomAvailableForm : MaterialForm
    {
        private AppDbContext _db;
        private DateTime _date;
        private int _shift;
        public string roomId { set; get; }
        public string roomName { set; get; }
        public RoomAvailableForm(DateTime date, int shift)
        {
            _db = new AppDbContext();
            _date = date;
            _shift = shift;
            InitializeComponent();
        }
        private void RoomAvailableForm_Load(object sender, EventArgs e)
        {
            var listRoom = (from room in _db.Rooms
                            where !(from schedule in _db.Schedules
                                    where schedule.DateTime == _date && schedule.Shift == _shift
                                    select schedule.RoomId)
                                    .Contains(room.Id)
                            select room)
                .OrderBy(x => x.Name)
                .ToList();

            roomBindingSource.DataSource = listRoom;
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
