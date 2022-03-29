using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Language
	{
		[Key]
		public int Id { get; set; }
		public Cv Cv { get; set; }
		public int LanguageLevel { get; set; }
		public string LanguageName { get; set; }
		public int ProgrammingLanguageLevel { get; set; }
		public string ProgrammingLanguageName { get; set; }
	}
}
