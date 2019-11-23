using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using WebApplication10.DTOs;

namespace WebApplication10.Services
{
    public class SmsSenderService : ISmsSenderServices
    {
        public Task SendSms(string phoneNumber)
        {
            const string accountSid = "AC7ee9ce3104b8f87e7caf3d1b17eb899e";
            const string authToken = "7585663101907a2ac2f550e48213d465";

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
                body: "Blah blah",
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber($"{phoneNumber}")
            );
            
        }
    }
}
