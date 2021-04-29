using CGIDataAccess.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CGITrainingDemo.Models;
using CGIDataAccess.Entity;
using CGIDataAccess.Interface;
using Microsoft.Extensions.Logging;
using CGIDataAccess;
using System.Net.Http;
using Newtonsoft.Json;

namespace CGITrainingDemo.Controllers
{
    public class AssetController : Controller
    {
        private IAsset _assetRepo;
        private ILogger<AssetController> _logger;
        private MyAppDbContext _dbContext;

        public AssetController(IAsset assetRepo, ILogger<AssetController> logger, MyAppDbContext dbContext)
        {
            _assetRepo = assetRepo;
            _logger = logger;
            _dbContext = dbContext;
            
        }

        private Asset MapDTO(AssetEntity data)
        {
            var ret = new Asset
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                TagNumber=data.TagNumber
            };
            return ret;
        }
        // GET: AssetController
        public ActionResult Index()
        {
            try
            {
                var assetsEntity = _assetRepo.GetAllAssets();
                var assetDTo = assetsEntity.Select(x => MapDTO(x));
                return View("ListAssets", assetDTo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return View("CustomError");
            }
        }

        [HttpPost]
        public ActionResult CreateAsset(Asset postData)
        {
            var assetEntity = new AssetEntity();
            assetEntity.Description = postData.Description;
            assetEntity.Name = postData.Name;
            assetEntity.TagNumber = postData.TagNumber;
            assetEntity.CreatedOn = DateTime.UtcNow;

            _dbContext.Assets.Add(assetEntity);
            _dbContext.SaveChanges();

            // logic to insert this record in DB
            ViewData["Entity"] = "Asset";
            return View("Success");
        }

        

        public ActionResult CheckTagUniqueness(string tagNumber,int id)
        {
           var entity = _dbContext.Assets.Find(id);
            if(entity!=null && entity.TagNumber == tagNumber)
            {
                return Json(true);
            }

            var tagExists = _dbContext.Assets.Any(x => x.TagNumber == tagNumber);
            if (tagExists)
            {
                return Json($"Tag number {tagNumber} already exist");
            }
            return Json(true);
        }

        public ActionResult Create()
        {
            return View("CreateAsset");
        }
       
        public async Task<IActionResult> Edit(int id)
        {
            var asset =await _dbContext.Assets.FindAsync(id);
            var assetDTO = MapDTO(asset);
            return View("EditAsset", assetDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsset(Asset data)
        {
            var entity = await _dbContext.Assets.FindAsync(data.Id);
            entity.Name = data.Name;
            entity.Description = data.Description;
            entity.TagNumber = data.TagNumber;
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var asset = await _dbContext.Assets.FindAsync(id);
            _dbContext.Remove(asset);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }

    
}
