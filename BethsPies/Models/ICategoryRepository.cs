using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethsPies.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories { get; }
	}
}
