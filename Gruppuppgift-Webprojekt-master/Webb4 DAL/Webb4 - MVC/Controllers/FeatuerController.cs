﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class FeatuerController : Controller
    {
        public FeaturesMapping FeaturesMapping { get; set; }
        public FeatuerController()
        {
            FeaturesMapping = new FeaturesMapping();
        }
        // GET: /Featuer/
        public ActionResult Index()
        {
            var g = FeaturesMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Featuer/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await FeaturesMapping.FromBltoUiGetById(id);
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
               
                await FeaturesMapping.FromBltoUiInser(featur);
                return RedirectToAction("Index");
            }

            return View(featur);
        }

        //
        // GET: /Featuer/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await FeaturesMapping.FromBltoUiGetById(id);

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
                await FeaturesMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /Featuer/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await FeaturesMapping.FromBltoUiGetById(id);
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
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await FeaturesMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}