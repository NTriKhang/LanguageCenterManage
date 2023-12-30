using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
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

namespace LanguageCenterManage.Forms.SubForm
{
    public partial class ClassOfCourseForm : Form
    {
        private AppDbContext db;
        private string courseId;
        public ClassOfCourseForm(string courseId)
        {
            db = new AppDbContext();
            this.courseId = courseId;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassOfCourseForm_Load(object sender, EventArgs e)
        {
            classDTOBindingSource.DataSource = db.Classes
                        .Where(x => x.CourseId == courseId)
                        .Include(x => x.Course)
                        .Select(x => new ClassDTO
                        {
                            Id = x.Id,
                            CourseName = x.Course.Name,
                            Quantity = x.Quantity,
                            DateTime = x.Course.DateStart,
                            Status = x.Course.Status,
                        }).ToList();
        }
    }
}
