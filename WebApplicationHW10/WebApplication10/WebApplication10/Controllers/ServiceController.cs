using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using Newtonsoft.Json;
using WebApplication10.DTOs;
using WebApplication10.Services;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IEntitySaverServices entitySaverServices;
        private readonly ISmsSenderServices smsSenderServices;
        private readonly IEmailSenderServices emailSenderServices;

        public ServiceController(IEntitySaverServices entitySaverServices, ISmsSenderServices smsSenderServices, IEmailSenderServices emailSenderServices)
        {
            this.entitySaverServices = entitySaverServices;
            this.smsSenderServices = smsSenderServices;
            this.emailSenderServices = emailSenderServices;
        }

        [HttpPost]
        public async Task<IActionResult> SaveEntity(EntityDTO entity)
        {
            await entitySaverServices.SaveEntity(entity);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SaveEmail(EmailMessageDTO emailMessage)
        {
            await emailSenderServices.SendEmail(emailMessage);
            return Ok();
        }

        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetCodeVerification(string phoneNumber)
        {
            await smsSenderServices.SendSms(phoneNumber);
            return Ok();
        }
    }
}