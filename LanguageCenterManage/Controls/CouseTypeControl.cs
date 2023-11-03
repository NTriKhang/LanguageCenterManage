﻿using LanguageCenterManage.DAL;
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
    public partial class CouseTypeControl : UserControl
    {
        private AppDbContext _db;
        public CouseTypeControl()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void LanguageControl_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var languageId = (languageBindingSource.DataSource as List<CourseType>).ElementAt(e.RowIndex).Id;
            var languageDetailForm = new CourseTypeForm(languageId);

            languageDetailForm.FormClosed += LanguageDetailForm_FormClosed;

            languageDetailForm.ShowDialog();
        }

        private void LanguageDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reload();
            dataGridView1.Refresh();
        }
        private void Reload()
        {
            _db = new AppDbContext();
            languageBindingSource.DataSource = null;
            languageBindingSource.DataSource = _db.CourseType.ToList();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            var languageDetailForm = new CourseTypeForm();

            languageDetailForm.FormClosed += LanguageDetailForm_FormClosed;

            languageDetailForm.ShowDialog();
        }
    }
}
