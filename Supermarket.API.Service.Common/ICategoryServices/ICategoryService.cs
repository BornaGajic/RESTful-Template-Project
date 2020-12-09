using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model.Common.ICategoryDomainModel;
using Supermarket.API.Model.Common.ICategoryDomainModel.CRUD;

namespace Supermarket.API.Service.Common
{
	public interface ICategoryService
    {
        Task<IEnumerable<ICategory>> ListAsync ();
        Task<bool> CreateCategoryAsync (ICreateCategory createCategory);
    }
}
