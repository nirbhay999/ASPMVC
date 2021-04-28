using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Remote("PinCodeValid", "Asset")]
        public string Pincode { get; set; }

    }
}
