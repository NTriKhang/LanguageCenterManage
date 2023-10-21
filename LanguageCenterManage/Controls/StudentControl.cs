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

namespace LanguageCenterManage.Controls
{
    public partial class StudentControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        public StudentControl()
        {
            InitializeComponent();
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
            {
                txtSearch.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudentLoad()
        {
            var listStudent = db.Students.Select(m => new StudentDTO
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Birth = m.Birth,
            }).ToList();
            studentDTOBindingSource.DataSource = listStudent;
        }
        private void StudentDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadStudentLoad();
            dataGridView1.Refresh();
        }
        private void StudentControl_Load(object sender, EventArgs e)
        {
            LoadStudentLoad();
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

    }
}
