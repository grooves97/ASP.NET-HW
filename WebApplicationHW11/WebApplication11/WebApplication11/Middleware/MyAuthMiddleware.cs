using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DataAccess;

namespace WebApplication11.Middleware
{
    public class MyAuthMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public MyAuthMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            UserContext userContext = context.RequestServices.GetService(typeof(UserContext)) as UserContext;
            var headerKey = context.Request.Headers["MyHeaderKey"].ToString();
            //var path = context.Request.Path.ToString();
           
            
            var users = userContext.Users.FirstOrDefault(x => x.MyHeaderKey.ToString() == headerKey);

            if (users != null)
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
