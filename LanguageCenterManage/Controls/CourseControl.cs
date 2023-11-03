using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Controls
{
    public partial class CourseControl : UserControl
    {
        private AppDbContext _db;
        public CourseControl()
        {
            InitializeComponent();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void CourseControl_Load(object sender, EventArgs e)
        {
            LoadCourseData();
        }
        private void LoadCourseData()
        {
            _db = new AppDbContext();
            courseDTOBindingSource.DataSource = null;

            var listCourse = _db.Courses
                    .Include(nameof(Course.Language))
                    .OrderBy(x => x.DateStart).ThenBy(x => x.Band)
                    .Select(x => new CourseDTO
                    {
                        Id = x.Id,
                        Name = x.Name,
                        CourseType = x.Language.Name,
                        Band = x.Band,  
                        Status = x.Status,
                    })
                    .ToList();

            courseDTOBindingSource.DataSource = listCourse;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var courseDetailForm = new CourseDetailForm();

            courseDetailForm.FormClosed += CourseDetailForm_FormClosed;

            courseDetailForm.ShowDialog();
            
        }

        private void CourseDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCourseData();
            dataGridView1.Refresh();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var courseSelectedId = (courseDTOBindingSource.DataSource as List<CourseDTO>).ElementAtOrDefault(e.RowIndex).Id;
            var courseDetail = new CourseDetailForm(courseSelectedId);
            courseDetail.FormClosed += CourseDetailForm_FormClosed;
            courseDetail.ShowDialog();
           
        }
    }
}
