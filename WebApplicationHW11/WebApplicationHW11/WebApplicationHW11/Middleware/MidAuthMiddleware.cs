using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationHW11.DataAccess;

namespace WebApplicationHW11
{
    public class MidAuthMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public MidAuthMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            UserContext userContext = context.RequestServices.GetService(typeof(UserContext)) as UserContext;
            var headerKey = context.Request.Headers["MyHeaderKey"].ToString();
            var path = context.Request.Path.ToString();
            var users = userContext.Users.FirstOrDefault(x => x.MyHeaderKey == headerKey);

            if (users != null || path == "/api/auth")
            {
                await requestDelegate(context);
            }
            else
            {
                await context.Response.WriteAsync("User not authorized");
            }
        }
    }
}
