using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;

namespace Webb4___MVC.Controllers
{
    public class BookingController : Controller
    {
        public BookingMapping BookingMapping { get; set; }
        public BookingController()
        {
            BookingMapping = new BookingMapping();
        }

        // GET: /Booking/
        public ActionResult Index()
        {
            var g = BookingMapping.FromBltoUiGetAll();
            return View(g);
        }

        //
        // GET: /Booking/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var r = await BookingMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BookingViewModel appart)
        {
            if (ModelState.IsValid)
            {
              
                await BookingMapping.FromBltoUiInser(appart);
                return RedirectToAction("Index");
            }

            return View(appart);
        }

        //
        // GET: /Booking/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var editMap = await BookingMapping.FromBltoUiGetById(id);

            if (editMap == null)
            {
                return HttpNotFound();
            }
            return View(editMap);
        }

        //
        // POST: /Booking/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(BookingViewModel appart)
        {
            if (ModelState.IsValid)
            {
                await BookingMapping.FromBltoUiEditAsync(appart);
                return RedirectToAction("Index");
            }
            return View(appart);
        }

        //
        // GET: /Booking/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var getFromR = await BookingMapping.FromBltoUiGetById(id);
            if (getFromR == null)
            {
                return HttpNotFound();
            }
            return View(getFromR);
        }

        //
        // POST: /Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await BookingMapping.FromBltoUiDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}