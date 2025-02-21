namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

#region IBlogRepository

public interface IBlogRepository
{
	Task<Result<BlogListResponseModel>> GetBlogListAsync();
}

#endregion
