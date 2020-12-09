using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Common;
using Supermarket.DAL.IEntityModels;

namespace Supermarket.DAL.EntityModels
{
	public class ProductEntity : BaseEntity, IProductsEntity
	{
		public string Name { get; set; }
		public short QuantityInPackage { get; set; }
		public EUnitOfMeasurement UnitOfMeasurement { get; set; }

		public int CategoryId { get; set; }
		public CategoryEntity CategoryEntity { get; set; }
	}
}
