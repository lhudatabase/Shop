﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region ShopRoute
                routes.MapRoute(
                   name: "Products",
                   url: "products",
                   defaults: new { controller = "Shop", action = "Products", id = UrlParameter.Optional }
               );

                routes.MapRoute(
                    name: "ProductDetails",
                    url: "product-details",
                    defaults: new { controller = "Shop", action = "ProductDetails", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                    name: "Checkout",
                    url: "checkout",
                    defaults: new { controller = "Shop", action = "Checkout", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                    name: "Cart",
                    url: "cart",
                    defaults: new { controller = "Shop", action = "Cart", id = UrlParameter.Optional }
                );

            #endregion

            #region ContactRoute
            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Contact", action = "Contact", id = UrlParameter.Optional });
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
