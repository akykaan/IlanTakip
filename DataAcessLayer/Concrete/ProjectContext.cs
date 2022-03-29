using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
	public class ProjectContext: DbContext
	{

		public DbSet<Candidate> Candidates { get; set; }
		public DbSet<City> Citys { get; set; }
		public DbSet<Cv> Cvs { get; set; }
		public DbSet<Employer> Employers { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<JobAdvert> JobAdverts { get; set; }
		public DbSet<JobExperience> JobExperiences { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<School> Schools { get; set; }
	}
}
