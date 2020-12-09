using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Common.Repositories;
using Supermarket.DAL;

namespace Supermarket.API.Repository.Common
{
	public interface IUnitOfWork : IDisposable
	{
		ICategoryRepository CategoryRepository { get; set; }

		Task<int> CommitAsync();

		Task<int> AddAsync<TEntity> (TEntity entity) where TEntity : BaseEntity;
	}
}
