using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Webb4_businesslayer;
using Webb4_businesslayer.AutoMapper;
using Webb4___MVC.Controllers;

namespace Webb4___MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<BlContext>(new DropCreateDatabaseIfModelChanges<BlContext>());
            //Database.SetInitializer(new Webb4MvcInitializer());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoMapperConfig.RegisterMappings();


            System.Web.Helpers.AntiForgeryConfig.UniqueClaimTypeIdentifier =
                System.Security.Claims.ClaimTypes.NameIdentifier;
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Response.TrySkipIisCustomErrors = true;
            Exception exception = Server.GetLastError();
            Response.Clear();

            HttpException httpException = exception as HttpException;

            if (httpException != null)
            {
                string action;

                switch (httpException.GetHttpCode())
                {
                    case 404:
                        // page not found
                        action = "NotFound";
                        break;
                    case 500:
                        // server error
                        action = "ServerError";
                        break;
                    default:
                        action = "Error";
                        break;
                }

                // clear error on server
                Server.ClearError();

                Response.Redirect(String.Format("~/Error/{0}/?message={1}", action, exception.Message));
            }
        }
    }
}
