using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LanguageCenterManage.Forms
{
    public partial class RoomDetailForm : MaterialForm
    {
        public string Id { get; set; }
        AppDbContext db = new AppDbContext();
        private Room room = new Room();
        public RoomDetailForm()
        {
            InitializeComponent();
        }
        void showRoom()
        {
            room = db.Rooms.Where(x => x.Id == Id).FirstOrDefault();
            if (room != null)
            {
                txtRoomId.Text = room.Id;
                txtRoomName.Text = room.Name;

                btnAdd.Visible = false;
            }
            else
            {
                txtRoomId.Text = Guid.NewGuid().ToString().Substring(0, 7);
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        bool isModelValid()
        {
            if(txtRoomId.Text.Trim() == "" || txtRoomName.Text.Trim() == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            else if(db.Rooms.Any(x => x.Name == txtRoomName.Text.Trim()))
            {
                MessageBox.Show("This room name already exits", "Overlap", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        void InsertRoom()
        {
            Room r = new Room();
            r.Id = txtRoomId.Text;
            r.Name = txtRoomName.Text;
            db.Rooms.Add(r);
            db.SaveChanges();
        }
        void UpdateRoom()
        {
            room.Id = txtRoomId.Text;
            room.Name = txtRoomName.Text;
            db.SaveChanges();
        }
        void DeleteRoom()
        {
            db.Rooms.Remove(room);
            db.SaveChanges();
        }
        private void RoomDetailForm_Load(object sender, EventArgs e)
        {
            showRoom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isModelValid())
            {
                InsertRoom();
                MessageBox.Show("Create successfully", "Room have added to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                UpdateRoom();
                MessageBox.Show("Update successfully", "Room have updated to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteRoom();
                Close();
            }
        }
    }
}
