using LanguageCenterManage.DAL;
using LanguageCenterManage.Forms.SubForm;
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

namespace LanguageCenterManage.Forms
{
    public partial class ClassDetailForm : MaterialForm
    {
        private readonly AppDbContext _db;
        private Class _class;
        private List<Course> _courses;
        public ClassDetailForm()
        {
            _db = new AppDbContext();
            _courses = _db.Courses.Where(x => x.Status == utility.CourseOpen).OrderBy(x => x.Band).ToList();
            InitializeComponent();

        }
        public ClassDetailForm(string classId)
        {
            _db = new AppDbContext();
            _class = _db.Classes.Where(x => x.Id == classId).SingleOrDefault();
            _courses = _db.Courses.Where(x => x.Status == utility.CourseOpen).OrderBy(x => x.Band).ToList();
            InitializeComponent();
        }

        private void ClassDetailForm_Load(object sender, EventArgs e)
        {
            CourseIdCB.Items.Clear();
            CourseIdCB.Items.AddRange(_courses.Select(x => x.Id).ToArray());
            if (_class == null)
            {
                deleteBtn.Visible = false;
                updateBtn.Visible = false;
                ShowStudentBtn.Visible = false;
                Idtextbox.Text = Guid.NewGuid().ToString().Substring(0, 7);
            }
            else
            {
                createBtn.Visible = false;
                Idtextbox.Text = _class.Id;
                quanlityTextbox.Text = _class.Quantity.ToString();
                CourseIdCB.Text = _class.CourseId;
                CourseName.Text = _db.Courses.Where(x => x.Id == _class.CourseId).Select(x => x.Name).SingleOrDefault();
                ShowStudentBtn.Text += " (" + _db.Joins.Where(x => x.ClassId == _class.Id).Count().ToString() + ")";
            }
        }

        private void CourseIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var courseId = CourseIdCB.Text;
            var courseName = _courses.Where(x => x.Id == courseId).Select(x => x.Name).SingleOrDefault();
            if (courseName != null)
            {
                CourseName.Text = courseName;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                Class newClass = new Class()
                {
                    Id = Idtextbox.Text,
                    Quantity = Convert.ToInt32(quanlityTextbox.Text),
                    CourseId = CourseIdCB.Text,
                };
                _db.Classes.Add(newClass);
                _db.SaveChanges();
                MessageBox.Show("Create successfully", "New class was added to db", MessageBoxButtons.OK);
                Close();
            }
        }
        private bool isValid()
        {
            if (Idtextbox.Text == "" || quanlityTextbox.Text == ""
                || CourseIdCB.Text == "" || CourseName.Text == "")
            {
                MessageBox.Show("Lack of information", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                _class.Quantity = Convert.ToInt32(quanlityTextbox.Text);
                _class.CourseId = CourseIdCB.Text;
                _db.SaveChanges();
                MessageBox.Show("Update successfully", "class was updated to db", MessageBoxButtons.OK);
                Close();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Sure ?", "Are you sure to delete it ?", MessageBoxButtons.YesNo);

            if (box == DialogResult.Yes)
            {
                if (_db.Schedules.Any(x => x.ClassId == _class.Id) || _db.Joins.Any(x => x.ClassId == _class.Id))
                {
                    MessageBox.Show("Conflict foreign key !", "Error");
                    return;

                }
                else
                {
                    _db.Classes.Remove(_class);
                    _db.SaveChanges();
                    Close();
                }
            }
        }

        private void ShowStudentBtn_Click(object sender, EventArgs e)
        {
            StudentOfClassForm studentOfClassForm = new StudentOfClassForm(_class.Id);
            studentOfClassForm.Show();
        }
    }
}
