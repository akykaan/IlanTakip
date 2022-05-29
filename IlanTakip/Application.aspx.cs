using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Application : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataAccessLayer.IlanTakipDbEntities db = new DataAccessLayer.IlanTakipDbEntities();

			var session=Convert.ToInt32(Session["id"]);
			string htmlText = "";
			var result = (
				from a in db.Applications
				join j in db.JobAdverts on a.JobAdvertId equals j.Id
				where a.CandidateId == session
				select new
				{
					city=j.CityName,
					title=j.JobTitle,
					description=j.JobDescription,
				}).ToList();
			result.ForEach(x =>
			{
				/* title.InnerHtml = x.title;
				description.InnerHtml = x.description;
				city.InnerHtml= x.city;
				*/
				htmlText += "<li>";
				htmlText += "<a " + x.title + "\">";
				htmlText += "" + x.description + "";
				htmlText += "" + x.city + "";
				htmlText += "</a></li>";

			});
			Label1.Text = htmlText;

		}
	}
}