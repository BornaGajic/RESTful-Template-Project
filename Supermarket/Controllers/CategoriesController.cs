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
using Supermarket.API.RestModels.CRUD;
using AutoMapper;
using Supermarket.API.IRestModels.CRUD;
using Supermarket.API.Model.Common.ICategoryDomainModel.CRUD;
using Supermarket.API.IRestModels;

namespace Supermarket.API.Controllers
{
    [RoutePrefix("api/Categories")]
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
        [Route("all")]
        public async Task<IEnumerable<CategoryRestModel>> GetAllAsync ()
        {
            var categoriesDomainmodel = await CategoryService.ListAsync();

            return Mapper.Map<IEnumerable<CategoryRestModel>>(categoriesDomainmodel);
        }

        [HttpPost]
        [Route("new")]
        public async Task<HttpResponseMessage> CreateCategoryAsync ([FromBody] CreateCategoryRestModel createCategoryRest)
        {
            var createCategory = Mapper.Map<ICreateCategory>(createCategoryRest);

            try
            {
                await CategoryService.CreateCategoryAsync(createCategory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
