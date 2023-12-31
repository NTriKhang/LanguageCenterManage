﻿using LanguageCenterManage.DAL;
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
        List<ClassDTO> ListClass;
        public ClassEmployeeControl()
        {
            InitializeComponent();
            ListClass = new List<ClassDTO>();
        }
        public void LoadClass()
        {
            db = new AppDbContext();
            ListClass = db.Classes
                        .Include(nameof(Class.Course))
                        .Select(x => new ClassDTO
                        {
                            Id = x.Id,
                            CourseName = x.Course.Name,
                            Quantity = x.Quantity,
                            DateTime = x.Course.DateStart,
                            Status = x.Course.Status,
                        }).ToList();
            classDTOBindingSource.DataSource = ListClass;
        }

        private void ClassEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadClass();
            Sort_Combobox.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();
            if (txtSearch != null)
            {
                ListClass = db.Classes
                    .Include(nameof(Class.Course))
                    .Where(
                    x => x.Id.Contains(searchString) ||
                    x.Course.Name.Contains(searchString)
                ).Select(x => new ClassDTO
                {
                    Id = x.Id,
                    CourseName = x.Course.Name,
                    Quantity = x.Quantity,
                    DateTime = x.Course.DateStart,
                    Status = x.Course.Status,
                })
                .ToList();
                classDTOBindingSource.DataSource = ListClass;
                dataGridView1.DataSource = classDTOBindingSource;
            }
            else
            {
                LoadClass();
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
                dataGridView1.DataSource = classDTOBindingSource;
            }
            else
            {
                LoadClass();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
