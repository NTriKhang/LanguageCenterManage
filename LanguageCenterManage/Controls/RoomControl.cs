using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
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
        public RoomControl()
        {
            InitializeComponent();
        }
        void LoadRoom()
        {
            var lisRoom = db.Rooms.AsNoTracking().ToList();
            roomBindingSource.DataSource = lisRoom;
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Id, Name")
            {
                txtSearch.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                var listStudent = db.Rooms.Where(
                    x => x.Id.Contains(searchString) ||
                    x.Name.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = listStudent;
            }
            else
            {
                LoadRoom();
            }
        }
    }
}
