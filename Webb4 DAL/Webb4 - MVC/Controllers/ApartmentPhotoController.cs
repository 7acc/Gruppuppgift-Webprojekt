using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class ApartmentPhotoController : Controller
    {
        // GET: /ApartmentPhoto/
        public ActionResult Index()
        {
            var g = ApartmentPhotoDataMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /ApartmentPhoto/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var r = await ApartmentPhotoDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /ApartmentPhoto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ApartmentPhoto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ApartmentPhotoViewModel adre)
        {
            if (ModelState.IsValid)
            {
                adre.Id = Guid.NewGuid();
                await ApartmentPhotoDataMapping.FromBltoUiInser(adre);
                return RedirectToAction("Index");
            }

            return View(adre);
        }

        //
        // GET: /ApartmentPhoto/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {

            var editMap = await ApartmentPhotoDataMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /ApartmentPhoto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ApartmentPhotoViewModel adre)
        {
            if (ModelState.IsValid)
            {
                await ApartmentPhotoDataMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /ApartmentPhoto/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var getFromR = await ApartmentPhotoDataMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /ApartmentPhoto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await ApartmentPhotoDataMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}