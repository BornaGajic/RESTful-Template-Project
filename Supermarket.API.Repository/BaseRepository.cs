using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Common;
using Supermarket.DAL;
using Supermarket.DAL.Context;

namespace Supermarket.API.Repository
{
	public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
	{
		private AppDbContext _context;
		private DbSet<TEntity> _dbSet; 
		
		public BaseRepository (AppDbContext context)
		{
			_context = context;
		}

		protected virtual DbSet<TEntity> Entities
		{
			get
			{
				if (_dbSet == null)
					_dbSet = _context.Set<TEntity>();

				return _dbSet;
			}
		}

		public async virtual Task<TEntity> GetByIdAsync (int id)
		{
			return await Entities.FindAsync(id);
		}

		public async virtual Task<IEnumerable<TEntity>> ExecuteQuery (TEntity entity, string sqlQuery)
		{
			var listifiedResult = await Task.Run(() => {return Entities.SqlQuery(sqlQuery).ToList();}); 

			return listifiedResult;
		}

		public virtual IQueryable<TEntity> Table => Entities;
		public virtual IQueryable<TEntity> TableAsNoTracking => Entities.AsNoTracking();
		
	}
}
