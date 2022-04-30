using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["name"] == null)
				UserNameSession.Text = "Giriş Yap";
			else
				UserNameSession.Text = Session["name"].ToString();
		}
	}
}