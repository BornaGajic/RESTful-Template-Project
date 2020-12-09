using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DAL
{
	public interface IBaseEntity
	{
		Guid Id { get; set; }
	}
}
