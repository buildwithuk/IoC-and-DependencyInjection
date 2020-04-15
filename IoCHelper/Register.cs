using Microsoft.Extensions.DependencyInjection;
using Model.Models;
using System;

namespace IoCHelper
{
	public class Register
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Add the Database Context here
			services.AddDbContext<IoCContext>();
		}
	}
}
