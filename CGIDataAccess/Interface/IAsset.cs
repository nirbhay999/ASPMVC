using CGIDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess.Interface
{
   public interface IAsset
    {
        IEnumerable<AssetEntity> GetAllAssets();
    }
}
