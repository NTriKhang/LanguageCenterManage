using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Services.MailService
{
    public class MailRequest
    {
        public string ToEmail { set; get; }
        public string Subject { set; get; }
        public string Body { set; get; }    
    }
}
