
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var g = ApartmentMapping.FromBltoUiGetAll();

            return View(g);
        }

        // GET: /Apartment/Details
        public async Task<ActionResult> Details(Guid id)
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
        public async Task<ActionResult> UserDetails(Guid id)
        {
            var r = await UserDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        } 
    }
}