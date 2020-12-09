using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.Common;

namespace Supermarket.API.Model.ProductDomainModels
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public short QuantityInPackage { get; set; }
		public EUnitOfMeasurement UnitOfMeasurement { get; set; }
	}
}