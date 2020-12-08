using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.DAL.Context;

namespace Supermarket.API.Repository
{
	public abstract class BaseRepository
	{
		protected readonly AppDbContext _context;

		public BaseRepository (AppDbContext context)
		{
			_context = context;
		}
	}
}
