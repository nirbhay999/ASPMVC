using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CGIDataAccess.Entity
{
    public class AssetEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TagNumber { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
