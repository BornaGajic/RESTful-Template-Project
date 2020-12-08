using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Supermarket.API.Repository.Common;
using Supermarket.API.Repository.Repositories;
using Supermarket.API.Service;
using Supermarket.API.Service.Common;
using Supermarket.DAL.Context;

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
			builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
			builder.RegisterType<CategoryService>().As<ICategoryService>();

			var container = builder.Build();
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}
	}
}
