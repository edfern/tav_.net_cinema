using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cinemagt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            /*
             * routes.MapRoute(
               name: "Functions",
               url: "Functions/{id}",
               defaults: new { controller = "Functions", action = "Details", id = UrlParameter.Optional }
               );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Billboard", action = "Index", id = UrlParameter.Optional });
        }
    }
}
