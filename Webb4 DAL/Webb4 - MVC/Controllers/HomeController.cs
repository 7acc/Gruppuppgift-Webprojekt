
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;
using System.Collections.Generic;

namespace Webb4___MVC.Controllers
{
    public class HomeController : Controller
    {
        public ApartmentMapping ApartmentMapping { get; set; }
        public UserDataMapping UserDataMapping { get; set; }
        public HomeController()
        {
            ApartmentMapping = new ApartmentMapping();
            UserDataMapping = new UserDataMapping();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Apartment/Details
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
        // GET: /UserData/Details/5
        public async Task<ActionResult> UserDetails(int id)
        {
            var r = await UserDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // GET: /UserData/Apartments // Alltså hämta en list av lägenheter som en user har gjort intresse för.
        public ActionResult InterestApartment ()
        {
            var ListOfUsers = UserDataMapping.FromBltoUiGetAll();

            return View(ListOfUsers);
        }
    }
}