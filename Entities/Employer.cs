using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Employer
	{
		[Key]
		public int EmployersId { get; set; }
		public string Name { get; set; }
		public int Phone { get; set; }
		public string CompanyMailAddress { get; set; }
		public string CompanyName { get; set; }
		public string Password { get; set; }

		public List<JobAdvert> JobAdverts { get; set; }

		public string employerAdd
			(Employer employersList, DataAccessLayer.Employers employer,DataAccessLayer.IlanTakipDbEntities db)
		{
			/*foreach (var item in employersList)
			{
				employer.Name = item.Name;
				employer.Password = Convert.ToInt32( item.Password);
				employer.Phone = item.Phone;
				employer.CompanyMailAddress = item.CompanyMailAddress;
				employer.CompanyName = item.CompanyName;
			}
			*/
			employer.CompanyName= employersList.CompanyName;

			db.Employers.Add(employer);
			db.SaveChanges();

			return "Employer Eklendi.";
		}
	}
}
