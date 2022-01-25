using System;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;

namespace BuckyBook.Models
{
    public class EmailSender : IEmailSender
    {
      

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("NoReply@DotMastery.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));


            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

            //send email

           
                using (var emailClient = new SmtpClient())
                {
                try
                {
                    emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    emailClient.Authenticate("masterydotnet42@gmail.com", "DotNet321#");
                    emailClient.Send(emailToSend);

                }
                catch (Exception ex)
                {
                    throw new Exception("Unable to send email", ex);
                }
                finally
                {
                    emailClient.Disconnect(true);
                }
            }
           

            return Task.CompletedTask;
        }
    }
}

