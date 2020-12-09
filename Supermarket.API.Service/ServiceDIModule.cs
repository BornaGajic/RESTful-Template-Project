using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using Supermarket.API.Model.CategoryDomainModels;
using Supermarket.API.Model.Common.ICategoryDomainModel;
using Supermarket.API.Service.Common;
using Supermarket.DAL.EntityModels;

namespace Supermarket.API.Service
{
	public class ServiceDIModule : Module
	{
		protected override void Load (ContainerBuilder builder)
		{
			builder.RegisterType<CategoryService>().As<ICategoryService>();
		}
	}
}
