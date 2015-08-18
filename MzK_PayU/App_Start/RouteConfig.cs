using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MzK_PayU
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home.Index", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Home.Payment", "odeme", new { controller = "Home", action = "Payment" });
            routes.MapRoute("Home.PaymentThanks", "odeme-tesekkur", new { controller = "Home", action = "PaymentThanks" });
        }
    }
}
