using CGIDataAccess.Entity;
using CGIDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CGIDataAccess.Concrete
{
    public class AssetRepo : IAsset
    {
        private MyAppDbContext _dbContext;

        public AssetRepo(MyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<AssetEntity> GetAllAssets()
        {
            return _dbContext.Assets.ToList();
        }
    }
}
