using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class EmployerPage : System.Web.UI.Page
	{
		protected async void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:44321/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(
						new MediaTypeWithQualityHeaderValue("application/json"));

					HttpResponseMessage response = await client.GetAsync("api/city");
					if (response.IsSuccessStatusCode)
					{
						string data = await response.Content.ReadAsStringAsync();
						validationCustom04.DataSource = new JavaScriptSerializer().Deserialize<List<City>>(data);
						validationCustom04.DataTextField = "CityName";
						validationCustom04.DataValueField = "CityName";
						validationCustom04.DataBind();
					}
					else
					{
						Console.WriteLine("Internal server Error");
					}
				}
			}
		}

		protected void jobAdvertAdd_Click(object sender, EventArgs e)
		{
			DataAccessLayer.JobAdverts jobAdverts = new DataAccessLayer.JobAdverts();
			jobAdverts.JobDescription = validationJobDescription.Value;
			jobAdverts.JobTitle = validationJobTitle.Value;
			jobAdverts.OpenPosition = validationOpenPosition.Value;

			jobAdverts.CityName = validationCustom04.Value;

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44321/");

				var result = client.PostAsync("api/jobadverts/add", new StringContent(
					new JavaScriptSerializer().Serialize(jobAdverts), Encoding.UTF8, "application/json")).Result;

				if (result.StatusCode == System.Net.HttpStatusCode.OK)
				{
					LabelMessage.Text = "Added Job Advert";
				}
				else
					LabelMessage.Text = "Not Added Job Advert";

			}
		}
	}
}