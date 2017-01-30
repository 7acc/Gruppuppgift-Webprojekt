
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    
    public class ApartmentController : Controller
    {
        private ApartmentMapping ApartmentMapping { get; set; }
        private ApartmentPhotoDataMapping ApartmentPhotoDataMapping { get; set; }
        private AreaMapping AreaMapping { get; set; }
        private FeaturesDataMapping FeaturesDataMapping { get; set; }
        private SizeDataMapping SizeDataMapping { get; set; }
        private FormHousingDataMapping FormHousingDataMapping { get; set; }
        public ApartmentController()
        {
            ApartmentMapping = new ApartmentMapping();
            ApartmentPhotoDataMapping = new ApartmentPhotoDataMapping();
            AreaMapping = new AreaMapping();
            FeaturesDataMapping = new FeaturesDataMapping();
            SizeDataMapping = new SizeDataMapping();
            FormHousingDataMapping = new FormHousingDataMapping();
        }

        // GET: /Apartment/
        public ActionResult Index()
        {
            var g = ApartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Apartment/Details/5
        public async Task<ActionResult> Details(int id)
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
            //ViewBag.ApartmentPhoto = new SelectList(ApartmentPhotoDataMapping.FromBltoUiGetAll(), "Id", "Url");
            ViewBag.AreaViewModelId = new SelectList(AreaMapping.FromBltoUiGetAll(), "AreaViewModelId", "AreaName");
            //ViewBag.ApartmentFeatureM_Id = new SelectList(FeaturesDataMapping.FromBltoUiGetAll(), "Id", "Id");
            //ViewBag.ApartmentFormHousingM_Id = new SelectList(FormHousingDataMapping.FromBltoUiGetAll(), "Id", "FormOfHousing");
            //ViewBag.ApartmentSizeM_Id = new SelectList(SizeDataMapping.FromBltoUiGetAll(), "Id", "SizekName");
            return View();
        }

        //
        // POST: /Apartment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ApartmentViewModel appart)
        {
            if (ModelState.IsValid)
            {
                
                await ApartmentMapping.FromBltoUiInser(appart);

                //ViewBag.ApartmentPhoto = new SelectList(ApartmentPhotoDataMapping.FromBltoUiGetAll(), "Id", "Url");
                ViewBag.AreaViewModelId = new SelectList(AreaMapping.FromBltoUiGetAll(), "AreaViewModelId", "AreaName");
                //ViewBag.ApartmentFeatureM_Id = new SelectList(FeaturesDataMapping.FromBltoUiGetAll(), "Id", "Id");
                //ViewBag.ApartmentFormHousingM_Id = new SelectList(FormHousingDataMapping.FromBltoUiGetAll(), "Id", "FormOfHousing");
                //ViewBag.ApartmentSizeM_Id = new SelectList(SizeDataMapping.FromBltoUiGetAll(), "Id", "SizekName");
                return RedirectToAction("Index");
            }
           
            return View(appart);
        }

        //
        // GET: /Apartment/Edit/5
        public async Task<ActionResult> Edit(int id)
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
        public async Task<ActionResult> Edit(ApartmentViewModel appart)
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
        public async Task<ActionResult> Delete(int id)
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
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await ApartmentMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}