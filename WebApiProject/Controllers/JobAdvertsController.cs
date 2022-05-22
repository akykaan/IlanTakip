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
		// api/jobadverts
		[HttpGet]
		public IHttpActionResult GetAllJobAdvert()
		{
			JobAdvert jobAdvert = new JobAdvert();
			var list = jobAdvert.GetAllJobAdverts();
			return Ok(list);
		}
	}
}
