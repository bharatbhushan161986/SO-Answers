﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebForms_Routing.CustomRouteConstraints;

namespace WebForms_Routing
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
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

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Ignore("{resource}.axd/{*pathInfo}");

            routes.MapPageRoute(
                "SalesSummaryRoute",
                "SalesReportSummary/{year}",
                "~/SalesSummary.aspx",
                true,
                new RouteValueDictionary { }
            );

            routes.MapPageRoute(
                "SalesRoute",
                "SalesReport/{locale}/{year}",
                "~/Sales.aspx",
                true,
                new RouteValueDictionary { }
            );

            routes.MapPageRoute(
                "ExpensesRoute",
                "ExpenseReport/{locale}/{year}/{*extraInfo}",
                "~/Expenses.aspx",
                true,
                new RouteValueDictionary { },
                new RouteValueDictionary { { "extraInfo", new CharactersConstraint() } }
            );
        }
    }
}