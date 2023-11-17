using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
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

namespace LanguageCenterManage.Controls
{
    public partial class RoomControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        List<Room> ListRoom;
        public RoomControl()
        {
            InitializeComponent();
            ListRoom = new List<Room>();
        }
        void LoadRoom()
        {
            ListRoom = db.Rooms.AsNoTracking().ToList();
            roomBindingSource.DataSource = ListRoom;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RoomDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRoom();
            dataGridView1.Refresh();
        }
        private void RoomControl_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var roomDetailForm = new RoomDetailForm();
            roomDetailForm.Id = null;
            roomDetailForm.FormClosed += RoomDetailForm_FormClosed;
            roomDetailForm.ShowDialog();
        }
        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            var RoomSelectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var roomDetailForm = new RoomDetailForm();
            roomDetailForm.Id = RoomSelectedId;
            roomDetailForm.FormClosed += RoomDetailForm_FormClosed;
            roomDetailForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (searchString != null)
            {
                ListRoom = db.Rooms.Where(
                    x => x.Id.Contains(searchString) ||
                    x.Name.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = ListRoom;
            }
            else
            {
                LoadRoom();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListRoom = ListRoom.OrderBy(x => x.GetType()
                                         .GetProperty(value)
                                         .GetValue(x, null)).ToList();
                dataGridView1.DataSource = ListRoom;
            }
            else
            {
                LoadRoom();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
