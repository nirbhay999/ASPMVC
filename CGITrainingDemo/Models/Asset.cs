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
        [MaxLength(30,ErrorMessage ="name cannot be more than 30 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Asset description is required")]
        public string Description { get; set; }
    }
}
