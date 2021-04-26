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

namespace CGITrainingDemo.Controllers
{
    public class AssetController : Controller
    {
        private IAsset _assetRepo;

        public AssetController(IAsset assetRepo)
        {
            _assetRepo = assetRepo;
        }

        private Asset MapDTO(AssetEntity data)
        {
            var ret = new Asset
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description
            };
            return ret;
        }
        // GET: AssetController
        public ActionResult Index()
        {
            var assetsEntity = _assetRepo.GetAllAssets();
            var assetDTo = assetsEntity.Select(x => MapDTO(x));
            return View("ListAssets", assetDTo);
        }

        // GET: AssetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AssetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AssetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
