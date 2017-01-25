using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class OrderApartController : Controller
    {

        // GET: /OrderApart/
        public ActionResult Index()
        {
            var g = OrderApartMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /OrderApart/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var r = await OrderApartMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /OrderApart/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OrderApart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(OrderApartViewModel appart)
        {
            if (ModelState.IsValid)
            {
                appart.Id = Guid.NewGuid();
                await OrderApartMapping.FromBltoUiInser(appart);
                return RedirectToAction("Index");
            }

            return View(appart);
        }

        //
        // GET: /OrderApart/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {

            var editMap = await OrderApartMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /OrderApart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(OrderApartViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await OrderApartMapping.FromBltoUiEditAsync(appart);
                return RedirectToAction("Index");
            }
            return View(appart);
        }

        //
        // GET: /OrderApart/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var getFromR = await OrderApartMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /OrderApart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await OrderApartMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}