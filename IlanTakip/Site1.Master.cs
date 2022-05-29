using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Site1 : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (Session["name"] == null)
			{
				UserNameSession.Text = "";
				Session["Authority"]="User";
				Logout.Visible = false;
				UserNameSession.Visible = false;
			}
			else
			{
				UserNameSession.Text = Session["name"].ToString();
				Logout.Visible = true;
				UserNameSession.Visible = true;
			}
		}

		protected void Logout_Click(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Session.Clear();
				Response.Redirect("Home");
			}
		}
	}
}