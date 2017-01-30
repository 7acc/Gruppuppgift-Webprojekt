using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using Webb4___MVC.Models.User;
using Webb4_businesslayer;
using Webb4___MVC.Models;
using System.Web;
using ViewModels2.VyModels;


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
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "You Did Something Wrong");

                return PartialView("Index", userToLogIn);
            }


            if(LogInUser(userToLogIn.Email, userToLogIn.Password))
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Wrong");
            return PartialView("Index", userToLogIn);

        }

        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }

        public ActionResult Register(UserViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                var usermng = new UserManager();
                usermng.RegisterUser2(newUser);
                ViewBag.msg = "Register Succsesfull";
                return RedirectToAction("index");
            }
            return RedirectToAction("Index");
        }

        public bool LogInUser(string Email, string password)
        {
            var usermng = new UserManager();

            UserViewModel userToLogin = usermng.GetUserToLogin2(Email, password);

            if (userToLogin != null)
            {
                SignInUser(userToLogin);
                return true;
            }
            return false;
        }

        private void SignInUser(UserViewModel userToLogin)
        {

            {
                var identity = new ClaimsIdentity(new[]
                 {
                    new Claim(ClaimTypes.Name, userToLogin.Username),
                    new Claim(ClaimTypes.Email, userToLogin.Email),
                    new Claim(ClaimTypes.Sid, userToLogin.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, userToLogin.Id.ToString()),

                }, "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;



                authManager.SignIn(identity);

            }
        }
    }
}