namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class BlogRepository : IBlogRepository
{
	private readonly AppDbContext _context;

	public BlogRepository(AppDbContext context)
	{
		_context = context;
	}

	#region GetBlogByIdAsync

	public async Task<Result<BlogResponseModel>> GetBlogByIdAsync(int blogId)
	{
		Result<BlogResponseModel> result;

		try
		{
			var blog = await _context.TblBlogs
				.FirstOrDefaultAsync(x => x.BlogId == blogId);

			if (blog is null)
			{
				result = Result<BlogResponseModel>.FailureResult(new Exception("Blog not found"));
			}
			else
			{
				var blogResponse = new BlogResponseModel
				{
					BlogTitle = blog.BlogTitle,
					BlogAuthor = blog.BlogAuthor,
					BlogContent = blog.BlogContent,
				};

				result = Result<BlogResponseModel>.SuccessResult(blogResponse);
			}
		}
		catch (Exception ex)
		{
			result = Result<BlogResponseModel>.FailureResult(ex);
		}

		return result;
	}

	#endregion


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
