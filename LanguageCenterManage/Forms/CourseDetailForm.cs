using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms
{
    public partial class CourseDetailForm : MaterialForm
    {
        private readonly AppDbContext _db;
        List<Language> listLanguage;
        private Course course;
        public CourseDetailForm()
        {
            _db = new AppDbContext();

            listLanguage = _db.Languages.ToList();

            InitializeComponent();
        }
        public CourseDetailForm(string courseId)
        {
            _db = new AppDbContext();

            listLanguage = _db.Languages.ToList();

            course = _db.Courses.SingleOrDefault(x => x.Id == courseId);

            InitializeComponent();
        }
        private void CourseDetail_Load(object sender, EventArgs e)
        {
            comboBoxLanguageId.Items.Clear();
            comboBoxLanguageId.Items.AddRange(listLanguage.Select(x => x.Id).ToArray());
            if (course == null)
            {
                textBoxId.Text = Guid.NewGuid().ToString().Substring(0, 7);
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                textBoxId.Text = course.Id;
                textBoxName.Text = course.Name;
                comboBoxLanguageId.Text = course.LanguageId;
                textBoxLanguageName.Text = listLanguage.Where(x => x.Id == course.LanguageId).SingleOrDefault().Name;
                descriptionBox.Text = course.Description;
                comboBoxStatus.Text = course.Status;
                DateStartPicker.Value = course.DateStart;
                DateEndPicker.Value = course.DateEnd;

                btnCreate.Visible = false;

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newCourse = new Course();
            newCourse.Id = textBoxId.Text;
            newCourse.Name = textBoxName.Text;
            newCourse.LanguageId = comboBoxLanguageId.Text;
            newCourse.Description = descriptionBox.Text;
            newCourse.Status = comboBoxStatus.Text;
            newCourse.DateStart = DateStartPicker.Value;
            newCourse.DateEnd = DateEndPicker.Value;

            DialogResult box = MessageBox.Show("Create successfully", "New Course was added to db", MessageBoxButtons.OK);

            _db.Courses.Add(newCourse);
            _db.SaveChanges();

            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            course.Name = textBoxName.Text;
            course.LanguageId = comboBoxLanguageId.Text;
            course.Description = descriptionBox.Text;
            course.Status = comboBoxStatus.Text;
            course.DateStart = DateStartPicker.Value;
            course.DateEnd = DateEndPicker.Value;

            _db.SaveChanges();
            DialogResult box = MessageBox.Show("Update successfully", "Course was updated to db", MessageBoxButtons.OK);
            Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Sure ?", "Are you sure to delete it ?", MessageBoxButtons.YesNo);

            if (box == DialogResult.Yes)
            {
                _db.Courses.Remove(course);
                _db.SaveChanges();
                Close();
            }
        }

        private void comboBoxLanguageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var languageId = comboBoxLanguageId.Text;
            string languageName = listLanguage.Where(x => x.Id == languageId).FirstOrDefault().Name;
            if (languageName != null)
            {
                textBoxLanguageName.Text = languageName;
            }
        }

    }
}
