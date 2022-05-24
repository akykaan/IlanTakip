using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiProject.Controllers
{
	public class CandidateController : ApiController
    {
		Candidate candidateAdd = new Candidate();

		// api/candidate
		[HttpGet]
		public IHttpActionResult GetAllCandidate()
		{
			//List<Candidates> list = db.Candidates.ToList();
			var list = candidateAdd.GetAllCandidate();
			return Ok(list);
		}

		// api/candidate/add

		[HttpPost]
		public IHttpActionResult Add([FromBody] Candidate candidate)
		{
			var result=candidateAdd.Add(candidate);
			if (result)
			{
				return Ok(HttpStatusCode.OK);
			}
			return Ok(HttpStatusCode.BadRequest);
		}

		// api/candidate/id
		[HttpGet]
		public IHttpActionResult GetById(int id)
		{
			var result = candidateAdd.GetById(id);
			return Ok(result);
		}
    }
}
