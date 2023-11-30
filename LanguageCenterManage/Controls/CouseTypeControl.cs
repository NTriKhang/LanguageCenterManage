using LanguageCenterManage.DAL;
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
        List<CourseType> ListCourseType;
        public CouseTypeControl()
        {
            InitializeComponent();
            ListCourseType = new List<CourseType>();    
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void LanguageControl_Load(object sender, EventArgs e)
        {
            Reload();
            Sort_Combobox.SelectedIndex = 0;
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
            ListCourseType = _db.CourseType.ToList();
            languageBindingSource.DataSource = ListCourseType;
            dataGridView1.DataSource = languageBindingSource;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            var languageDetailForm = new CourseTypeForm();

            languageDetailForm.FormClosed += LanguageDetailForm_FormClosed;

            languageDetailForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db = new AppDbContext();
            var stringSearch = txtSearch.Text.Trim();
            if(!string.IsNullOrEmpty(stringSearch))
            {
                ListCourseType = _db.CourseType
                    .Where(x => x.Id.Contains(stringSearch) ||
                                x.Name.Contains(stringSearch))
                    .ToList();
                languageBindingSource.DataSource = ListCourseType;
                dataGridView1.DataSource = ListCourseType;
                
            }
            else
            {
                Reload();
            }
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListCourseType = ListCourseType.OrderBy(x => x.GetType()
                                         .GetProperty(value)
                                         .GetValue(x, null)).ToList();
                languageBindingSource.DataSource = ListCourseType;
                dataGridView1.DataSource = ListCourseType;
            }
            else
            {
                Reload();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
