using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.DAL.IEntityModels;

namespace Supermarket.DAL.EntityModels
{
	public class CategoryEntity : BaseEntity, ICategoryEntity
	{
		public string Name { get; set; }
		public IList<ProductEntity> Products { get; set; }
	}
}
