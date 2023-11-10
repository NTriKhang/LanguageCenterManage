using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
using MaterialSkin.Controls;
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
    public partial class JoinControl : MaterialForm
    {
        public string Id { get; set; }
        AppDbContext db = new AppDbContext();
        public JoinControl()
        {
            InitializeComponent();
        }
        public void LoadJoin()
        {
            joinDTOBindingSource.DataSource = db.Joins
                .Where(x => x.StudentId == Id)
                .Select(x => new JoinDTO
                {
                    ClassId = x.ClassId,
                    StudentId = x.StudentId,
                    //TuiTionState = x.TuiTionState,
                }).ToList();
        }
        private void JoinControl_Load(object sender, EventArgs e)
        {
            LoadJoin();
        }
        private void JoinDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadJoin();
            dataGridView1.Refresh();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var joinDetailForm = new JoinDetailForm();
            joinDetailForm.TopMost = true;
            joinDetailForm.ClassId = null;
            joinDetailForm.StudentId = Id;
            joinDetailForm.FormClosed += JoinDetailForm_FormClosed;
            joinDetailForm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var joinDetailForm = new JoinDetailForm();
            joinDetailForm.TopMost = true;
            joinDetailForm.ClassId = selectedId;
            joinDetailForm.StudentId = Id;
            joinDetailForm.FormClosed += JoinDetailForm_FormClosed;
            joinDetailForm.ShowDialog();
        }
    }
}
