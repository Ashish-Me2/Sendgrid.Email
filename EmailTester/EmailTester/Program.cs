using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace EmailApp
{
    class Program
    {
        //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
        static void Main(string[] args)
        {
            var msg = new SendGridMessage();
            var client = new SendGridClient("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");

            msg.SetFrom(new EmailAddress("ashish.mathur@live.com", "Ashish Mathur"));

            var recipients = new List<EmailAddress>
            {
                new EmailAddress("ashish.mathur@live.com", "Ashish Mathur"),
                new EmailAddress("ashish.me2@gmail.com", "Ashish Mathur"),
            };
            msg.AddTos(recipients);

            msg.SetSubject("Testing Sendgrid domain authentication");

            msg.AddContent(MimeType.Text, "Hello World plain text!");
            msg.AddContent(MimeType.Html, "<p>Hello World!</p>");
            client.SendEmailAsync(msg);
            Console.WriteLine("-- Done --");
            Console.ReadLine();
        }
    }
}
