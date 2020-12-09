using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Common;

namespace Supermarket.API.Model.Common.IProductDomainModel
{
	public interface IProduct
	{
		Guid Id { get; set; }
		string Name { get; set; }
		short QuantityInPackage { get; set; }
		EUnitOfMeasurement UnitOfMeasurement { get; set; }
	}
}
