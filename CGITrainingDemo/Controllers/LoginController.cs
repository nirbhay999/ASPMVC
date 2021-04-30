using CGIDataAccess;
using CGITrainingDemo.Attributes;
using CGITrainingDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Controllers
{
    /// <summary>
    /// new cooment
    /// </summary>
    [CustomExec]
    public class LoginController : Controller
    {
        public LoginController(MyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MyAppDbContext _dbContext { get; }

        public IActionResult Index()
        {
            
            var headers = HttpContext.Request.Headers.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            var correct = _dbContext.Employees.Any(x => x.Email == data.Email && x.Password == data.Password);
            if (correct)
            {
                HttpContext.Response.Cookies.Append("cgi-auth", data.Email);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("LoginError", "Incorrect user name or password");
            return View("Index");
        }
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("cgi-auth");
            return View("Index");
        }
    }
}
