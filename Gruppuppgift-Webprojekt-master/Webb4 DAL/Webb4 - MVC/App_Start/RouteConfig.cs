using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Webb4___MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
  name: "SubmitBid",
  url: "Home/Find/{Omrade}/{Boform}/{Rum}/{MaxHyra}/{Minyta}/{Maxyta}/{Sort}",
  defaults: new
      {
      controller = "Home",
      action = "Find",
      Omrade = UrlParameter.Optional,
      Boform = UrlParameter.Optional,
      Rum = UrlParameter.Optional,
      MaxHyra = UrlParameter.Optional,
      Minyta = UrlParameter.Optional,
      Maxyta = UrlParameter.Optional,
      Sort = UrlParameter.Optional
      });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
