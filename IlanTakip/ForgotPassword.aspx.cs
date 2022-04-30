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
			DataAccessLayer.User user = new DataAccessLayer.User();
			DataAccessLayer.IlanTakipDbEntities dbEntities = new DataAccessLayer.IlanTakipDbEntities();

			var person = dbEntities.User.FirstOrDefault(
				x => x.Email == Email.Value );

			if (person != null)
			{
				
				user.Password = Password.Value;
				dbEntities.Entry(user).State = EntityState.Modified;
				//dbEntities.Candidates.Attach(candidates);
				dbEntities.SaveChanges();
				
			}
			else
			{
				Label1.Text = "Böyle bir mail yok";
			}

		}

	}
}