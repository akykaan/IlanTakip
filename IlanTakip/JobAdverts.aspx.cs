using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
			//string apiUrl = "https://localhost:44321/api/candidate";

			//WebClient client = new WebClient();
			//client.Headers["Content-type"] = "application/json";
			//client.Encoding = Encoding.UTF8;
			//string json = client.DownloadString(apiUrl+"/getallcandidate");

			//candidateGridView.DataSource = (new JavaScriptSerializer()).Deserialize<List<Candidate>>(json);
			//candidateGridView.DataBind();

			using (var client = new HttpClient())
			{
				client.BaseAddress=new Uri("https://localhost:44321/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(
					new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/candidate/getallcandidate");
				if (response.IsSuccessStatusCode)
				{
					string data = await response.Content.ReadAsStringAsync();
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					candidateGridView.DataSource = javaScriptSerializer.Deserialize<List<Candidate>>(data);
					candidateGridView.DataBind();				
				}
				else
				{
					Console.WriteLine("Internal server Error");
				}
			}
		}
	}
}