using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: /UserData/
        public ActionResult Index()
        {
            var g = UserDataMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /UserData/Details/5
        public async Task<ActionResult> Details(Guid id)
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
                user.Id = Guid.NewGuid();
                await UserDataMapping.FromBltoUiInser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /UserData/Edit/5
        public async Task<ActionResult> Edit(Guid id)
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
        public async Task<ActionResult> Delete(Guid id)
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
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await UserDataMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }

       
    }
}