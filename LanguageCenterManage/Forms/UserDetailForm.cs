using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using LanguageCenterManage.Services.PdfService;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LanguageCenterManage.Forms
{
    public partial class UserDetailForm : MaterialForm
    {
        private readonly AppDbContext _db;
        private User _user;
        private List<Role> _roles;
        public UserDetailForm()
        {
            _db = new AppDbContext();
            _roles = _db.Roles.ToList();
            InitializeComponent();
        }
        public UserDetailForm(string userId)
        {
            _db = new AppDbContext();
            _roles = _db.Roles.ToList();
            _user = _db.Users.FirstOrDefault(x => x.Id == userId);
            InitializeComponent();
        }
        private bool isValid()
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmailStudent.Text == ""
                || txtPhone.Text == "" || addressTextBox.Text == "" || roleIdCb.Text == ""
                || roleNameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txtEmailStudent.isValid)
            {
                MessageBox.Show("Invalid email", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!txtPhone.isValid)
            {
                MessageBox.Show("Invalid phone", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!dtBirth.isValid)
            {
                MessageBox.Show("User must be at least 18 years old", "400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            roleIdCb.Items.AddRange(_roles.Where(x => x.Name != utility.Admin).Select(x => x.Id).ToArray());
            if (_user == null)
            {
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
                ChangePasswordBtn.Visible = false;
                ExportIDCbtn.Visible = false;
                txtIdStudent.Text = Guid.NewGuid().ToString().Substring(0, 8);

            }
            else
            {
                createBtn.Visible = false;
                passwordTb.Enabled = false;
                showpasswordBtn.Visible = false;
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");

                passwordTb.Text = _user.PasswordHash;
                txtIdStudent.Text = _user.Id;
                txtEmailStudent.Text = _user.Email;
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                dtBirth.Value = _user.Birth;
                txtPhone.Text = _user.Phone;
                addressTextBox.Text = _user.Address;
                roleIdCb.Text = _user.RoleId;
                roleNameTb.Text = _roles.Where(x => x.Id == _user.RoleId).Select(x => x.Name).SingleOrDefault();
                if (_user.ImagePath != null)
                {
                    ImageNameTxt.Text = _user.ImagePath;
                    profileImageBox.ImageLocation = Path.Combine(resourePath, _user.ImagePath);
                }
                else
                {
                    profileImageBox.ImageLocation = Path.Combine(resourePath, "UserNoImage", "UserNoImage.jpg");
                }
                string RoleName = _db.Users
                .Where(m => m.Id == USER.UserId) 
                .Select(m => m.Role.Name).FirstOrDefault();
                if (RoleName != utility.Admin)
                {
                    roleIdCb.Enabled = false;
                }
            }
        }

        private void roleIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roleId = roleIdCb.Text;
            string roleName = _roles.Where(x => x.Id == roleId).FirstOrDefault().Name;
            if (roleName != null)
            {
                roleNameTb.Text = roleName;
            }
        }

        private void showpasswordBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpasswordBtn.Checked)
            {
                passwordTb.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTb.UseSystemPasswordChar = false;
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            AuthorizedForm authorizedForm = new AuthorizedForm(txtEmailStudent.Text);
            authorizedForm.ShowDialog();
            if (authorizedForm.isAuthorized)
            {
                passwordTb.Enabled = true;
                showpasswordBtn.Enabled = true;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var user = new User()
                {
                    Id = txtIdStudent.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmailStudent.Text,
                    Address = addressTextBox.Text,
                    Birth = dtBirth.Value,
                    Phone = txtPhone.Text,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(passwordTb.Text),
                    RoleId = roleIdCb.Text,
                    ImagePath = (ImageNameTxt.Text == string.Empty) ? null : ImageNameTxt.Text,
                };
                if (ImageNameTxt.Text.Length > 0)
                {
                    var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                    File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
                }
                _db.Users.Add(user);
                _db.SaveChanges();
                MessageBox.Show("Create successfully", "User was added to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                _user.Id = txtIdStudent.Text;
                _user.FirstName = txtFirstName.Text;
                _user.LastName = txtLastName.Text;
                _user.Email = txtEmailStudent.Text;
                _user.Address = addressTextBox.Text;
                _user.Birth = dtBirth.Value;
                _user.Phone = txtPhone.Text;
                _user.RoleId = roleIdCb.Text;
                _user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(passwordTb.Text);
                if (ImageNameTxt.Text != "" && _user.ImagePath != ImageNameTxt.Text)
                {
                    var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                    var oldImageName = _db.Students.Where(x => x.Id == _user.Id)
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
                    _user.ImagePath = ImageNameTxt.Text;
                    File.Copy(ImageLocation, Path.Combine(resourePath, ImageNameTxt.Text), true);
                }
                _db.SaveChanges();
                MessageBox.Show("Update successfully", "User was updated to db", MessageBoxButtons.OK);
                Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete it ?", "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if(!_db.Bills.Any(x => x.UserConfirmId == _user.Id))
                {
                    _db.Users.Remove(_user);
                    _db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Conflict bill");
                    return;
                }
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

        private void ExportIDCbtn_Click(object sender, EventArgs e)
        {
            PdfService pdfService = new PdfService();
            var response = pdfService.ExportIDC(_user, _db.Roles.Where(x => x.Id == _user.RoleId)
                                                                 .Select(x => x.Name)
                                                                 .SingleOrDefault());
            if (response == 200)
            {
                MessageBox.Show("Export successfully", "200", MessageBoxButtons.OK);
                Close();
            }
            else if (response == 400)
            {
                MessageBox.Show("Lack of information", "400", MessageBoxButtons.OK);
                Close();
            }
            else if (response == 500)
            {
                MessageBox.Show("System error", "500", MessageBoxButtons.OK);
                Close();

            }
        }
    }
}
