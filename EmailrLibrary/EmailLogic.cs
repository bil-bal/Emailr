using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace EmailrLibrary
{
    public class EmailLogic
    {
        public static BindingList<string> logs = new BindingList<string>();
        private static bool mailCreation;
        private static string output = "";

        public static string SendEmail(EmailModel em, PersonModel p, SmtpClient smtp, string senderEmailAddress)
        {
            mailCreation = true;
            using (MailMessage message = CreateMessage(em, senderEmailAddress, p))
            {
                if (mailCreation)
                {
                    smtp.Send(message);
                    output = "Sending complete.";
                }
                else
                {
                    output = $"Error while sending mail to {p.EmailAddress}";
                }                
            }

            return output;
        }

        public static SmtpClient CreateSmtp(string smtpHost, int smtpPort, string senderEmailAddress, string password)
        {
            SmtpClient smtp = new SmtpClient();

            smtp.Host = smtpHost;
            smtp.Port = smtpPort;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential(senderEmailAddress, password);

            return smtp;
        }

        public static MailMessage CreateMessage(EmailModel em, string senderEmailAddress, PersonModel p)
        {
            MailAddress from = new MailAddress(senderEmailAddress, em.From);
            MailAddress to = new MailAddress(p.EmailAddress, $"{p.FirstName} {p.LastName}");

            MailMessage message = new MailMessage(from, to);

            message.Body = ReplaceKeywords(em, p, em.Content);
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = ReplaceKeywords(em, p, em.Subject);
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            if (em.Attachements.Count > 0)
            {
                message = AddAttachments(em, p, message);
            }

            if (em.Image.Length != 0)
            {
                message = AddImage(em, message);
            }

            return message;
        }

        public static MailMessage AddAttachments(EmailModel em, PersonModel p, MailMessage message)
        {
            Attachment att;
            
            foreach (string attPath in em.Attachements)
            {
                try
                {
                    att = new Attachment(ReplaceKeywords(em, p, attPath));
                    message.Attachments.Add(att);
                }
                catch (Exception)
                {
                    logs.Add($"Error while adding {ReplaceKeywords(em, p, attPath)} to Email to {p.EmailAddress}.");
                    mailCreation = false;
                }
            }
            
            return message;
        }

        public static MailMessage AddImage(EmailModel em, MailMessage message)
        {
            Attachment img;
            try
            {
                img = new Attachment(em.Image);
                img.ContentId = "companyLogo";
                message.Attachments.Add(img);
            }
            catch (Exception)
            {
                logs.Add("Error while adding image.");
                mailCreation = false;
            }

            return message;
        }

        public static string ReplaceKeywords(EmailModel em, PersonModel p, string txt)
        {
            List<string> keywords = new List<string>{"-firstname-", "-lastname-", "-year-", "-month-", "-from-", "-personalid-"};
            List<string> replacements = new List<string>{p.FirstName, p.LastName, em.Year, em.Month, em.From, p.PersonalId};
            
            for (int i = 0; i < keywords.Count; i++)
            {
                txt = Regex.Replace(txt, keywords[i], replacements[i]);
            }

            return txt;
        }
    }
}
