using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class FormHousingController : Controller
    {
        public HousingTypeMapping HousingTypeMapping { get; set; }
        public FormHousingController()
        {
            HousingTypeMapping = new HousingTypeMapping();
        }
        // GET: /FormHousing/
        public ActionResult Index()
        {
            var g = HousingTypeMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /FormHousing/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await HousingTypeMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /FormHousing/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FormHousing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(HousingTypeViewModel housing)
        {
            if (ModelState.IsValid)
            {
               
                await HousingTypeMapping.FromBltoUiInser(housing);
                return RedirectToAction("Index");
            }

            return View(housing);
        }

        //
        // GET: /FormHousing/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await HousingTypeMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /FormHousing/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(HousingTypeViewModel housing)
        {
            if (ModelState.IsValid)
            {
                await HousingTypeMapping.FromBltoUiEditAsync(housing);
                return RedirectToAction("Index");
            }
            return View(housing);
        }

        //
        // GET: /FormHousing/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await HousingTypeMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /FormHousing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await HousingTypeMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}