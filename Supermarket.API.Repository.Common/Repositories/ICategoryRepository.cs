using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.DAL.EntityModels;

namespace Supermarket.API.Repository.Common.Repositories
{
	public interface ICategoryRepository
	{
		Task<IEnumerable<CategoryEntity>> ListAsync ();
	}
}
