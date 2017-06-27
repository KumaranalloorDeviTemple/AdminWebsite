﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace kumaranalloordevitempleadminweb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "kumaranalloordevitempleadminweb" }
            );

            routes.MapHttpRoute(
                name: "KDT API Vazhipadu",
                routeTemplate: "api/vazhipadu");

            routes.MapHttpRoute(
                name: "KDT API Notifications",
                routeTemplate: "api/notifications/{action}");
        }
    }
}
