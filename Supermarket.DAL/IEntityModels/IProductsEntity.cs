using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.Common;
using Supermarket.DAL.EntityModels;

namespace Supermarket.DAL.IEntityModels
{
	public interface IProductsEntity
	{
		int Id { get; set; }
		string Name { get; set; }
		short QuantityInPackage { get; set; }
		EUnitOfMeasurement UnitOfMeasurement { get; set; }

		int CategoryId { get; set; }
		CategoryEntity CategoryEntity { get; set; }
	}
}
