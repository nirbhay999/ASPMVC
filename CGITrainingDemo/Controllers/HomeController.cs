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
    public class HomeController : Controller
    {
        // FUnction , Action Method
        public IActionResult Index()
        {
           
            return View();
        }

       
    }
}
