using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.DataAccess;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly UserContext userContext;

        public ServiceController(UserContext userContext)
        {
            this.userContext = userContext;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser([FromQuery(Name = "id")]Guid userId)
        {
            var userFirst = await userContext.Users.FindAsync(userId);

            if (userFirst == null)
            {
                return NotFound();
            }

            return userFirst;
        }
    }
}