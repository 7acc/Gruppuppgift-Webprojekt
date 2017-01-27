using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.VyModels;
using Webb4___MVC.Models.User;
using Webb4_businesslayer;
using Webb4___MVC.Models;
using System.Web;



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
        public async Task<ActionResult> LogIn(UserLoginViewModel userToLogIn)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "You Did Something Wrong");

                return View("Index", userToLogIn);
            }
            if(await LogInUser(userToLogIn.Email, userToLogIn.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Wrong");
            return View("Index", userToLogIn);

        }

        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }

        public ActionResult Register(UserDataViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                var usermng = new UserManager();
                usermng.RegisterUser(newUser);
                ViewBag.msg = "Register Succsesfull";
                return RedirectToAction("index");
            }
            return RedirectToAction("Index");
        }

        public async Task<bool> LogInUser(string Email, string password)
        {
            var usermng = new UserManager();

            UserDataViewModel userToLogin = await usermng.GetUserToLogin(Email, password);

            if (userToLogin != null)
            {
                SignInUser(userToLogin);
                return true;
            }
            return false;
        }

        private void SignInUser(UserDataViewModel userToLogin)
        {

            {
                var identity = new ClaimsIdentity(new[]
                 {
                    new Claim(ClaimTypes.Name, userToLogin.UserName),
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