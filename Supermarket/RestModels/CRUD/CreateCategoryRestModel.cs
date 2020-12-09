using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Supermarket.API.IRestModels.CRUD;

namespace Supermarket.API.RestModels.CRUD
{
	public class CreateCategoryRestModel : ICreateCategoryRestModel
	{
		[Required]
		[StringLength(maximumLength: 30, MinimumLength = 1)]
		public string Name { get; set; }
	}
}