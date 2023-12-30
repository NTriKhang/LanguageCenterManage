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
    public partial class StudentOfClassForm : Form
    {
        private AppDbContext db;
        private string classId;
        public StudentOfClassForm(string classId)
        {
            this.classId = classId;
            db = new AppDbContext();
            InitializeComponent();
        }

        private void StudentOfClassForm_Load(object sender, EventArgs e)
        {
            studentDTOBindingSource.DataSource = db.Joins
            .Where(x => x.ClassId == classId)
            .Include(x => x.Student)
            .Select(x => new StudentDTO
            {
                Id = x.Id,
                FirstName = x.Student.FirstName,
                LastName = x.Student.LastName,
                Birth = x.Student.Birth,
            }).ToList();
        }
    }
}
