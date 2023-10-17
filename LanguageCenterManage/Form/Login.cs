using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.Services.UserService;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LanguageCenterManage
{
    public partial class Login : MaterialForm
    {
        private UserService _userService;
        public Login()
        {
            _userService = new UserService();
            InitializeComponent();
        }
        public void ValidateEmail(string email)
        {
            try
            {
                MailAddress mailaddress = new MailAddress(email);
                errorProviderLogin.Clear();
            }
            catch (Exception ex)
            {
                errorProviderLogin.SetError(txtEmail, "Email không hợp lệ");
            }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter Username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeDashboard emplDashbooard = new EmployeeDashboard();
            emplDashbooard.Show();
            emplDashbooard.MdiParent = this.MdiParent;
            //var email = txtEmail.Text;
            //var password = txtPassword.Text;

            //var response = _userService.Login(email, password);
            //if (response == null)
            //{
            //    MessageBox.Show("Wrong email or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    USER.FirstName = response.FirstName;
            //    USER.LastName = response.LastName;
            //    USER.UserId = response.UserId;
            //    USER.Email = response.Email;

            //    EmployeeDashboard emplDashbooard = new EmployeeDashboard();
            //    emplDashbooard.Show();
            //    emplDashbooard.MdiParent = this.MdiParent;
            //}
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            string errMessage = errorProviderLogin.GetError(ctr);
            if (!string.IsNullOrEmpty(errMessage))
            {
                if (txtEmail.Text.Trim().Length == 0)
                {
                    errorProviderLogin.SetError(txtEmail, "Chưa nhập email");
                }
                else
                {
                    errorProviderLogin.Clear();
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            string errMessage = errorProviderLogin.GetError(ctr);
            if (!string.IsNullOrEmpty(errMessage))
            {
                if (txtPassword.Text.Trim().Length == 0)
                {
                    errorProviderLogin.SetError(txtPassword, "Chưa nhập email");
                }
                else
                {
                    errorProviderLogin.Clear();
                }
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail(txtEmail.Text);
        }
    }
}
