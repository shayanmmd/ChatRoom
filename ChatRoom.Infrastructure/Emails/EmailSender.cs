using ChatRoom.Application.Contracts.Email;
using ChatRoom.Application.Models.Email;
using ChatRoom.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ChatRoom.Infrastructure.Emails
{
    public class EmailSender : IEmail
    {
        public async Task<BaseResponse> SendEmailAsync(Email email)
        {
            var res = new BaseResponse();
            try
            {
                var client = new SendGridClient(EmailSetting.ApiKey);
                var to = new EmailAddress(email.To);
                var from = new EmailAddress
                {
                    Name = EmailSetting.FromName,
                    Email = EmailSetting.FromAddress
                };
                var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
                var response = await client.SendEmailAsync(message);
                if(response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    res.AddError("ایمیل با موفقیت ارسال نشد");
                    return res;
                }
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
