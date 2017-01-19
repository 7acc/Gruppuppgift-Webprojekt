using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webb4___MVC.Controllers
{
    public class AccountController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }
    }
}