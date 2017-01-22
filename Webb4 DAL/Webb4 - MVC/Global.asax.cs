using System.Web.Mvc;
using System.Web.Routing;
using Webb4_businesslayer.AutoMapper;

namespace Webb4___MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoMapperConfig.RegisterMappings();
        }
    }
}
