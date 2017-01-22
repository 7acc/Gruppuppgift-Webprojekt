
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer;

namespace Webb4___MVC.Controllers
{
    
    public class AppartmentController : Controller
    {

        // GET: /Apartment/
        public ActionResult Index()
        {
            var g = ApartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Apartment/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var r = await ApartmentMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Apartment/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Apartment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppartmentDataViewModel appart)
        {
            if (ModelState.IsValid)
            {
                appart.AppartmentId = Guid.NewGuid();
                await ApartmentMapping.FromBltoUiInser(appart);
                return RedirectToAction("Index");
            }

            return View(appart);
        }

        //
        // GET: /Apartment/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {

            var editMap = await ApartmentMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Apartment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AppartmentDataViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await ApartmentMapping.FromBltoUiEditAsync(appart);
                return RedirectToAction("Index");
            }
            return View(appart);
        }

        //
        // GET: /Apartment/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var getFromR = await ApartmentMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Apartment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await ApartmentMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}