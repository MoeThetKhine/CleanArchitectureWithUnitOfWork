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
}
