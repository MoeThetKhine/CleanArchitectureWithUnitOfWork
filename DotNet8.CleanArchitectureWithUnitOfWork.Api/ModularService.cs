using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;
using DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Api;

public static class ModularService
{
	private static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
	{
		builder.Services.AddDbContext<AppDbContext>(
			opt =>
			{
				opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
				opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
			}, ServiceLifetime.Transient
			);

		return services;
	}

	private static IServiceCollection AddUnitOfWorkService(this IServiceCollection services)
	{
		services.AddScoped<IUnitOfWork, UnitOfWork>();
		return services;
	}

}
