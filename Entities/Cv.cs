using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Cv
	{
		[Key]
		public int id { get; set; }
		public string GitHubLink { get; set; }		
		public string CoverLetter { get; set; }
		public bool Active { get; set; }
		public Candidate Candidate { get; set; }
		public List<JobExperience> JobExperience { get; set; }
		public List<Language> Language { get; set; }
		public List<School> Schools { get; set; }

	}
}
