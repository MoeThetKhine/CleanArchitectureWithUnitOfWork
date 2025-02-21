namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class BlogRepository : IBlogRepository
{
	private readonly AppDbContext _context;

	public BlogRepository(AppDbContext context)
	{
		_context = context;
	}

	#region GetBlogListAsync

	public async Task<Result<BlogListResponseModel>> GetBlogListAsync()
	{
		Result<BlogListResponseModel> result;

		try
		{
			var lst = await _context.TblBlogs
				.OrderByDescending(x => x.BlogId)
				.ToListAsync();

			var model = new BlogListResponseModel { Blogs = lst.Select(x => x.Change()).ToList() };

			result =  Result<BlogListResponseModel>.SuccessResult(model);
		}
		catch (Exception ex)
		{
			result = Result<BlogListResponseModel>.FailureResult(ex);
		}
		return result;
	}

	#endregion
}
