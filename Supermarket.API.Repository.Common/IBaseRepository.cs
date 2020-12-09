using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.API.Repository.Common
{
	public interface IBaseRepository<TEntity>
	{
		Task<TEntity> GetByIdAsync (int id);
		IQueryable<TEntity> Table { get; }
		IQueryable<TEntity> TableAsNoTracking { get; }
	}
}
