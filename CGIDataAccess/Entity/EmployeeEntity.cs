using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CGIDataAccess.Entity
{

    public class EmployeeEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
