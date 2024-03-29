﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace AppAnalytics
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            name: "AppControllerAPI_WithAction",
            routeTemplate: "{Controller}/{action}/{id}",
            defaults: new { controller = "AppController", id = RouteParameter.Optional }
            );
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            name: "AppControllerAPI_WithoutAction",
            routeTemplate: "{Controller}/{action}/",
            defaults: new { controller = "AppController", action = RouteParameter.Optional }
            );

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}