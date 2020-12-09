using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DAL
{
	public class BaseEntity : IBaseEntity
	{
		public int Id { get; set; }
	}
}
