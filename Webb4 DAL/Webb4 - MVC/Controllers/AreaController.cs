using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class AreaController : Controller
    {

        public AreaMapping AreaMapping { get; set; }
        public AreaController()
        {
            AreaMapping = new AreaMapping();
        }
        // GET: /Area/
        public ActionResult Index()
        {
            var g = AreaMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Area/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await AreaMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Area/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Area/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AreaViewModel area)
        {
            if (ModelState.IsValid)
            {
               
                await AreaMapping.FromBltoUiInser(area);
                return RedirectToAction("Index");
            }

            return View(area);
        }

        //
        // GET: /Area/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await AreaMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Area/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AreaViewModel area)
        {
            if (ModelState.IsValid)
            {
                await AreaMapping.FromBltoUiEditAsync(area);
                return RedirectToAction("Index");
            }
            return View(area);
        }

        //
        // GET: /Area/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await AreaMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Area/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await AreaMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}