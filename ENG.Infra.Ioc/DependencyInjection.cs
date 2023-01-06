using Eng.Domain.Interfaces;
using Eng.Infra.Data.Context;
using Eng.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eng.Application.Interfaces;
using Eng.Application.Mappings;
using Eng.Application.Services;

namespace ENG.Infra_Ioc
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
			 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
			), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IProductService, ProductService>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
			return services;
		}
	}
}
