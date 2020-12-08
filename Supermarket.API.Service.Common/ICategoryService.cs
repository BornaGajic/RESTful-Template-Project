using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model;

namespace Supermarket.API.Service.Common
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync ();
    }
}
