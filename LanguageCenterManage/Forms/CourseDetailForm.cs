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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanguageCenterManage.Forms
{
    public partial class CourseDetailForm : MaterialForm
    {
        private readonly AppDbContext _db;
        List<CourseType> listLanguage;
        private Course course;
        public CourseDetailForm()
        {
            _db = new AppDbContext();

            listLanguage = _db.CourseType.ToList();

            InitializeComponent();
        }
        public CourseDetailForm(string courseId)
        {
            _db = new AppDbContext();

            listLanguage = _db.CourseType.ToList();

            course = _db.Courses.SingleOrDefault(x => x.Id == courseId);

            InitializeComponent();
        }
        private void CourseDetail_Load(object sender, EventArgs e)
        {

            if (course == null)
            {
                comboBoxLanguageId.Items.Clear();
                comboBoxLanguageId.Items.AddRange(listLanguage.Select(x => x.Id).ToArray());
                textBoxId.Text = Guid.NewGuid().ToString().Substring(0, 7);
                
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                textBoxId.Text = course.Id;
                textBoxName.Text = course.Name;
                textBoxLanguageName.Text = listLanguage.Where(x => x.Id == course.LanguageId).SingleOrDefault().Name;
                descriptionBox.Text = course.Description;
                comboBoxStatus.Text = course.Status;
                DateStartPicker.Value = course.DateStart;
                DateEndPicker.Value = course.DateEnd;

                LoadLanguage();
              
                btnCreate.Visible = false;

            }
        }
        private void LoadBand()
        {
            Bandtxt.Items.Clear();
            int currentBandIndex = 0;
            int i = 0;
            var bands = _db.Bands.Where(x => x.CourseTypeId == comboBoxLanguageId.Text).OrderBy(x => x.BandNumber).ToList();
            foreach(var band in bands)
            {
                if (course != null && band.BandNumber == Convert.ToDecimal(course.Band))
                {
                    currentBandIndex = i;
                }
                i++;
                Bandtxt.Items.Add(band.BandNumber);
            }
            Bandtxt.SelectedItem = Bandtxt.Items[currentBandIndex];
        }
        private void LoadLanguage()
        {
            int currentLanguageIndex = 0;
            int i = 0;
            listLanguage.ForEach(x =>
            {
                if (x.Id == course.LanguageId)
                {
                    currentLanguageIndex = i;
                }
                i++;
                comboBoxLanguageId.Items.Add(x.Id);
            });
            comboBoxLanguageId.SelectedItem = comboBoxLanguageId.Items[currentLanguageIndex];
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newCourse = new Course();
            newCourse.Id = textBoxId.Text;
            newCourse.Name = textBoxName.Text;
            newCourse.LanguageId = comboBoxLanguageId.Text;
            newCourse.Description = descriptionBox.Text;
            newCourse.Status = comboBoxStatus.Text;
            newCourse.DateStart = DateStartPicker.Value.Date;
            newCourse.DateEnd = DateEndPicker.Value.Date;
            newCourse.Band = Convert.ToDouble(Bandtxt.Text);

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
            course.DateStart = DateStartPicker.Value.Date;
            course.DateEnd = DateEndPicker.Value.Date;
            course.Band = Convert.ToDouble(Bandtxt.Text);

            _db.SaveChanges();
            DialogResult box = MessageBox.Show("Update successfully", "Course was updated to db", MessageBoxButtons.OK);
            Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Sure ?", "Are you sure to delete it ?", MessageBoxButtons.YesNo);

            try
            {
                if (box == DialogResult.Yes)
                {
                    if(_db.Classes.Any(x => x.CourseId == course.Id))
                    {
                        MessageBox.Show("Class of this course was openned, can't delete it");
                    }
                    else
                    {
                        _db.Courses.Remove(course);
                        _db.SaveChanges();
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't delete", "409", MessageBoxButtons.OK);
            }
        }

        private void comboBoxLanguageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bandtxt.Items.Clear();
            var languageId = comboBoxLanguageId.Text;
            string languageName = listLanguage.Where(x => x.Id == languageId).FirstOrDefault().Name;
            if (languageName != null)
            {
                textBoxLanguageName.Text = languageName;
            }
            LoadBand();
            //_db.Bands.Where(x => x.CourseTypeId == languageId).OrderBy(x => x.BandNumber).ToList().ForEach(x =>
            //{
            //    Bandtxt.Items.Add(x.BandNumber);
            //});
        }

        private void Bandtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
