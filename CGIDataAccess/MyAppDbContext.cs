using CGIDataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess
{
    public class MyAppDbContext:DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            :base(options)
        {

        }

        
        public DbSet<AssetEntity> Assets { get; set; }
       
    }
}
