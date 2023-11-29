using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.Controls;
using LanguageCenterManage.DTO;
using System.Data.SqlTypes;

namespace LanguageCenterManage.Controls
{
    public partial class StudentControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        List<StudentDTO> ListStudent;
        public StudentControl()
        {
            InitializeComponent();
            ListStudent = new List<StudentDTO>();
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Id, Lastname")
            {
                txtSearch.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudentLoad()
        {
            ListStudent = db.Students.Select(m => new StudentDTO
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Birth = m.Birth,
            }).ToList();
            studentDTOBindingSource.DataSource = ListStudent;
        }
        private void StudentDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadStudentLoad();
            dataGridView1.Refresh();
        }
        private void StudentControl_Load(object sender, EventArgs e)
        {
            LoadStudentLoad();
            Sort_Combobox.SelectedIndex = 0;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var studentDetailForm = new StudentDetailForm();
            studentDetailForm.FormClosed += StudentDetailForm_FormClosed;
            studentDetailForm.Id = null;
            studentDetailForm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var StudentSelectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            using (StudentDetailForm studentDetailForm = new StudentDetailForm())
            {
                studentDetailForm.FormClosed += StudentDetailForm_FormClosed;
                studentDetailForm.Id = StudentSelectedId;
                studentDetailForm.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (searchString != null)
            {
                ListStudent = db.Students.Select(m => new StudentDTO
                {
                    Id = m.Id,
                    FirstName = m.FirstName,
                    LastName = m.LastName,
                    Birth = m.Birth,
                }).Where(
                    x => x.Id.Contains(searchString) ||
                    x.LastName.Contains(searchString) ||
                    x.FirstName.Contains(searchString)
                ).ToList();
                dataGridView1.DataSource = ListStudent;
            }
            else
            {
                LoadStudentLoad();
            }
            if(Sort_Combobox.Text != null)
            {
                SortDG(Sort_Combobox.SelectedItem.ToString());
            }
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if(!string.IsNullOrEmpty(stringSort))
            {
                ListStudent = ListStudent.OrderBy(x => x.GetType()
                                         .GetProperty(value)
                                         .GetValue(x, null)).ToList();
                dataGridView1.DataSource = ListStudent;
            }
            else
            {
                LoadStudentLoad();
            }
        }

        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
