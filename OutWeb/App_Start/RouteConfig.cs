﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Work.WebProj
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // 後台
            routes.MapRoute(
                name: "Manage",
                url: "_SysAdm",
                defaults: new { controller = "Manage", action = "Login" }
            ).DataTokens["UseNamespaceFallback"] = false;
        }
    }
}
