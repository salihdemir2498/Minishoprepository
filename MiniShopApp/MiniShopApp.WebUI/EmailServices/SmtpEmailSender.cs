using System;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.EmailServices
{
    public class SmtpEmailSender : IEmailSender
    {
        //
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
