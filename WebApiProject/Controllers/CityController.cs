using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class CityController : ApiController
    {
		[HttpGet]
		public IHttpActionResult GetAllCity()
		{
			//List<Candidates> list = db.Candidates.ToList();

			City city = new City();
			var list = city.GetAllCity();
			return Ok(list);
		}


	}
}
