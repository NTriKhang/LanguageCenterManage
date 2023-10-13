using LanguageCenterManage.Services.UserService;
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

namespace LanguageCenterManage
{
    public partial class Login : Dashboard
    {
        private UserService _userService;
        public Login()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Enter Username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

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
            if(showPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var response = _userService.Login(email, password);
            if(response == null)
            {

            }
            else
            {
                USER.FirstName = response.FirstName;
                USER.LastName = response.LastName;
                USER.UserId = response.UserId;
                USER.Email = response.Email;
            }
        }
    }
}
