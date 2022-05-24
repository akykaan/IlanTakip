using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class JobAdverts : System.Web.UI.Page
	{
		protected async void Page_Load(object sender, EventArgs e)
		{
			//string apiUrl = "https://localhost:44321/api";
			//WebClient client = new WebClient();
			//client.Headers["Content-type"] = "application/json";
			//client.Encoding = Encoding.UTF8;
			//string json = client.DownloadString(apiUrl + "/jobadverts");
			//jobadvertGridView.DataSource = (new JavaScriptSerializer()).Deserialize<List<JobAdvert>>(json);
			//jobadvertGridView.DataBind();

			if (!IsPostBack)
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:44321/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(
						new MediaTypeWithQualityHeaderValue("application/json"));

					HttpResponseMessage response = await client.GetAsync("api/jobadverts");
					if (response.IsSuccessStatusCode)
					{
						string data = await response.Content.ReadAsStringAsync();
						//JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
						jobadvertGridView.DataSource = new JavaScriptSerializer().Deserialize<List<JobAdvert>>(data);
						jobadvertGridView.DataBind();
					}
					else
					{
						Console.WriteLine("Internal server Error");
					}
				}
			}
		}

		protected void jobadvertGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			jobadvertGridView.PageIndex = e.NewPageIndex;
			this.DataBind();
		}

		protected void jobadvertGridView_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Basvuru")
			{
				// ilgili iş ilanının id'si
				int jobAdvertId = Convert.ToInt32(e.CommandArgument.ToString());

				DataAccessLayer.IlanTakipDbEntities db = new DataAccessLayer.IlanTakipDbEntities();
				DataAccessLayer.Applications applications = new DataAccessLayer.Applications();
				applications.JobAdvertId = jobAdvertId;
				applications.CandidateId = Convert.ToInt32(Session["id"]);
				db.Applications.Add(applications);
				db.SaveChanges();
			}
		}
	}
}