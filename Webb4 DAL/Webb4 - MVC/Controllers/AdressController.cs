using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class AdressController : Controller
    {
        // GET: /Adress/
        public ActionResult Index()
        {
            var g = AdressMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Adress/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var r = await AdressMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Adress/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Adress/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AdressViewModel adre)
        {
            if (ModelState.IsValid)
            {
                adre.Id = Guid.NewGuid();
                await AdressMapping.FromBltoUiInser(adre);
                return RedirectToAction("Index");
            }

            return View(adre);
        }

        //
        // GET: /Adress/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {

            var editMap = await AdressMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Adress/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AdressViewModel adre)
        {
            if (ModelState.IsValid)
            {
                await AdressMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /Adress/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var getFromR = await AdressMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Adress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await AdressMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}