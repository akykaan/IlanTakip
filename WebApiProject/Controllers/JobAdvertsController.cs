using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class JobAdvertsController : ApiController
    {
		JobAdvert jobAdvert = new JobAdvert();

		// api/jobadverts

		[HttpGet]
		public IHttpActionResult GetAllJobAdvert()
		{
			var getAll = jobAdvert.GetAllJobAdverts();
			return Ok(getAll);
		}

		[HttpPost]
		public IHttpActionResult Add([FromBody]JobAdvert jobAdvert )
		{
			var add = jobAdvert.addJobAdvert(jobAdvert);
			return Ok(add);
		}
	}
}
