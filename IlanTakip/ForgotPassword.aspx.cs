using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IlanTakip
{
	public partial class ForgotPassword : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ResetPassword_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Candidates candidates = new DataAccessLayer.Candidates();
			DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();

			var person = dbEntities.Candidates.FirstOrDefault(
				x => x.Email == Email.Value );

			if (person != null)
			{
				
				candidates.Password =Convert.ToInt32(Password.Value);
				dbEntities.Entry(candidates).State = EntityState.Modified;
				dbEntities.SaveChanges();
				
			}
			else
			{
				Label1.Text = "Böyle bir mail yok";
			}

		}

	}
}