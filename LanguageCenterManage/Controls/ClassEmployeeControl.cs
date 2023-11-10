using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
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

namespace LanguageCenterManage.Controls
{
    public partial class ClassEmployeeControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        public ClassEmployeeControl()
        {
            InitializeComponent();
        }
        public void LoadClass()
        {
            db = new AppDbContext();
            classDTOBindingSource.DataSource = db.Classes
                                                    .Include(nameof(Class.Course))
                                                    .Select(x => new ClassDTO
                                                    {
                                                        Id = x.Id,
                                                        CourseName = x.Course.Name,
                                                        Quantity = x.Quantity
                                                    }).ToList();
        }

        private void ClassEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadClass();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                var listStudent = db.Classes
                    .Include(nameof(Class.Course))
                    .Where(
                    x => x.Id.Contains(searchString) ||
                    x.Course.Name.Contains(searchString)
                ).Select(x => new ClassDTO
                {
                    Id = x.Id,
                    CourseName = x.Course.Name,
                    Quantity = x.Quantity
                })
                .ToList();
                dataGridView1.DataSource = listStudent;
            }
            else
            {
                LoadClass();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Id, Coursname")
            {
                txtSearch.Clear();
            }
        }
    }
}
