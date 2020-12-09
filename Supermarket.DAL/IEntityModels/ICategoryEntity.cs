using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.DAL.EntityModels;

namespace Supermarket.DAL.IEntityModels
{
	public interface ICategoryEntity
	{
		int Id { get; set; }
		string Name { get; set; }
		IList<ProductEntity> Products { get; set; }
	}
}
