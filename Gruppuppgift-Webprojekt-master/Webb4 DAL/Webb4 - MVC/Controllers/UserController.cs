using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{

    public class UserController : Controller
    {
        public UserDataMapping UserDataMapping { get; set; }
        public UserController()
        {
            UserDataMapping = new UserDataMapping();
        }
        // GET: /UserData/
        public ActionResult Index()
        {
            var g = UserDataMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /UserData/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await UserDataMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /UserData/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserDataViewModel user)
        {
            if (ModelState.IsValid)
            {
               
                await UserDataMapping.FromBltoUiInser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /UserData/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await UserDataMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /UserData/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UserDataViewModel adre)
        {
            if (ModelState.IsValid)
            {
                await UserDataMapping.FromBltoUiEditAsync(adre);
                return RedirectToAction("Index");
            }
            return View(adre);
        }

        //
        // GET: /UserData/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await UserDataMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /UserData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await UserDataMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }

       
    }
}