using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LanguageCenterManage.Forms
{
    public partial class TeacherDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string Id { get; set; }
        private Teacher teacher;
        public TeacherDetailForm()
        {
            InitializeComponent();
            Load += TeacherDetailForm_Load;
        }
        public void showTeacher()
        {
            teacher = db.Teachers.Where(x => x.Id == Id).FirstOrDefault();
            if(teacher != null)
            {
                txtIdTeacher.Text = teacher.Id;
                txtFirstName.Text = teacher.FirstName;
                txtLastName.Text = teacher.LastName;
                txtAddress.Text = teacher.Address;
                txtEmailTeacher.Text = teacher.Email;
                txtPhone.Text = teacher.Phone;

                btnAdd.Visible = false;
            }
            else
            {
                txtIdTeacher.Text = Guid.NewGuid().ToString().Substring(0, 7);
                
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }
        public void insertTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.Id = txtIdTeacher.Text;
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.Email = txtEmailTeacher.Text;
            teacher.Birth = dtBirth.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhone.Text;

            db.Teachers.Add(teacher);
            db.SaveChanges();
        }
        public void updateTeacher()
        {
            teacher.Id = txtIdTeacher.Text;
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.Email = txtEmailTeacher.Text;
            teacher.Birth = dtBirth.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhone.Text;

            db.SaveChanges();
        }
        private bool isModelValid()
        {
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtEmailTeacher.Text.Trim() == ""
                || txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void TeacherDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TeacherDetailForm_Load(object sender, EventArgs e)
        {
            showTeacher();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isModelValid())
            {
                insertTeacher();
                MessageBox.Show("Create successfully", "Teacher was added to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(isModelValid())
            {
                updateTeacher();
                MessageBox.Show("Update successfully", "Teacher was updated to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                db.Teachers.Remove(teacher);
                db.SaveChanges();
                Close();
            }
        }
    }
}
