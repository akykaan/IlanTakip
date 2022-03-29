using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Event
	{
		[Key]
		public int EventId { get; set; }
		public string EventTitle { get; set; }
		public string EventOwner { get; set; }
		public DateTime EventDay { get; set; } 

	}
}
