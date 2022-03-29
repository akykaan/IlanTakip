using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class School
	{
		[Key]
		public int SchoolId { get; set; }
		public Cv cv { get; set; }

		public string SchoolName { get; set; }
		public string DepartmentName { get; set; }
		public string StartYear { get; set; }
		public string StartEnd { get; set; }


	}
}
