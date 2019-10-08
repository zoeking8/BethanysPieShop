using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethsPies.Models;

namespace BethsPies.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Pie> PiesOfTheWeek { get; set; }
	}
}
