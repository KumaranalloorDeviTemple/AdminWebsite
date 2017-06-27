using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace kumaranalloordevitempleadminweb.Common
{
    public class EmailServices
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var iMessage = new SendGridMessage();
            iMessage.AddTo(email);
            iMessage.From = new EmailAddress("administrator@kumaranalloortemple.com", "Kumaranalloor Devi Temple");
            iMessage.Subject = subject;
            iMessage.HtmlContent = message;

            var credentials = new NetworkCredential(
                       ConfigurationManager.AppSettings["azuremailAccount"],
                       ConfigurationManager.AppSettings["azuremailPassword"]);

            // Create a Web transport for sending email.
            var transportWeb = new SendGrid.SendGridClient("3ad64126-9acb-4728-9a27-ce7feda4ab62");

            // Send the email.
            if (transportWeb != null)
            {
                return transportWeb.SendEmailAsync(iMessage);
            }
            else
            {
                return Task.FromResult(0);
            }
        }

    }
}