using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
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
		public string Authority { get; set; }
		
		public string candidateAdd(List<Candidate> candidates, DataAccessLayer.Candidates candidate)
		{
			foreach (var item in candidates)
			{
				candidate.FirstName = item.FirstName;
				candidate.LastName = item.FirstName;
				candidate.Password = item.Password;
				candidate.IdentityNumber = item.IdentityNumber;
				candidate.BirthYear = item.BirthYear;
				candidate.Email = item.Email;
				candidate.Authority = item.Authority;
			}

			DataAccessLayer.IlanTakipDbEntities dal = new DataAccessLayer.IlanTakipDbEntities();
			dal.Candidates.Add(candidate);
			dal.SaveChanges();

			return "Listeye Candidate Eklendi";
		}

		public bool Add(Candidate candidate)
		{
			bool added=false;
			using (DataAccessLayer.IlanTakipDbEntities db = new DataAccessLayer.IlanTakipDbEntities())
			{
				db.Candidates.Add(new DataAccessLayer.Candidates()
				{
					FirstName = candidate.FirstName,
					LastName = candidate.LastName,
					Password = candidate.Password,
					IdentityNumber = candidate.IdentityNumber,
					BirthYear = candidate.BirthYear,
					Email = candidate.Email,
					Authority = "Candidate"
				});
				var response = db.SaveChanges();
				if (response==1)
				{
					added = true;
				}
			}
			
			return added; // 1 or 0 
		}

		public List<Candidate> GetAllCandidate()
		{
			using (DataAccessLayer.IlanTakipDbEntities db=new DataAccessLayer.IlanTakipDbEntities())
			{
				var result = (from c in db.Candidates.ToList()
							  select new Candidate
							  {
								  FirstName = c.FirstName,
								  LastName=c.LastName
							  }).ToList();
				return result;
			}
		}
		public List<Candidate> GetById(int id)
		{
			using (DataAccessLayer.IlanTakipDbEntities db=new DataAccessLayer.IlanTakipDbEntities())
			{

				var result = from c in db.Candidates.Where(c => c.Id == id)
							 select new Candidate
							 {
								 FirstName=c.FirstName,
								 LastName=c.LastName,
								 Email=c.Email,
								 BirthYear=c.BirthYear,
							 };

				return result.ToList();
			}
		}
	}
}
