<%@ Application CodeBehind="Global.asax.cs" Inherits="IlanTakip.Global" Language="C#" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Web.Routing" %>


<script RunAt="server">
    
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
        routes.MapPageRoute("Candidate", "Candidate", "~/Candidate.aspx");
        routes.MapPageRoute("jobadverts", "jobadverts", "~/JobAdverts.aspx");
    }
</script>
