using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Services.MailService
{
    public interface IEmailService
    {
        void SendEmail(MailRequest mailRequest);
    }

    public class EmailService : IEmailService
    {
        private EmailSetting emailSetting;
        public EmailService()
        {
            emailSetting = new EmailSetting();
        }
        void IEmailService.SendEmail(MailRequest mailRequest)
        {
            try
            {
                var email = new MimeMessage();
                
                email.From.Add(new MailboxAddress(emailSetting.DisplayName, emailSetting.Email));
                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;
                
                var body = new BodyBuilder();
                body.HtmlBody = mailRequest.Body;
                email.Body = body.ToMessageBody();

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(emailSetting.Host, emailSetting.Port, MailKit.Security.SecureSocketOptions.StartTls);
                    smtp.Authenticate(emailSetting.Email, emailSetting.Password);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
