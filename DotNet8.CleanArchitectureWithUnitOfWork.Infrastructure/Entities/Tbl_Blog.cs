namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Entities;

#region Tbl_Blog

public class Tbl_Blog
{
	public int BlogId { get; set; }
	public string BlogTitle { get; set; }
	public string BlogAuthor { get; set; }
	public string BlogContent { get; set; }
}

#endregion