using ChatRoom.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.Models;
namespace ChatRoom.Application.Contracts.Email
{
    public interface IEmail
    {
        Task<BaseResponse> SendEmailAsync(Models.Email.Email email);
    }
}
