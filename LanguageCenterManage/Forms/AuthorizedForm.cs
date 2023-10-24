using LanguageCenterManage.Services.MailService;
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

namespace LanguageCenterManage.Forms
{
    public partial class AuthorizedForm : MaterialForm
    {
        public bool isAuthorized = false;
        private IEmailService emailService;
        private string _userEmail;
        private string _code;
        public AuthorizedForm(string userEmail)
        {
            emailService = new EmailService();
            _userEmail = userEmail;
            InitializeComponent();
        }

        private void AuthorizedForm_Load(object sender, EventArgs e)
        {
            //SendAuthorizedMessage();
        }
        private void SendAuthorizedMessage()
        {
            _code = Guid.NewGuid().ToString();
            var codeHash = BCrypt.Net.BCrypt.HashPassword(_code);

            MailRequest mailRequest = new MailRequest()
            {
                ToEmail = _userEmail,
                Subject = "Change your password",
                Body = codeHash
            };
            emailService.SendEmail(mailRequest);
        }

        private void SendAgainBtn_Click(object sender, EventArgs e)
        {
            SendAuthorizedMessage();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var userCode = codeTextbox.Text;
            if(BCrypt.Net.BCrypt.Verify(_code, userCode))
            {
                isAuthorized = true;
                Close();
            }
        }
    }
}
