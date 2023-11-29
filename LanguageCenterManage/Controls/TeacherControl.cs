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
        List<TeacherDTO> ListTeacher;
        public TeacherControl()
        {
            InitializeComponent();
            ListTeacher= new List<TeacherDTO>();
        }
        void LoadTeacher()
        {
            ListTeacher = db.Teachers.Select(m => new TeacherDTO
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Birth = m.Birth,
            }).ToList();
            teacherDTOBindingSource.DataSource = ListTeacher;
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            LoadTeacher();
            Sort_Combobox.SelectedIndex = 0;
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (searchString != null)
            {
                ListTeacher = db.Teachers.
                    Select(m => new TeacherDTO
                {
                    Id = m.Id,
                    FirstName = m.FirstName,
                    LastName = m.LastName,
                    Birth = m.Birth,
                }).Where(
                    x => x.Id.Contains(searchString) ||
                    x.LastName.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = ListTeacher;
            }
            else
            {
                LoadTeacher();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListTeacher = ListTeacher.OrderBy(x => x.GetType()
                                                        .GetProperty(value)
                                                        .GetValue(x, null)).ToList();
                dataGridView1.DataSource = ListTeacher;
            }
            else
            {
                LoadTeacher();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
