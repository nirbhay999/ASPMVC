using CGITrainingDemo.Attributes;
using CGITrainingDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Controllers
{
    [CGIAuhtorize]
    public class HomeController : Controller
    {
        
        // FUnction , Action Method
        public IActionResult Index()
        {
           
            var supportInfo = new SupportInfo
            {
                Address = "New Delhi , India",
                PhoneNumber = "999999999",
                Email = "support@org.com"
            };
            return View(supportInfo);
        }

       
    }
}
