using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHW11.DataAccess;
using WebApplicationHW11.Models;

namespace WebApplicationHW11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserContext userContext;

        public AuthController(UserContext userContext)
        {
            this.userContext = userContext;
        }

        [HttpPost]
        public async Task<ActionResult> AddUser(User user)
        {
            userContext.Users.Add(user);
            await userContext.SaveChangesAsync();
            return Content(user.Id + " - id " + user.MyHeaderKey + " - Key");
        }
    }
}