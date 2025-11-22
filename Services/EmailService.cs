using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace CollegeManagementSystem.Services
{
    public class EmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var smtpSection = _config.GetSection("SmtpSettings");
            var smtpClient = new SmtpClient(smtpSection["Host"])
            {
                Port = int.Parse(smtpSection["Port"]!),
                Credentials = new NetworkCredential(smtpSection["User"], smtpSection["Pass"]),
                EnableSsl = true
            };

            var mail = new MailMessage(smtpSection["User"]!, to, subject, body)
            {
                IsBodyHtml = true
            };

            await smtpClient.SendMailAsync(mail);
        }
    }
}
