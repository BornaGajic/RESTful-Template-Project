using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Supermarket.API.Service.Common;
using System.Threading.Tasks;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.API.RestModels;
using AutoMapper;

namespace Supermarket.API.Controllers
{
	public class CategoriesController : ApiController
    {
        public ICategoryService CategoryService { get; set; }
        public IMapper Mapper { get; set; }

        public CategoriesController (ICategoryService categoryService, IMapper mapper)
        {
            CategoryService = categoryService;
            Mapper = mapper;
        }

        [HttpGet]
        [Route("api/CategoriesController/all")]
        public async Task<IEnumerable<CategoryRestModel>> GetAllAsync ()
        {
            var categoriesDomainmodel = await CategoryService.ListAsync();

            return Mapper.Map<IEnumerable<CategoryRestModel>>(categoriesDomainmodel);
        }
    }
}
