using SendMailApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp.Helpers
{
    public class SendMail
    {
        private SmtpClient _smtpClient;
        private string _fromAddress;

        public SendMail(Config _config)
        {
            _smtpClient = new SmtpClient
            {
                Host = _config.EmailSmtp,
                Port = _config.EmailPort,
                EnableSsl = _config.Ssl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(_config.Email, _config.Pwd),
                Timeout = 20000
            };
            _fromAddress = _config.Email;
        }
        public void Send(string mail, string body, string subject,bool ishtml)
        {
            using (var message = new MailMessage(_fromAddress, mail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = ishtml
            })
            {
                _smtpClient.Send(message);
            }
        }
    }
}
