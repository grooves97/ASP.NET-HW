using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.DTOs;

namespace WebApplication10.Services
{
    public interface IEmailSenderServices
    {
        Task SendEmail(EmailMessageDTO emailMessage);
    }
}
