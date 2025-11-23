using AppRedSocial.Models.Settings;
using Microsoft.Extensions.Options;

namespace AppRedSocial.Services
{
    public class EmailService(IOptions<SmtpSettings> smtpOptions) : IEmailService
    {
        public void SendPasswordResetEmail(string toEmail, string body)
        {
            throw new NotImplementedException();
        }
    }
}
