using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DAL
{
	public class BaseEntity : IBaseEntity
	{
		public Guid Id { get; set; }
	}
}
