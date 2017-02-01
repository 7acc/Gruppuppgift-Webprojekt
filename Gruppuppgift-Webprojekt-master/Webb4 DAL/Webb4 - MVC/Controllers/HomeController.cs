﻿
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;
using System.Collections.Generic;

namespace Webb4___MVC.Controllers
{
    public class HomeController : Controller
    {
        private AppartmentMapping AppartmentMapping { get; set; }
        private AppartmentPhotoMapping AppartmentPhotoMapping { get; set; }
        private DistrictMapping DistrictMapping { get; set; }
        private FeaturesMapping FeaturesMapping { get; set; }
        private HousingTypeMapping HousingTypeMapping { get; set; }
        public UserMapping UserMapping { get; set; }
        public HomeController()
        {
            AppartmentMapping = new AppartmentMapping();
            AppartmentPhotoMapping = new AppartmentPhotoMapping();
            DistrictMapping = new DistrictMapping();
            FeaturesMapping = new FeaturesMapping();
            HousingTypeMapping = new HousingTypeMapping();
            UserMapping = new UserMapping();
        }
        // GET: Home
        public ActionResult Index()
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View(g);
        }


        // GET: /Apartment/Details
        public ActionResult ListOfApartments( )
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        // GET: /Apartment/Details
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
        // GET: /UserData/Details/5
        public async Task<ActionResult> UserDetails(int id)
        {
            var r = await UserMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // GET: /UserData/Apartments // Alltså hämta en list av lägenheter som en user har gjort intresse för.
        public ActionResult InterestApartment (int id)
        {
            //var ListOfUsers = AppartmentMapping.FromBltoUiGetAllUserInterestApartment(id);

            return View(/*ListOfUsers*/);
        }
    }
}