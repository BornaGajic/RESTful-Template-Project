using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.API.Model.Common.ICategoryDomainModel.CRUD
{
	public interface ICreateCategory
	{
		Guid Id { get; set; }
		string Name { get; set; }
	}
}
