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
using LanguageCenterManage.Controls;
using System.Data.Entity.Migrations;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LanguageCenterManage.Forms
{
    public partial class JoinDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string StudentId { get; set; }
        public string ClassId { get; set; }
        Join join = new Join();
        List<Class> listClasses;
        BillDetail billDetail = new BillDetail();
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
                txtJoinId.Text = join.Id;
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
                txtJoinId.Text = Guid.NewGuid().ToString().Substring(0, 7);
                txtStudentId.Text = StudentId;
                txtFistGrade.Text = "0";
                txtSecondGrade.Text = "0";
                txtFinalGrade.Text = "0";
                //checkBoxTuiTion.Checked = false;

                btnUpdate.Visible= false;
                btnDelete.Visible= false;
                btnBill.Visible = false;
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
            j.Id = txtJoinId.Text;
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
            Join j = new Join();
            j.Id = txtJoinId.Text;
            j.StudentId = txtStudentId.Text;
            j.ClassId = txtClassId.Text;
            j.FirstGrade = Decimal.Parse(txtFistGrade.Text);
            j.SecondGrade = Decimal.Parse(txtSecondGrade.Text);
            j.FinalGrade = Decimal.Parse(txtFinalGrade.Text);
            //j.TuiTionState = checkBoxTuiTion.Checked;
            db.Joins.AddOrUpdate(j);
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
            if(listJoinForm.ClassId != null)
            {
                txtClassId.Text = listJoinForm.ClassId;
            }
            else
            {
                txtClassId.Text = join.ClassId;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                billDetail.deleteBill(txtJoinId.Text);
                db.Joins.Remove(join);
                db.SaveChanges();
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CenterConnectionString"].ConnectionString;
                double currentBand = 0, FinalGrade = 0;
                using(var sqlConn = new SqlConnection(connectionString))
                {
                    var sqlcmd = new SqlCommand("GetMaxBandForFinalGrade", sqlConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    var param1 = new SqlParameter()
                    {
                        ParameterName = "@StudentId",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = StudentId.ToString(),
                        Direction = ParameterDirection.Input,
                    };
                    sqlcmd.Parameters.Add(param1);
                    sqlConn.Open();
                    var sdr = sqlcmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        currentBand = Convert.ToDouble(sdr[nameof(Course.Band)]);
                        FinalGrade = Convert.ToDouble(sdr[nameof(Join.FinalGrade)]);
                    }
                }
                var classBand = db.Classes.Where(x => x.Id == txtClassId.Text).Include(x => x.Course).Select(x => x.Course.Band).SingleOrDefault();
                if(FinalGrade < 5 && classBand > currentBand)
                {
                    MessageBox.Show("You are not eligible to register", "Fail", MessageBoxButtons.OK);
                }
                else
                {
                    InsertJoin();
                    billDetail.initBill(txtJoinId.Text);
                    MessageBox.Show("Create successfully", "Join have added to db", MessageBoxButtons.OK);
                    Close();
                }
                //if(db.Joins.Any(x => x.StudentId == StudentId))
                //{
                //    var grade = (from stu in db.Students
                //                 join j in db.Joins on stu.Id equals j.StudentId
                //                 join c in db.Classes on j.ClassId equals c.Id
                //                 join cs in db.Courses on c.CourseId equals cs.Id
                //                 where stu.Id == StudentId
                //                 orderby cs.Band descending
                //                 select j.FinalGrade).Take(1).FirstOrDefault();
                //    if (grade < 5)
                //    {
                //        MessageBox.Show("You are not eligible to register", "Fail", MessageBoxButtons.OK);
                //        return;
                //    }
                //}

            }
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            BillDetail billDetail = new BillDetail();
            billDetail.StudentId = StudentId;
            billDetail.JoinId = txtJoinId.Text;
            billDetail.TopMost = true;
            billDetail.ShowDialog();
        }
    }
}
