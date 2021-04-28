using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.Models
{
    public class Asset
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Asset name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Asset description is required")]
        public string Description { get; set; }
        [Required]
        [Remote("CheckTagUniqueness","Asset")]
        public string TagNumber { get; set; }
        [Remote("PinCodeValid", "Asset")]
        public string Pincode { get; set; }
    }
}
