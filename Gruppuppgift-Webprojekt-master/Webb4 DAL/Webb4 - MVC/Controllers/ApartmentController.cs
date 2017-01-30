
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    
    public class ApartmentController : Controller
    {
        private AppartmentMapping AppartmentMapping { get; set; }
        private AppartmentPhotoMapping AppartmentPhotoMapping { get; set; }
        private DistrictMapping DistrictMapping { get; set; }
        private FeaturesMapping FeaturesMapping { get; set; }
        private HousingTypeMapping HousingTypeMapping { get; set; }
        public ApartmentController()
        {
            AppartmentMapping = new AppartmentMapping();
            AppartmentPhotoMapping = new AppartmentPhotoMapping();
            DistrictMapping = new DistrictMapping();
            FeaturesMapping = new FeaturesMapping();
            HousingTypeMapping = new HousingTypeMapping();
        }

        // GET: /Apartment/
        public ActionResult Index()
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Apartment/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await AppartmentMapping.FromBltoUiGetById(id);
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
            //ViewBag.ApartmentPhoto = new SelectList(AppartmentPhotoMapping.FromBltoUiGetAll(), "Id", "Url");
            ViewBag.AreaViewModelId = new SelectList(DistrictMapping.FromBltoUiGetAll(), "AreaViewModelId", "AreaName");
            //ViewBag.ApartmentFeatureM_Id = new SelectList(FeaturesMapping.FromBltoUiGetAll(), "Id", "Id");
            //ViewBag.ApartmentFormHousingM_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "FormOfHousing");
           
            return View();
        }

        //
        // POST: /Apartment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppartmentViewModel appart)
        {
            if (ModelState.IsValid)
            {
                
                await AppartmentMapping.FromBltoUiInser(appart);

                //ViewBag.ApartmentPhoto = new SelectList(AppartmentPhotoMapping.FromBltoUiGetAll(), "Id", "Url");
                ViewBag.AreaViewModelId = new SelectList(DistrictMapping.FromBltoUiGetAll(), "AreaViewModelId", "AreaName");
                //ViewBag.ApartmentFeatureM_Id = new SelectList(FeaturesMapping.FromBltoUiGetAll(), "Id", "Id");
                //ViewBag.ApartmentFormHousingM_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "FormOfHousing");
                return RedirectToAction("Index");
            }
           
            return View(appart);
        }

        //
        // GET: /Apartment/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await AppartmentMapping.FromBltoUiGetById(id);

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
        public async Task<ActionResult> Edit(AppartmentViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await AppartmentMapping.FromBltoUiEditAsync(appart);
                return RedirectToAction("Index");
            }
            return View(appart);
        }

        //
        // GET: /Apartment/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await AppartmentMapping.FromBltoUiGetById(id);
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
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await AppartmentMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}