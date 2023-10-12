using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Services.MailService
{
    public class EmailSetting
    {
        public EmailSetting()
        {
            Email = ConfigurationManager.AppSettings.Get("Email") ?? "";
            Password = ConfigurationManager.AppSettings.Get("Password") ?? "";
            Host = ConfigurationManager.AppSettings.Get("Host") ?? "";
            DisplayName = ConfigurationManager.AppSettings.Get("DisplayName") ?? "";
            Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port") ?? "587");
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; } 
        public int Port { set; get; }
        public string Host { set;get; }
    }
}
