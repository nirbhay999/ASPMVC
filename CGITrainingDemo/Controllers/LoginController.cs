using CGIDataAccess;
using CGITrainingDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Controllers
{
    public class LoginController : Controller
    {
        public LoginController(MyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MyAppDbContext _dbContext { get; }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            var correct = _dbContext.Employees.Any(x => x.Email == data.Email && x.Password == data.Password);
            if (correct)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("LoginError", "Incorrect user name or password");
            return View("Index");
        }
    }
}
