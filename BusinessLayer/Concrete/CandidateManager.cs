using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CandidateManager : ICandidateService
	{
		ICandidateDal _candidateDal;

		public CandidateManager(ICandidateDal candidateDal)
		{
			_candidateDal = candidateDal;
		}

		public void Add(Candidate candidate)
		{
			_candidateDal.Add(candidate);
		}

		public List<Candidate> GetAll()
		{
			return new List<Candidate>(_candidateDal.GetAll());
		}

		public List<Candidate> getById(int id)
		{
			return new List<Candidate>((IEnumerable<Candidate>)_candidateDal.Get(c => c.Id == id));
		}
	}
}
