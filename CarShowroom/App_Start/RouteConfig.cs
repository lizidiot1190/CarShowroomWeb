﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarShowroom
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //);

            routes.MapRoute(
            "Default",
            "{controller}/{action}/{id}",
            new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );
            routes.MapRoute(
            "Contact",
            "{controller}/{action}/{id}",
            new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );
        }
    }
}
