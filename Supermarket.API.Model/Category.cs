using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermarket.API.Model
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Product> Products { get; set; } = new List<Product>();
	}
}