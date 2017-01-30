using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class AdressController : Controller
    {

        public AdressMapping AdressMapping { get; set; }
        public AdressController()
        {
            AdressMapping = new AdressMapping();
        }
        // GET: /Adress/
        public ActionResult Index()
        {
            var g = AdressMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Adress/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await AdressMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Adress/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Adress/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AdressViewModel Adress)
        {
            if (ModelState.IsValid)
            {
               
                await AdressMapping.FromBltoUiInser(Adress);
                return RedirectToAction("Index");
            }

            return View(Adress);
        }

        //
        // GET: /Adress/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await AdressMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Adress/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AdressViewModel Adress)
        {
            if (ModelState.IsValid)
            {
                await AdressMapping.FromBltoUiEditAsync(Adress);
                return RedirectToAction("Index");
            }
            return View(Adress);
        }

        //
        // GET: /Adress/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await AdressMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Adress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await AdressMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}