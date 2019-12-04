using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAslanAuth(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyAuthMiddleware>();
        }
    }
}
