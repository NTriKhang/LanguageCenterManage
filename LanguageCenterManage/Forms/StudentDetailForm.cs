using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.IO;
using System.Reflection;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LanguageCenterManage.Services.PdfService;

namespace LanguageCenterManage
{
    public partial class StudentDetailForm : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        public string Id { get; set; }
        private Student student;
        private bool isImageChange = false;
        public StudentDetailForm()
        {
            InitializeComponent();
            Load += StudentDetailForm_Load;
        }
        public void ShowStudent()
        {
            var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
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

                if (student.ImagePath != null)
                {
                    ImageNameTxt.Text = student.ImagePath;
                    profileImageBox.ImageLocation = Path.Combine(resourePath, student.ImagePath);
                }
                else
                {
                    profileImageBox.ImageLocation = Path.Combine(resourePath, "UserNoImage", "UserNoImage.jpg");
                }
                btnAdd.Visible = false;
            }
            else
            {
                txtIdStudent.Text = Guid.NewGuid().ToString().Substring(0, 7);
                profileImageBox.ImageLocation = Path.Combine(resourePath, "UserNoImage", "UserNoImage.jpg");
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnSendEmail.Visible = false;
                btnJoin.Visible = false;
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
            stu.ImagePath = (ImageNameTxt.Text == string.Empty) ? null : ImageNameTxt.Text;
            if (ImageNameTxt.Text.Length > 0)
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
            }
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

            if (ImageNameTxt.Text != "" && student.ImagePath != ImageNameTxt.Text)
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                var oldImageName = db.Students.Where(x => x.Id == student.Id)
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
                student.ImagePath = ImageNameTxt.Text;
                File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
            }
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
                if (!db.Joins.Any(x => x.StudentId == Id))
                {
                    if (student.ImagePath != null)
                    {
                        var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                        var imagePath = Path.Combine(resourePath, student.ImagePath);
                        if (File.Exists(imagePath))
                            File.Delete(imagePath);
                    }
                    db.Students.Remove(student);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("students are jointing in the course", "Error");
                    return;
                }
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

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            PdfService pdfService = new PdfService();
            var response = pdfService.ExportIDC(student, "Student");
            if(response == 200)
            {
                Close();
                MessageBox.Show("Export successfully", "200", MessageBoxButtons.OK);
            }
            else if(response == 400)
            {
                Close();
                MessageBox.Show("Lack of information", "400", MessageBoxButtons.OK);
            }
            else if(response == 500)
            {
                Close();
                MessageBox.Show("System error", "500", MessageBoxButtons.OK);
            }
        }

        private void ImageNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void profileImageBox_Click(object sender, EventArgs e)
        {

        }
    }
}
