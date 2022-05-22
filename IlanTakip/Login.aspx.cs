using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Login : System.Web.UI.Page
	{
		DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();
		
		protected void Page_Load()
		{
			
		}

	
		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Register.aspx");
		}

		protected void ForgotPassword_Click(object sender, EventArgs e)
		{
			Response.Redirect("ForgotPassword.aspx");
		}
		
		protected void btnEmployer_Click(object sender, EventArgs e)
		{
			var user = dbEntities.Employers.FirstOrDefault(
				x => x.CompanyMailAddress == emailEmployer.Value && x.Password.ToString() == passowordEmployer.Value);

			if (user == null)
			{
				labelError.Text = "hatalı şifre veya mail";
			}
			else
			{
				Session.Add("name", user.CompanyName);
				Response.Redirect("EmployerPage.aspx");
			}
		}

		protected void btnCandidate_Click1(object sender, EventArgs e)
		{
			//var user = dbEntities.Candidates.FirstOrDefault(
			//	x => x.Email == emailCandidate.Value && x.Password.ToString() == passwordCandidate.Value);

			//if (user == null)
			//{
			//	labelError.Text = "hatalı şifre veya mail";
			//}
			//else
			//{
			//	Session.Add("name", user.FirstName);
			//	Session.Add("Authority", user.Authority);
			//	Response.Redirect("Default.aspx");
			//}

			Candidate candidate = new Candidate();
			using (var client =new HttpClient())
			{
				client.BaseAddress=new Uri("https://localhost:44321/");

				var result = client.PostAsync("api/candidate",new StringContent(
					new JavaScriptSerializer().Serialize(candidate),Encoding.UTF8,"application/json")).Result;



			}

		}
	}
}