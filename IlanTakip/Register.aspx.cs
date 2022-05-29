using Entities;
using System;
using System.Collections;
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
	public partial class Register : System.Web.UI.Page
	{
		DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void RegisterPageLoginButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}

		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Candidates candidates = new DataAccessLayer.Candidates();
			candidates.IdentityNumber = IdentityNumber.Value;
			candidates.FirstName = FirstName.Value;
			candidates.LastName = LastName.Value;
			candidates.BirthYear = Convert.ToInt32(BirthYear.Value);
			candidates.Email = Email.Value;
			candidates.Password = Convert.ToInt32(Password.Value);
			candidates.Authority = "Candidate";


			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44321/");

				var result = client.PostAsync("api/candidate/add", new StringContent(
					new JavaScriptSerializer().Serialize(candidates), Encoding.UTF8, "application/json")).Result;

				if (result.StatusCode == System.Net.HttpStatusCode.OK)
				{
					Label1.Text = "Candidate eklendi.";
				}
				else
					Label1.Text = "Candidate Eklenemedi.";

			}
		}

		protected void RegisterEmployerButton_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Employers employers = new DataAccessLayer.Employers();


			Employer employer = new Employer();

			employer.CompanyName = "yok";
			Label1.Text= employer.employerAdd(employer,employers,dbEntities);


		}

	}
}