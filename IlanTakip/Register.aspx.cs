using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Register : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void RegisterPageLoginButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}

		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();
			DataAccessLayer.Candidates candidates = new DataAccessLayer.Candidates();

			Candidate candidate = new Candidate();
			List<Candidate> candidatesList = new List<Candidate>
			{
				new Candidate
				{
					Name=FirtName.Value,
					Authority="Candidate",
					IdentityNumber="12345",
					BirthYear=Convert.ToInt32(BirthYear.Value),
					Email=Email.Value,
					Password=Password.Value,
				}
			};

			Label1.Text = candidate.candidateAdd(candidatesList,candidates);
			
			//dbEntities.User.Add(candidates.User);
			//dbEntities.SaveChanges();

		}
	}
}