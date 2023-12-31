﻿using LanguageCenterManage.DAL;
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
        List<ClassDTO> ListClass;
        public ClassControl()
        {
            InitializeComponent();
            ListClass = new List<ClassDTO>();
        }
        private void LoadData()
        {
            _db = new AppDbContext();
            ListClass = _db.Classes
                            .Include(nameof(Class.Course))
                            .Select(x => new ClassDTO
                            {
                                Id = x.Id,
                                CourseName = x.Course.Name,
                                Quantity = x.Quantity,
                                DateTime = x.Course.DateStart,
                                Status = x.Course.Status,
                            })
                            .OrderByDescending(x => x.DateTime)
                            .ToList();
            classDTOBindingSource.DataSource = ListClass;
        }
        private void ClassControl_Load(object sender, EventArgs e)
        {
            LoadData();
            Sort_Combobox.SelectedIndex = 0;
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
                ListClass = _db.Classes
                                    .Include(nameof(Class.Course))
                                    .Where(x => x.Id.Contains(stringSearch) ||
                                            x.Course.Name.Contains(stringSearch))
                                    .Select(x => new ClassDTO
                                    {
                                        Id = x.Id,
                                        CourseName = x.Course.Name,
                                        Quantity = x.Quantity
                                    }).ToList();
                classDTOBindingSource.DataSource = ListClass;
            }
            else
            {
                LoadData();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListClass = ListClass.OrderBy(x => x.GetType()
                                         .GetProperty(value)
                                         .GetValue(x, null)).ToList();
                classDTOBindingSource.DataSource = ListClass;
            }
            else
            {
                LoadData();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
