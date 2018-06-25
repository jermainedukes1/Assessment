using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorMvcApp.Models
{
	public class Vehicle
	{
		public int Id { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }
		public string Model { get; set; }
		public string vin { get; set; }
		public virtual Owner Owner { get; set; }

		public Vehicle()
		{

		}
	}
}