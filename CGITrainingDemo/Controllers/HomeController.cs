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
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        private List<Employee> GetEmployees()
        {
            var item = new Employee();
            
            return new List<Employee>
            {
                new Employee
                {
                    EmployeeId=1,
                    Name="Name Man1",
                    Position="Developer"
                },
                new Employee
                {
                    EmployeeId=2,
                    Name="Name Man2",
                    Position="Developer"
                },
                new Employee
                {
                    EmployeeId=3,
                    Name="Name Man2",
                    Position="Developer"
                }
            };
        }
        // FUnction , Action Method
        public IActionResult Index()
        {
            var emps = this.GetEmployees();

            // A controller will almost always return a view
            // 1.Search the views folder
            // 2. Search for the folder by the name of controller
            // 3. Search for the view by the name of action method
            return View(emps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
