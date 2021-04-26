using CGIDataAccess.Entity;
using CGIDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess.Concrete
{
    public class AssetRepoMock : IAsset
    {
        public IEnumerable<AssetEntity> GetAllAssets()
        {
            throw new NotImplementedException();
        }
    }
}
