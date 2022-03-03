using PrescriptionProjectAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Services
{
    public class EmailService
    {
        private readonly DataAccess _dataAccess;

        public EmailService(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async void SendEmail(string receiver)
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "dbassignmenttwopostgres@gmail.com",
                    Password = "ddujswjsnyfrvzrg"
                }
            };

            MailAddress FromEmail = new MailAddress("dbassignmenttwopostgres@gmail.com", "Db Assignment Demo");
            MailAddress ToEmail = new MailAddress(receiver, "Db Assignment Demo");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Prescription Reminder",
                Body = "This is an Email reminder from your pharmacy, letting you know that one of your"
                       + " prescriptions are about to run out."
            };

            Message.To.Add(ToEmail);
            try
            {
                await Client.SendMailAsync(Message);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task CheckPrescriptionExpirationDate()
        {
           var dailyPrescriptionReminders = await _dataAccess.GetDailyEmailPrescriptionReminders();
            foreach (var receiver in dailyPrescriptionReminders)
            {
                SendEmail(receiver.email);
            }
        }
    }
}
