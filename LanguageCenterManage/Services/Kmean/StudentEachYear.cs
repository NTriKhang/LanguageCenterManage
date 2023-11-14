using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
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

namespace LanguageCenterManage.Services.Kmean
{
    public partial class StudentEachYear : Form
    {
        private AppDbContext _db;
        public int Year { set; get; }   
        public int Quantity { set; get; }
        public StudentEachYear()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }

        private void StudentEachYear_Load(object sender, EventArgs e)
        {
            var studentEachYear = (from joins in _db.Joins
                                   from classes in _db.Classes
                                   from courses in _db.Courses
                                   where joins.ClassId == classes.Id
                                         && classes.CourseId == courses.Id
                                   group courses by new { courses.DateStart.Year, joins.StudentId } into courseGroup
                                   group courseGroup by courseGroup.Key.Year into courseGroupKey
                                   select new StudentEachYearDTO
                                   {
                                       Year = courseGroupKey.Key,
                                       Quantity = courseGroupKey.Count()
                                   }).ToList();

            studentEachYearDTOBindingSource.DataSource = studentEachYear;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowSelected = (studentEachYearDTOBindingSource.DataSource as List<StudentEachYearDTO>).ElementAtOrDefault(e.RowIndex);
            Year = rowSelected.Year;
            Quantity = rowSelected.Quantity;
            Close();
        }
    }
}
