﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer;


namespace Webb4___MVC.Controllers
{
    public class AdminUploadController : Controller
    {
        public AppartmentManager AppartmentManager { get; set; }
        public AdminUploadController()
        {
            AppartmentManager = new AppartmentManager();
        }
        // GET: AdminUpload
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ListAppartments()
        {
            var listOfAppartments = AppartmentManager.GetAppartmentList();

            return PartialView("partialURl", listOfAppartments);
        }
        public ActionResult AddAppartment()
        {


            return View();
        }

        [HttpPost]
        public ActionResult AddAppartment(AppartmentViewModel newAppartment, HttpPostedFileBase MainIMG, List<HttpPostedFileBase> Images)
        {
            var root = Server.MapPath("~/Photos/");
            AppartmentManager.AddAppartmentWithPhotosToDB(newAppartment, MainIMG, Images, root);
            return View();
        }

        public ActionResult NewAppartmentForm()
        {
            return PartialView();
        }

        public ActionResult AddImagesToAppartment()
        {
            return PartialView();
        }


        public ActionResult UpdateAppartment(int AppartmentId)
        {
            var appartmentToUpdate = AppartmentManager.GetAppartmentById(AppartmentId);
            return View(appartmentToUpdate);
        }
        [HttpPost]
        public ActionResult UpdateAppartment(AppartmentViewModel UpdatedAppartment, IEnumerable<HttpPostedFileBase> photos)
        {
            return View();
        }
        [HttpDelete]
        public ActionResult DeleteImagesFromAppartment(string[] photoIds)
        {
            return View();
        }
    }
}