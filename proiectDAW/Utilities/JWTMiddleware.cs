using Microsoft.AspNetCore.Http;
using proiectDAW.Servicii;
using proiectDAW.Utilities.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Utilities
{
    public class JWTMiddleware
    {
        //sa treaca in start-up la urm middleware
        private readonly RequestDelegate _next;
        public async Task Invoke(HttpContext httpContext, IUserService userService, IJwt jwtUtils)
        {
            //Bearer -token- (facem split ca sa luam doar partea de final)
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            var userId = jwtUtils.ValidateJWTToken(token);

            if (userId != Guid.Empty)
            {
                httpContext.Items["User"] = userService.GetById(userId);
            }

            await _next(httpContext);
        }
    }
}
