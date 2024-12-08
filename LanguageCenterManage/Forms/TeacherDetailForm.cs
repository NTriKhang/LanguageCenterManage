using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using LanguageCenterManage.Services.PdfService;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LanguageCenterManage.Forms
{
    public partial class TeacherDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string Id { get; set; }
        private Teacher teacher;
        public TeacherDetailForm()
        {
            InitializeComponent();
            Load += TeacherDetailForm_Load;
        }
        public void showTeacher()
        {
            var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
            teacher = db.Teachers.Where(x => x.Id == Id).FirstOrDefault();
            if(teacher != null)
            {
                txtIdTeacher.Text = teacher.Id;
                txtFirstName.Text = teacher.FirstName;
                txtLastName.Text = teacher.LastName;
                txtAddress.Text = teacher.Address;
                txtEmailTeacher.Text = teacher.Email;
                txtPhone.Text = teacher.Phone;
                if (teacher.ImagePath != null)
                {
                    ImageNameTxt.Text = teacher.ImagePath;
                    profileImageBox.ImageLocation = Path.Combine(resourePath, teacher.ImagePath);
                }
                else
                {
                    profileImageBox.ImageLocation = Path.Combine(resourePath, "UserNoImage", "UserNoImage.jpg");
                }
                btnAdd.Visible = false;
            }
            else
            {
                txtIdTeacher.Text = Guid.NewGuid().ToString().Substring(0, 7);
                ExportIDCbtn.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnSendEmail.Visible = false;
            }
        }
        public void insertTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.Id = txtIdTeacher.Text;
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.Email = txtEmailTeacher.Text;
            teacher.Birth = dtBirth.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhone.Text;
            teacher.ImagePath = (ImageNameTxt.Text == string.Empty) ? null : ImageNameTxt.Text;
            if (ImageNameTxt.Text.Length > 0)
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
            }
            db.Teachers.Add(teacher);
            db.SaveChanges();
        }
        public void updateTeacher()
        {
            teacher.Id = txtIdTeacher.Text;
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.Email = txtEmailTeacher.Text;
            teacher.Birth = dtBirth.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhone.Text;

            if (ImageNameTxt.Text != "" && teacher.ImagePath != ImageNameTxt.Text)
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                var oldImageName = db.Students.Where(x => x.Id == teacher.Id)
                                    .Select(x => x.ImagePath)
                                    .SingleOrDefault();
                if (oldImageName != null)
                {
                    var oldImagePath = Path.Combine(resourePath, oldImageName);
                    if (File.Exists(oldImagePath))
                    {
                        File.Delete(oldImagePath);
                    }
                }
                teacher.ImagePath = ImageNameTxt.Text;
                File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
            }
            db.SaveChanges();
        }
        private bool isModelValid()
        {
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtEmailTeacher.Text.Trim() == ""
                || txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            else if (!txtEmailTeacher.isValid)
            {
                MessageBox.Show("Invalid email", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txtPhone.isValid)
            {
                MessageBox.Show("Invalid phone", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!dtBirth.isValid)
            {
                MessageBox.Show("Teacher must be at least 18 years old", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void TeacherDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TeacherDetailForm_Load(object sender, EventArgs e)
        {
            showTeacher();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isModelValid())
            {
                insertTeacher();
                MessageBox.Show("Create successfully", "Teacher was added to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(isModelValid())
            {
                updateTeacher();
                MessageBox.Show("Update successfully", "Teacher was updated to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                if(!db.Schedules.Any(x => x.TeacherId == Id))
                {
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Shedule exists", "error");
                    return;
                }
            }
        }

        private void ExportIDCbtn_Click(object sender, EventArgs e)
        {
            PdfService pdfService = new PdfService();
            var response = pdfService.ExportIDC(teacher, "Teacher");
            if (response == 200)
            {
                Close();
                MessageBox.Show("Export successfully", "200", MessageBoxButtons.OK);
            }
            else if (response == 400)
            {
                Close();
                MessageBox.Show("Lack of information", "400", MessageBoxButtons.OK);
            }
            else if (response == 500)
            {
                Close();
                MessageBox.Show("System error", "500", MessageBoxButtons.OK);
            }
        }
        private string ImageLocation = "";
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = fileDialog.FileName;
                    string imageName = fileDialog.SafeFileName;

                    ImageNameTxt.Text = Guid.NewGuid() + imageName;

                    profileImageBox.ImageLocation = ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error have occured", "400", MessageBoxButtons.OK);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm(txtEmailTeacher.Text);
            emailForm.TopMost = true;
            emailForm.ShowDialog();
        }
    }
}
