using System;
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

            



            routes.MapRoute(
            name: "Home",
            url: "Home",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "Content",
            url: "tin-tuc",
            defaults: new { controller = "Content", action = "Index1", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "Rate",
            url: "danh-gia",
            defaults: new { controller = "Rating", action = "Rating", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "AllProduct",
            url: "danh-sach-san-pham",
            defaults: new { controller = "Product", action = "ListAll", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "Contact",
            url: "lien-he",
            defaults: new { controller = "Contact", action = "Contact", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "Info",
            url: "ve-chung-toi",
            defaults: new { controller = "Info", action = "Index", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "HotProduct",
            url: "san-pham-noi-bat",
            defaults: new { controller = "Product", action = "ListHotProduct", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "ProducByCatId",
            url: "danh-sach-san-pham/{metaTitle}-{id}",
            defaults: new { controller = "Product", action = "ListByCatId", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );

            routes.MapRoute(
            name: "Product",
            url: "chi-tiet/{metaTitle}-{id}",
            defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );


            routes.MapRoute(
            "Default",
            "{controller}/{action}/{id}",
            new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            new[] { "CarShowroom.Controllers" }
            );



        }
    }
}
