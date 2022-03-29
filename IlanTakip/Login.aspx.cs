using DataAcessLayer.Concrete;
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
		ProjectContext projeContext = new ProjectContext();
		protected void Page_Load()
		{
			
		}
		

		public void SignIn_Click(object sender, EventArgs e)
		{
			Candidate candidate = new Candidate();
			var user = projeContext.Candidates.FirstOrDefault(
				x => x.Email == candidate.Email && x.Password == candidate.Password);

			if (user!=null)
			{
				//Response.Redirect("Default.aspx");
				Label1.Text = "boş ";
			}
			Label1.Text = "ver geldi";
			//Response.Redirect("Login.aspx");
		}
	}
}