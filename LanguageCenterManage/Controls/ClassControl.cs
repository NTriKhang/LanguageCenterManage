using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
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
    public partial class ClassControl : UserControl
    {
        private AppDbContext _db;
        public ClassControl()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            _db = new AppDbContext();
            classDTOBindingSource.DataSource = _db.Classes
                                                    .Include(nameof(Class.Course))
                                                    .Select(x => new ClassDTO
                                                    {
                                                        Id = x.Id,
                                                        CourseName = x.Course.Name,
                                                        Quantity = x.Quantity
                                                    }).ToList();
        }
        private void ClassControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ClassDetailForm_Closed(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Refresh();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClassDetailForm classDetailForm = new ClassDetailForm();
            classDetailForm.FormClosed += ClassDetailForm_Closed;
            classDetailForm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var classId = (classDTOBindingSource.DataSource as List<ClassDTO>).ElementAtOrDefault(e.RowIndex).Id;
            ClassDetailForm classDetailForm = new ClassDetailForm(classId);
            classDetailForm.FormClosed += ClassDetailForm_Closed;
            classDetailForm.ShowDialog();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "Enter Id, CoursName")
            {
                txtSearch.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db = new AppDbContext();
            string stringSearch = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(stringSearch))
            {
                classDTOBindingSource.DataSource = _db.Classes
                                                        .Include(nameof(Class.Course))
                                                        .Where(x => x.Id.Contains(stringSearch) ||
                                                               x.Course.Name.Contains(stringSearch))
                                                        .Select(x => new ClassDTO
                                                        {
                                                            Id = x.Id,
                                                            CourseName = x.Course.Name,
                                                            Quantity = x.Quantity
                                                        }).ToList();
            }
            else
            {
                LoadData();
            }
        }
    }
}
