﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class SizeController : Controller
    {
        public SizeDataMapping SizeDataMapping { get; set; }
        public SizeController()
        {
            SizeDataMapping = new SizeDataMapping();
        }
        // GET: /SizeData/
        public ActionResult Index()
        {
            var g = SizeDataMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /SizeData/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await SizeDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /SizeData/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SizeData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SizeViewModel size)
        {
            if (ModelState.IsValid)
            {
               
                await SizeDataMapping.FromBltoUiInser(size);
                return RedirectToAction("Index");
            }

            return View(size);
        }

        //
        // GET: /SizeData/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await SizeDataMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /SizeData/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SizeViewModel size)
        {
            if (ModelState.IsValid)
            {
                await SizeDataMapping.FromBltoUiEditAsync(size);
                return RedirectToAction("Index");
            }
            return View(size);
        }

        //
        // GET: /SizeData/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await SizeDataMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /SizeData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await SizeDataMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}