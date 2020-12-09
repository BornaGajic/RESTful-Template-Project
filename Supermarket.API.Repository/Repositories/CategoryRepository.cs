using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Common.Repositories;
using Supermarket.DAL.Context;
using Supermarket.DAL.EntityModels;

namespace Supermarket.API.Repository.Repositories
{
	public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository (AppDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<CategoryEntity>> ListAsync ()
        {
            return await Entities.ToListAsync();
        }
    }
}
