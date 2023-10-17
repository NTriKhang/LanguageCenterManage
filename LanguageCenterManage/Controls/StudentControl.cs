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
        string iconSortId = "sort_descending";
        string iconSortName = "sort_descending";
        public List<Student> sortDescStudents(string sortBy)
        {
            List<Student> listSorted = new List<Student>();
            switch (sortBy)
            {
                case "Id":
                    listSorted = db.Students.OrderByDescending(m => m.Id).ToList();
                    break;
                case "Name":
                    listSorted = db.Students.OrderByDescending(m => m.LastName).ToList();
                    break;
            }
            return listSorted;
        }
        public List<Student> sortAscStudents(string sortBy)
        {
            List<Student> listSorted = new List<Student>();
            switch (sortBy)
            {
                case "Id":
                    listSorted = db.Students.OrderBy(m => m.Id).ToList();
                    break;
                case "Name":
                    listSorted = db.Students.OrderBy(m => m.LastName).ToList();
                    break;
            }
            return listSorted;
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
            {
                txtSearch.Clear();
            }
        }
        //private void labelId_Click(object sender, EventArgs e)
        //{
        //    tableLayout.Controls.Clear();

        //    List<Student> listSortStudent = new List<Student>();
        //    string ImageName = "";
        //    if (iconSortId == "sort_descending")
        //    {
        //        listSortStudent = sortDescStudents("Id");
        //        ImageName = iconSortId;
        //        iconSortId = "sort_Ascending";
        //    }
        //    else
        //    {
        //        listSortStudent = sortAscStudents("Id");
        //        ImageName = iconSortId;
        //        iconSortId = "sort_descending";
        //    }

        //    initHeaderTable();
        //    showStudents(listSortStudent);

        //    System.Resources.ResourceManager resourceManager = Properties.Resources.ResourceManager;
        //    Image img = (Image)resourceManager.GetObject(ImageName);
        //    pictureBoxId.Image = img;
        //}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentControl_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
