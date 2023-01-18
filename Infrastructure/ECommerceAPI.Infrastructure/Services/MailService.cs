using ECommerceAPI.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Infrastructure.Services
{
    public class MailService : IMailService
    {
        public Task SendMessageAsync(string to, string subject, string body, bool isBodyHtml = true)
        {

        }

        public Task SendMessageAsync(string[] tos, string subject, string body, bool isBodyHtml = true)
        {
            MailMessage mail = new();
            mail.IsBodyHtml = isBodyHtml;
            foreach (var to in tos)
            {
                mail.To.Add(to);
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new("domain", "DisplayName", System.Text.Encoding.UTF8);

            SmtpClient smtp = new();
        }
    }
}
