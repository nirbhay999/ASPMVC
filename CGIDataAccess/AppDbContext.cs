using CGIDataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess
{
    public class AppDbContext:DbContext
    {
        public DbSet<AssetEntity> Assets { get; set; }
    }
}
