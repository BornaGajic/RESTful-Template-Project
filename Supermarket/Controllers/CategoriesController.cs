using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Supermarket.API.Service.Common;
using Supermarket.API.Model;
using System.Threading.Tasks;

namespace Supermarket.API.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("api/CategoriesController/all")]
        public async Task<IEnumerable<Category>> GetAllAsync ()
        {
            var categories = await _categoryService.ListAsync();

            return categories;
        }
    }
}
