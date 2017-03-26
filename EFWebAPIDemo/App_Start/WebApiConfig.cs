﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace EFWebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //meol big difference not to use HttpConfiguration
            //but use GLOBAL CONFIGURATION
            //var json = config.Formatters.JsonFormatter;
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

            json.SerializerSettings.PreserveReferencesHandling = 
                Newtonsoft.Json.PreserveReferencesHandling.Objects;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            var jsonStyleFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();

            jsonStyleFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();            

        }
    }
}
