using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Common;
using Supermarket.API.Repository.Common.Repositories;
using Supermarket.DAL;
using Supermarket.DAL.Context;
using System.Data.Entity;

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
			DbContext.Set<TEntity>().Add(entity);
			
			return Task.FromResult(1);
		}

		public virtual Task<int> UpdateAsync<TEntity> (TEntity entity) where TEntity : BaseEntity
		{
			DbContext.Entry(entity).State = EntityState.Modified;

			return Task.FromResult(1);
		}

		public virtual Task<int> DeleteAsync<TEntity> (TEntity entity) where TEntity : BaseEntity
		{
			DbContext.Set<TEntity>().Remove(entity);

			return Task.FromResult(1);
		}

		public Task<int> CommitAsync<TEntity> ()
		{
			return DbContext.SaveChangesAsync();
		}

		public Task<int> RollbackAsync<TEntity> (TEntity entity) where TEntity : BaseEntity
		{
			DbContext.Entry(entity).State = EntityState.Unchanged;

			return Task.FromResult(1);
		}

		public void Dispose ()
		{
			DbContext.Dispose();
		}
	}
}
