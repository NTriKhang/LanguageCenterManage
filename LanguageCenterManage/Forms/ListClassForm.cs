﻿using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms
{
    public partial class ListClassForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public ListClassForm()
        {
            InitializeComponent();
        }
        public void LoadClasses()
        {
            classDTOBindingSource.DataSource = (from c in db.Classes
                                                where !(from j in db.Joins
                                                        where j.StudentId == StudentId
                                                        select j.ClassId)
                                                       .Contains(c.Id) && c.Course.Status == utility.CourseOpen
                                                select new ClassDTO
                                                {
                                                    Id = c.Id,
                                                    CourseName = c.Course.Name,
                                                    Quantity = c.Quantity
                                                })
                        .ToList();
        }

        private void ListClassForm_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ClassId = selectId;
            var quantity = db.Joins
                             .Include(nameof(Join.Class))
                             .Where(x => x.ClassId == ClassId)
                             .Select(x => x.Class.Quantity)
                             .FirstOrDefault();
            if(quantity >= 40)
            {
                MessageBox.Show("The number of classes is enough", "error");
                return;
            }
            else
                Close();
        }

        private void ListClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
