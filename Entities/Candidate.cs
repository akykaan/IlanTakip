using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Candidate:User
	{
		[Key]
		public int userId { get; set; }
		//public string FirstName { get; set; }
		//public string LastName { get; set; }
		public string IdentityNumber { get; set; }
		public int BirthYear { get; set; }
		//public string Email { get; set; }
		//public int Password { get; set; }
		public int CvId { get; set; }
		public List<Cv> Cv { get; set; }
		public List<Event> Events { get; set; }
		//public string Authority { get; set; }
		public User user { get; set; }

		public Candidate()
		{

		}

		public Candidate(string name,string password,string identityNumber,int birtYear)
		{
			this.Name = name;
			this.Password = password;
			this.IdentityNumber = identityNumber;
			this.BirthYear = birtYear;
		}
		public string candidateAdd(List<Candidate> candidates, DataAccessLayer.Candidates candidate)
		{
			foreach (var item in candidates)
			{
				candidate.User.Name = item.Name;
				candidate.User.Password = item.Password;
				candidate.IdentityNumber = item.IdentityNumber;
				candidate.BirthYear = item.BirthYear;
				candidate.User.Email = item.Email;
				candidate.User.Authority = item.Authority;
			}

			DataAccessLayer.IlanTakipDbEntities dal = new DataAccessLayer.IlanTakipDbEntities();
			dal.Candidates.Add(candidate);
			dal.SaveChanges();

			return "Listeye Candidate Eklendi";
		}

	}
}
