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
	}
}
