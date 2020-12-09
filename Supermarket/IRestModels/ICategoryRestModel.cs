using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.API.IRestModels
{
	public interface ICategoryRestModel
	{
		int Id { get; set; }
		string Name { get; set; }
	}
}
