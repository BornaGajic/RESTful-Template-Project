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
using Supermarket.API.Model.Common.ICategoryDomainModel.CRUD;
using Supermarket.DAL.EntityModels;

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

		public async Task<bool> CreateCategoryAsync (ICreateCategory createCategory)
		{
			createCategory.Id = Guid.NewGuid();
			var categoryEntity = Mapper.Map<CategoryEntity>(createCategory);
			
			try
			{
				await UnitOfWork.AddAsync<CategoryEntity>(categoryEntity);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				
				await UnitOfWork.RollbackAsync<CategoryEntity>(categoryEntity);

				return false;
			}
			
			await UnitOfWork.CommitAsync<CategoryEntity>();

			return true;
		}
	}
}
