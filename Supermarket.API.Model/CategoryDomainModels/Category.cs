using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supermarket.API.Model.Common.ICategoryDomainModel;

namespace Supermarket.API.Model.CategoryDomainModels
{
	public class Category : ICategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}