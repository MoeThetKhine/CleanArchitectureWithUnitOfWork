using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

public interface IBlogRepository
{
	Task<Result<BlogListResponseModel>> GetBlogListAsync();
}
