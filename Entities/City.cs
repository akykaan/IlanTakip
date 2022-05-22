using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class City
	{
		[Key]
		public int CityId { get; set; }
		public string CityName { get; set; }

		public List<JobAdvert> JobAdvert { get; set; }

		public List<City> GetAllCity()
		{
			using (DataAccessLayer.IlanTakipDbEntities db = new DataAccessLayer.IlanTakipDbEntities())
			{
				var result = from c in db.Cities.ToList()
							 select new City
							 {
								 CityName = c.CityName,

							 };
							  
				return result.ToList();
			}
		}
	}
}
