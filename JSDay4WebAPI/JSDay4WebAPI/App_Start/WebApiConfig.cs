using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace JSDay4WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatters = GlobalConfiguration.Configuration.Formatters;

            formatters.Remove(formatters.XmlFormatter);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
