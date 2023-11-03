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
using MaterialSkin;
using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using System.Data.Entity;
using LanguageCenterManage.DTO;

namespace LanguageCenterManage.Forms
{
    public partial class JoinDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string StudentId { get; set; }
        public string ClassId { get; set; }
        Join join = new Join();
        List<Class> listClasses;
        public JoinDetailForm()
        {
            listClasses = db.Classes.ToList();
            InitializeComponent();
        }

        private void JoinDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void JoinDetailForm_Load(object sender, EventArgs e)
        {
            join = db.Joins.Where(x => x.StudentId == StudentId && x.ClassId == ClassId).FirstOrDefault();
            if(join != null)
            {
                txtStudentId.Text = StudentId;
                txtFistGrade.Text = join.FirstGrade.ToString();
                txtSecondGrade.Text = join.SecondGrade.ToString();
                txtFinalGrade.Text = join.FinalGrade.ToString();
                txtClassId.Text = join.ClassId;
               // checkBoxTuiTion.Checked = join.TuiTionState;

                btnAdd.Visible = false;
            }
            else
            {
                txtStudentId.Text = StudentId;
                txtFistGrade.Text = "0";
                txtSecondGrade.Text = "0";
                txtFinalGrade.Text = "0";
                //checkBoxTuiTion.Checked = false;

                btnUpdate.Visible= false;
                btnDelete.Visible= false;
            }
        }
        bool isModelValid()
        {
            if (txtFistGrade.Text.Trim() == "" || txtSecondGrade.Text.Trim() == "" 
                || txtSecondGrade.Text.Trim() == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        public void InsertJoin()
        {
            Join j = new Join();
            j.StudentId = txtStudentId.Text;
            j.ClassId = txtClassId.Text;
            j.FirstGrade = Decimal.Parse(txtFistGrade.Text);
            j.SecondGrade = Decimal.Parse(txtSecondGrade.Text);
            j.FinalGrade = Decimal.Parse(txtFinalGrade.Text);
            //j.TuiTionState = checkBoxTuiTion.Checked;
            db.Joins.Add(j);
            db.SaveChanges();
        }
        public void UpdateJoin()
        {
            db.Joins.Remove(join);
            Join j = new Join();
            j.StudentId = txtStudentId.Text;
            j.ClassId = txtClassId.Text;
            j.FirstGrade = Decimal.Parse(txtFistGrade.Text);
            j.SecondGrade = Decimal.Parse(txtSecondGrade.Text);
            j.FinalGrade = Decimal.Parse(txtFinalGrade.Text);
            //j.TuiTionState = checkBoxTuiTion.Checked;
            db.Joins.Add(j);
            db.SaveChanges();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                UpdateJoin();
                MessageBox.Show("Update successfully", "Join have updated to db", MessageBoxButtons.OK);
                Close();
            }
        }
        private void btnShowListClass_Click(object sender, EventArgs e)
        {
            ListClassForm listJoinForm = new ListClassForm();
            listJoinForm.TopMost = true;
            listJoinForm.StudentId = txtStudentId.Text;
            listJoinForm.ShowDialog();
            txtClassId.Text = listJoinForm.ClassId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.Joins.Remove(join);
                db.SaveChanges();
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                InsertJoin();
                MessageBox.Show("Create successfully", "Join have added to db", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
