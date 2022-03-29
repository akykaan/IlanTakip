﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class JobAdvert
	{
		[Key]
		public int Id { get; set; }
		public string JobDescription { get; set; }
		public string JobTitle { get; set; }
		public string CityName { get; set; }
		public string OpenPosition { get; set; }
		public bool IsActive { get; set; }

		public int EmployerId { get; set; }
		public Employer Employer { get; set; }
	}
}