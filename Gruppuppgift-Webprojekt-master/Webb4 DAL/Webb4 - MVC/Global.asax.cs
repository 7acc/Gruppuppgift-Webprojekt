using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using Webb4_businesslayer;
using Webb4_businesslayer.AutoMapper;

namespace Webb4___MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<BlContext>(new DropCreateDatabaseIfModelChanges<BlContext>());
            Database.SetInitializer(new Webb4MvcInitializer());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            AutoMapperConfig.RegisterMappings();


            System.Web.Helpers.AntiForgeryConfig.UniqueClaimTypeIdentifier =
          System.Security.Claims.ClaimTypes.NameIdentifier;
        }
    }
}
