using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess.Entity
{
    public class AssetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
