using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class AppartmentPhotoController : Controller
    {
        public AppartmentPhotoMapping AppartmentPhotoMapping { get; set; }
        public AppartmentPhotoController()
        {
            AppartmentPhotoMapping = new AppartmentPhotoMapping();
        }
        // GET: /ApartmentPhoto/
        public ActionResult Index()
        {
            var g = AppartmentPhotoMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /ApartmentPhoto/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await AppartmentPhotoMapping.FromBltoUiGetById(id);
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
        public async Task<ActionResult> Create(AppartmentPhotoViewModel adre)
        {
            if (ModelState.IsValid)
            {

                await AppartmentPhotoMapping.FromBltoUiInser(adre);
                return RedirectToAction("Index");
            }

            return View(adre);
        }
        

        //
        // GET: /ApartmentPhoto/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await AppartmentPhotoMapping.FromBltoUiGetById(id);

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
        public async Task<ActionResult> Edit(AppartmentPhotoViewModel adre)
        {
            if (ModelState.IsValid)
            {
                await AppartmentPhotoMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /ApartmentPhoto/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await AppartmentPhotoMapping.FromBltoUiGetById(id);
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
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await AppartmentPhotoMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}