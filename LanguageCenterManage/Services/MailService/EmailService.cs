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
        Task SendEmailAsync(MailRequest mailRequest);
    }

    public class EmailService : IEmailService
    {
        private EmailSetting emailSetting;
        public EmailService()
        {
            emailSetting = new EmailSetting();
        }
        async Task IEmailService.SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(emailSetting.Email);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;

            var body = new BodyBuilder();
            body.HtmlBody = mailRequest.Body;
            email.Body = body.ToMessageBody();
                            
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(emailSetting.Host, emailSetting.Port, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(emailSetting.Email, emailSetting.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }
    }
}
