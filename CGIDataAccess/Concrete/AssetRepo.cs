using CGIDataAccess.Entity;
using CGIDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGIDataAccess.Concrete
{
    public class AssetRepo : IAsset
    {
        public IEnumerable<AssetEntity> GetAllAssets()
        {
            return new List<AssetEntity>
            {
                new AssetEntity
                {
                    Id=1,
                    Name="Laptop",
                    Description="A dell laptop mode xsp13",
                    CreatedOn=DateTime.UtcNow
                },
                new AssetEntity
                {
                    Id=2,
                    Name="Mouse",
                    Description="A mouse",
                    CreatedOn=DateTime.UtcNow
                },
                new AssetEntity
                {
                    Id=1,
                    Name="Headphones",
                    Description="A headphone",
                    CreatedOn=DateTime.UtcNow
                }
            };
        }
    }
}
