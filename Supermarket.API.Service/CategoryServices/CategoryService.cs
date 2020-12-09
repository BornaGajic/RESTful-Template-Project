using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Service.Common;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.API.Repository.Common.Repositories;
using Supermarket.API.Model.Common.ICategoryDomainModel;
using Supermarket.API.Repository.Common;
using AutoMapper;

namespace Supermarket.API.Service
{
	public class CategoryService : ICategoryService
	{
		public IUnitOfWork UnitOfWork { get; set; }
		public IMapper Mapper { get; set; }

        public CategoryService (IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
			Mapper = mapper;
        }

		public async Task<IEnumerable<ICategory>> ListAsync ()
		{
			var categoriesEntified = await UnitOfWork.CategoryRepository.ListAsync();

			return Mapper.Map<IEnumerable<ICategory>>(categoriesEntified);
		}
	}
}
