using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Attributes
{
    public class CGIAuhtorizeAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var loggedIn = context.HttpContext.Request.Cookies.Any(x => x.Key == "cgi-auth");
            if (!loggedIn)
            {
                context.Result = new RedirectToActionResult("Index", "Login",null);
            }
           
            base.OnActionExecuting(context);
        }

        
    }
}
