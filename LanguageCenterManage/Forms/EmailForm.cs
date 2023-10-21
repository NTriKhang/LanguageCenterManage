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
    public partial class EmailForm : MaterialForm
    {
        private readonly IEmailService emailService;
        private readonly string ToEmail;
        public EmailForm(string toEmail)
        {
            emailService = new EmailService();
            ToEmail = toEmail;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isValidate())
            {
                MailRequest mailRequest = new MailRequest();
                mailRequest.Subject = SubjectTB.Text;
                mailRequest.Body = bodyTextbox.Text;
                mailRequest.ToEmail = ToEmail;
                emailService.SendEmail(mailRequest);
                MessageBox.Show("Send email success", "200", MessageBoxButtons.OK);
                Close();
            }
        }
        private bool isValidate()
        {
            if(SubjectTB.Text == "" || bodyTextbox.Text == "")
            {
                MessageBox.Show("Lack of information", "400", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
