namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
	private IBlogRepository _blogRepository;
	private IServiceProvider _serviceProvider;

	public UnitOfWork(IBlogRepository blogRepository, IServiceProvider serviceProvider)
	{
		_blogRepository = blogRepository;
		_serviceProvider = serviceProvider;
	}

	public IBlogRepository BlogRepository =>
	   _blogRepository ??= _serviceProvider.GetRequiredService<IBlogRepository>();
}
