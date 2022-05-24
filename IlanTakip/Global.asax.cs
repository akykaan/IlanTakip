using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;

namespace IlanTakip
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
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Home", "Home", "~/Default.aspx");
            routes.MapPageRoute("Login", "Login", "~/Login.aspx");
            routes.MapPageRoute("Register", "Register", "~/Register.aspx");
            routes.MapPageRoute("Candidate", "Candidate", "~/Candidate.aspx");
            routes.MapPageRoute("jobadverts", "jobadverts", "~/JobAdverts.aspx");
            routes.MapPageRoute("application", "application", "~/Application.aspx");
        }

    }
}