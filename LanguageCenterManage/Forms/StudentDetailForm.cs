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
using LanguageCenterManage.Models;
using LanguageCenterManage.DAL;
using LanguageCenterManage.Controls;
using System.Runtime.CompilerServices;
using LanguageCenterManage.Forms;

namespace LanguageCenterManage
{
    public partial class StudentDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string Id { get; set; }
        private Student student;
        public StudentDetailForm()
        {
            InitializeComponent();
            Load += StudentDetailForm_Load;
        }
        public void ShowStudent()   
        {
            student = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            if (student != null)
            {
                txtIdStudent.Text = student.Id;
                txtEmailStudent.Text = student.Email;
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                dtBirth.Value = student.Birth;
                txtPhone.Text = student.Phone;
                addressTextBox.Text = student.Address;
                btnAdd.Visible = false;
            }
            else
            {
                txtIdStudent.Text = Guid.NewGuid().ToString().Substring(0,7);
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnSendEmail.Visible = false;
                
            }
        }
        public void InsertStudent()
        {
            Student stu = new Student();

            stu.Id = txtIdStudent.Text;
            stu.FirstName = txtFirstName.Text;
            stu.LastName = txtLastName.Text;
            stu.Email = txtEmailStudent.Text;
            stu.Birth = dtBirth.Value;
            stu.Phone = txtPhone.Text;
            stu.Address = addressTextBox.Text;
            db.Students.Add(stu);
            db.SaveChanges();
        }
        public void UpdateSudent()
        {
            student.Id = txtIdStudent.Text;
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmailStudent.Text;
            student.Birth = dtBirth.Value;
            student.Phone = txtPhone.Text;
            student.Address = addressTextBox.Text;
            db.SaveChanges();
        }
        private bool isModelValid()
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmailStudent.Text == ""
                || txtPhone.Text == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                UpdateSudent();
                MessageBox.Show("Update successfully", "Course have updated to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void StudentDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void StudentDetailForm_Load(object sender, EventArgs e)
        {
            ShowStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isModelValid())
            {
                InsertStudent();
                MessageBox.Show("Create successfully", "Course have added to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                Close();
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            
            EmailForm emailForm = new EmailForm(txtEmailStudent.Text);
            emailForm.TopMost = true;
            emailForm.ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinControl JoinControl = new JoinControl();
            JoinControl.TopMost = true;
            JoinControl.Id = student.Id;
            JoinControl.ShowDialog();
        }
    }
}
