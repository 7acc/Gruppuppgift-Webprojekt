﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class FeatuerController : Controller
    {
        // GET: /Featuer/
        public ActionResult Index()
        {
            var g = FeaturesDataMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Featuer/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var r = await FeaturesDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Featuer/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Featuer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(FeaturesViewModel featur)
        {
            if (ModelState.IsValid)
            {
                featur.Id = Guid.NewGuid();
                await FeaturesDataMapping.FromBltoUiInser(featur);
                return RedirectToAction("Index");
            }

            return View(featur);
        }

        //
        // GET: /Featuer/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {

            var editMap = await FeaturesDataMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Featuer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(FeaturesViewModel adre)
        {
            if (ModelState.IsValid)
            {
                await FeaturesDataMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /Featuer/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var getFromR = await FeaturesDataMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Featuer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await FeaturesDataMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}