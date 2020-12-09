using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supermarket.API.IRestModels;

namespace Supermarket.API.RestModels
{
	public class CategoryRestModel : ICategoryRestModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}