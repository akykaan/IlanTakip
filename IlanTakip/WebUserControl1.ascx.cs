using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class WebUserControl1 : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataAccessLayer.IlanTakipDbEntities db = new DataAccessLayer.IlanTakipDbEntities();
			DataAccessLayer.Menu menu = new DataAccessLayer.Menu();

			var auth = Session["Authority"].ToString();

			string htmlText = "";
			var result = (
				from m in db.Menu
				join s in db.SubMenu on m.Id equals s.MenuId
				where m.Auth==auth
				select new
				{
					url = s.Url,
					title = m.MenuName
				}).ToList();
			result.ForEach(x =>
			{
				//firstLi.InnerHtml = x.title;
				//firstLi.HRef = x.url;

				htmlText += "<li>";
				htmlText += "<a href = \""+x.url+"\">";
				htmlText += ""+x.title+"";
				htmlText += "</a></li>";
			});
			label.Text = htmlText;
		}
	}
}