using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace eBookStore.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions emailOptions;

        public EmailSender(IOptions<EmailOptions> options)
        {
            emailOptions = options.Value;
            
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
           return Execute(emailOptions.CredentialEmail, emailOptions.CredentialPassword,subject, htmlMessage, email);            
        }

        private Task Execute(string CredentialEmail, string CredentialPassword, string subject, string msg, string email)
        {            
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("admin@huseyinkural.tech");
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = msg;
                smtp.Port = 587;
                smtp.Host = "smtp.huseyinkural.tech"; //for gmail host  
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(CredentialEmail, CredentialPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                return smtp.SendMailAsync(message);       
        }
    }
}
