namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog;

#region BlogResponseModel

public class BlogResponseModel
{
	public string BlogTitle { get; set; } = null!;

	public string BlogAuthor { get; set; } = null!;

	public string BlogContent { get; set; } = null!;
}

#endregion