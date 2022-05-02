using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class Login : System.Web.UI.Page
	{
		DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();
		DataAccessLayer.Candidates candidates = new DataAccessLayer.Candidates();
		
		protected void Page_Load()
		{
			
		}

		public void SignIn_Click(object sender, EventArgs e)
		{
			var user = dbEntities.User.FirstOrDefault(
				x => x.Email == floatingInput.Value && x.Password.ToString() == floatingPassword.Value);

			if (user==null)
			{
				Label1.Text = "hatalı şifre veya mail";
			}
			else
			{
				if (user.Authority == "admin")
				{
					Session.Add("name", user.Name);
					Response.Redirect("Admin.aspx");
				}
				else if (user.Authority=="Candidate")
				{
					Session.Add("name", user.Name);
					Response.Redirect("Candidate.aspx");
				}
				else
				{
					Session.Add("name", user.Name);
					Response.Redirect("Employer.aspx");
				}
				
			}
		}

		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Register.aspx");
		}

		protected void ForgotPassword_Click(object sender, EventArgs e)
		{
			Response.Redirect("ForgotPassword.aspx");
		}
	}
}