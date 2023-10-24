using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
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
                MessageBox.Show("Enter missing fields", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            roleIdCb.Items.AddRange(_roles.Select(x => x.Id).ToArray());
            if (_user == null)
            {
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
                ChangePasswordBtn.Visible = false;
                txtIdStudent.Text = Guid.NewGuid().ToString().Substring(0, 8);
            }
            else
            {
                createBtn.Visible = false;
                passwordTb.Enabled = false;
                showpasswordBtn.Enabled = false;

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
                };
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
                _db.Users.Remove(_user);
                _db.SaveChanges();
                Close();
            }
        }
    }
}
