using System.Data.Entity.Migrations;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Supermarket.API.IRestModels;
using Supermarket.API.IRestModels.CRUD;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.API.Model.CategoryDomainModels.CRUD;
using Supermarket.API.Model.Common.ICategoryDomainModel;
using Supermarket.API.Model.Common.ICategoryDomainModel.CRUD;
using Supermarket.API.Repository;
using Supermarket.API.Repository.Common;
using Supermarket.API.RestModels;
using Supermarket.API.RestModels.CRUD;
using Supermarket.API.Service;
using Supermarket.DAL.Context;
using Supermarket.DAL.EntityModels;

namespace Supermarket.API
{
	public class WebApiApplication : HttpApplication
	{
		protected void Application_Start ()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
			
			var builder = new ContainerBuilder();

			var config = GlobalConfiguration.Configuration;

			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<AppDbContext>().InstancePerLifetimeScope();
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

			builder.RegisterModule(new ServiceDIModule());
			builder.RegisterModule(new RepositoryDIModule());

			builder.Register(context => new MapperConfiguration(cfg => {
				cfg.CreateMap<Category, ICategory>();
				cfg.CreateMap<CategoryRestModel, ICategoryRestModel>();
				cfg.CreateMap<CategoryEntity, ICategory>();
				cfg.CreateMap<ICategory, CategoryRestModel>();

				cfg.CreateMap<ICreateCategory, CreateCategory>();
				cfg.CreateMap<ICreateCategory, CategoryEntity>();
				cfg.CreateMap<ICreateCategoryRestModel, CreateCategoryRestModel>();
				cfg.CreateMap<ICreateCategoryRestModel, ICreateCategory>();
				cfg.CreateMap<CreateCategoryRestModel, CreateCategory>();
				cfg.CreateMap<CreateCategory, CategoryEntity>();

				//cfg.CreateMap<CategoryEntity, ICategory>();
			})).AsSelf().SingleInstance();

			builder.Register(c =>
			{
				//This resolves a new context that can be used later.
				var context = c.Resolve<IComponentContext>();
				var mapperConfig = context.Resolve<MapperConfiguration>();
				return mapperConfig.CreateMapper(context.Resolve);
			})
			.As<IMapper>()
			.InstancePerLifetimeScope();

			var container = builder.Build();
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}
	}
}
