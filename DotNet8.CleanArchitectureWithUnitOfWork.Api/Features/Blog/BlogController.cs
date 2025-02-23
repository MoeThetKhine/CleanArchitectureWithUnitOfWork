namespace DotNet8.CleanArchitectureWithUnitOfWork.Api.Features.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
	private IUnitOfWork _unitOfWork;

	public BlogController(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	#region GetBlogListAsync

	[HttpGet]
	public async Task<IActionResult> GetBlogListAsync()
	{
		try
		{
			var result = await _unitOfWork.BlogRepository.GetBlogListAsync();
			return Content(result);
		}
		catch (Exception ex)
		{
			return InternalServerError(ex);
		}
	}

	#endregion

	#region GetBlogListByIdAsync

	[HttpGet("blogId")]
	public async Task<IActionResult> GetBlogListByIdAsync(int blogId)
	{
		var result = await _unitOfWork.BlogRepository.GetBlogByIdAsync(blogId);
		return Content(result);
	}

	#endregion

}
