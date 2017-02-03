
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
        private AdressMapping AdressMapping { get; set; }
        public ApartmentController()
        {
            AppartmentMapping = new AppartmentMapping();
            AppartmentPhotoMapping = new AppartmentPhotoMapping();
            DistrictMapping = new DistrictMapping();
            FeaturesMapping = new FeaturesMapping();
            HousingTypeMapping = new HousingTypeMapping();
            AdressMapping = new AdressMapping();
        }

        // GET: /Apartment/
        public ActionResult Index()
        {
            var g = AppartmentMapping.FromBlToUiGetApartList();
            return View(g);
        }

        //
        // GET: /Apartment/Details/5
        public /*async Task<ActionResult>*/ ActionResult Details(int id)
        {
            var r = /*await*/ AppartmentMapping.FromBltoUiGetById(id);
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
            ViewBag.Adress_Id = new SelectList(AdressMapping.FromBltoUiGetAll(), "Id", "Street");
            ViewBag.District_Id = new SelectList(DistrictMapping.FromBltoUiGetAll(), "Id", "Name");
            ViewBag.Housing_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "Type");
            //ViewBag.ApartmentPhoto = new SelectList(AppartmentPhotoMapping.FromBltoUiGetAll(), "Id", "Url");
            //ViewBag.ApartmentFeatureM_Id = new SelectList(FeaturesMapping.FromBltoUiGetAll(), "Id", "Id");


            return View();
        }

        //[Bind(Include = "Id,Area,Rent,NrOfRooms,BuildinFloors,Floor,BuildYear,MoveInDate,LastAdmissionDate,PublicationDate,Avalible,Adress_Id,District_Id,Housing_Id")]
        // POST: /Apartment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create( AppartmentViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await AppartmentMapping.FromBltoUiInser(appart);
                return RedirectToAction("Index");
            }
            ViewBag.Adress_Id = new SelectList(AdressMapping.FromBltoUiGetAll(), "Id", "Street");
            ViewBag.District_Id = new SelectList(DistrictMapping.FromBltoUiGetAll(), "Id", "Name");
            ViewBag.Housing_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "Type");

            return View(appart);
        }

        //
        // GET: /Apartment/Edit/5
        public /*async Task<ActionResult>*/ ActionResult Edit(int id)
        {

            var editMap = /*await*/ AppartmentMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            ViewBag.Adress_Id = new SelectList(AdressMapping.FromBltoUiGetAll(), "Id", "Street");
            ViewBag.District_Id = new SelectList(DistrictMapping.FromBltoUiGetAll(), "Id", "Name");
            ViewBag.Housing_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "Type");

            return View(editMap);
        }

        //
        // POST: /Apartment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Area,Rent,NrOfRooms,BuildinFloors,Floor,BuildYear,MoveInDate,LastAdmissionDate,PublicationDate,Avalible,Adress_Id,District_Id,Housing_Id")]AppartmentViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await AppartmentMapping.FromBltoUiEditAsync(appart);
                return RedirectToAction("Index");
            }
            ViewBag.Adress_Id = new SelectList(AdressMapping.FromBltoUiGetAll(), "Id", "Street");
            ViewBag.District_Id = new SelectList(DistrictMapping.FromBltoUiGetAll(), "Id", "Name");
            ViewBag.Housing_Id = new SelectList(HousingTypeMapping.FromBltoUiGetAll(), "Id", "Type");

            return View(appart);
        }

        //
        // GET: /Apartment/Delete/5
        public /*async Task<ActionResult>*/ ActionResult Delete(int id)
        {
            var getFromR = /*await*/ AppartmentMapping.FromBltoUiGetById(id);
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