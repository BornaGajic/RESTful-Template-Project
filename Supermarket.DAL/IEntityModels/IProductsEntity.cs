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
		Guid Id { get; set; }
		string Name { get; set; }
		short QuantityInPackage { get; set; }
		EUnitOfMeasurement UnitOfMeasurement { get; set; }

		Guid CategoryId { get; set; }
		CategoryEntity CategoryEntity { get; set; }
	}
}
