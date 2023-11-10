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
    public partial class TeacherControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        public TeacherControl()
        {
            InitializeComponent();
        }
        void LoadTeacher()
        {
            var listTeacher = db.Teachers.Select(m => new StudentDTO
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Birth = m.Birth,
            }).ToList();
            teacherDTOBindingSource.DataSource = listTeacher;
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }
        private void TeacherDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTeacher();
            dataGridView1.Refresh();
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var teacherDetailForm = new TeacherDetailForm();
            teacherDetailForm.Id = null;
            teacherDetailForm.FormClosed += TeacherDetailForm_FormClosed;
            teacherDetailForm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var teacherSelectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var teacherDetailForm = new TeacherDetailForm();
            teacherDetailForm.Id = teacherSelectedId;
            teacherDetailForm.FormClosed += TeacherDetailForm_FormClosed;
            teacherDetailForm.ShowDialog();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Id, Lastname")
            {
                txtSearch.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                var listStudent = db.Teachers.Where(
                    x => x.Id.Contains(searchString) ||
                    x.LastName.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = listStudent;
            }
            else
            {
                LoadTeacher();
            }
        }
    }
}
