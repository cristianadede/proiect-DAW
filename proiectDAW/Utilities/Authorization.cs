using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Utilities
{
    public class AuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        private ICollection<Rol> _roles;
        public AuthorizationAttribute(params Rol[] roles)
        {
            _roles = roles;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var unathorizedStatusCodeObject = new JsonResult(new { Message = "Neautorizat" }) { StatusCode = StatusCodes.Status401Unauthorized };
            if (_roles == null)
            {
                context.Result = unathorizedStatusCodeObject;
            }

            var user = (Utilizator)context.HttpContext.Items["User"];

            if(user == null || _roles.Contains(user.Rol))
            {
                context.Result = unathorizedStatusCodeObject;
            }
         
        }
    }
}
