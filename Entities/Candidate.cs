using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Candidate
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string IdentityNumber { get; set; }
		public int BirthYear { get; set; }
		public string Email { get; set; }
		public int Password { get; set; }
		public int CvId { get; set; }
		public List<Cv> Cv { get; set; }
		public List<Event> Events { get; set; }

	}
}
