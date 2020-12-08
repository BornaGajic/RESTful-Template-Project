using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model;
using Supermarket.API.Repository.Common;
using Supermarket.DAL.Context;

namespace Supermarket.API.Repository.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository (AppDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Category>> ListAsync ()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
