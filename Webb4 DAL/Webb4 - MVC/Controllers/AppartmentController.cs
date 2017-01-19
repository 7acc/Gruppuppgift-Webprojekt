using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;
using Webb4_DAL;

namespace Webb4___MVC.Controllers
{
    
    public class AppartmentController : Controller
    {
    /*

        AppartmentDataModelRepository<AppartmentDataModel> appartmentRepository = new AppartmentDataModelRepository<AppartmentDataModel>(new Webb4_Context());

        //private BildGalleryContext db = new BildGalleryContext();

        //
        // GET: /Appartment/
        public ActionResult Index()
        {
            return View(appartmentRepository.GetAll());
        }

        //
        // GET: /Appartment/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            AppartmentDataModel album = await appartmentRepository.GetByIdAsync(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        //
        // GET: /Appartment/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Appartment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Album album)
        {
            if (ModelState.IsValid)
            {
                await _albumRepository.InsertAsync(album);
                return RedirectToAction("Index");
            }

            return View(album);
        }

        //
        // GET: /Appartment/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            Album album = await _albumRepository.GetByIdAsync(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        //
        // POST: /Appartment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                await _albumRepository.EditAsync(album);
                return RedirectToAction("Index");
            }
            return View(album);
        }

        //
        // GET: /Appartment/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            Album album = await _albumRepository.GetByIdAsync(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        //
        // POST: /Appartment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Album album = await _albumRepository.GetByIdAsync(id);
            await _albumRepository.DeleteAsync(album);
            return RedirectToAction("Index");
        }
        */
    }
}