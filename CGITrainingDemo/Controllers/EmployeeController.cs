using CGITrainingDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CGITrainingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public EmployeeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> PinCodeValid(string pinCode)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://api.postalpincode.in/pincode/{pinCode}");
            var result = await response.Content.ReadAsStringAsync();
            var result1 = result.Trim('[', ']');
            var actualResult = JsonConvert.DeserializeObject<PincodeRes>(result1);
            if (actualResult.Status == "Success")
            {
                return Json(true);
            }
            else
            {
                return Json($"Pincode: {pinCode} is not valid");
            }

        }
    }
}
