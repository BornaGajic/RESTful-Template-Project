using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Common;
using Supermarket.API.Repository.Common.Repositories;
using Supermarket.DAL;
using Supermarket.DAL.Context;

namespace Supermarket.API.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		public  AppDbContext DbContext { get; set; }

		public ICategoryRepository CategoryRepository { get; set; }

		public UnitOfWork (AppDbContext dbContext, ICategoryRepository categoryRepository)
		{
			DbContext = dbContext;
			CategoryRepository = categoryRepository;
		}

		public virtual Task<int> AddAsync<TEntity> (TEntity entity) where TEntity : BaseEntity
		{
			return default;
		}

		public async Task<int> CommitAsync ()
		{
			throw new NotImplementedException();
		}

		public void Dispose ()
		{
			DbContext.Dispose();
		}
	}
}
