using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Repository.Repositories;
using Supermarket.API.Repository.Common.Repositories;
using Autofac;
using AutoMapper;

namespace Supermarket.API.Repository
{
	public class RepositoryDIModule : Module
	{
		protected override void Load (ContainerBuilder builder)
		{
			builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
		}
	}
}
