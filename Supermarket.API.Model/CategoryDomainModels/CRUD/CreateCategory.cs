using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model.Common.ICategoryDomainModel.CRUD;

namespace Supermarket.API.Model.CategoryDomainModels.CRUD
{
	public class CreateCategory : ICreateCategory
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}
