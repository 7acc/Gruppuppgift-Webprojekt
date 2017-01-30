
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
        public AppartmentMapping AppartmentMapping { get; set; }
        public UserMapping UserMapping { get; set; }
        public HomeController()
        {
            AppartmentMapping = new AppartmentMapping();
            UserMapping = new UserMapping();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        // GET: /Apartment/Details
        public ActionResult ListOfApartments( )
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        // GET: /Apartment/Details
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