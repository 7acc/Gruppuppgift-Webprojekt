using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webb4___MVC.Models.User;


namespace Webb4___MVC.Controllers
{
    public class LogInController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult LogIn(UserLoginViewModel userToLogIn)
        {
            if(ModelState.IsValid)
            {

            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }
    }
}