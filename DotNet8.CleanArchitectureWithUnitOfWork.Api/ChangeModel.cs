﻿using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog;
using DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.AppDbContextModels;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Api;

public static class ChangeModel
{

	#region BlogModel Change

	public static BlogModel Change(this TblBlog dataModel)
	{
		return new BlogModel
		{
			BlogId = dataModel.BlogId,
			BlogTitle = dataModel.BlogTitle,
			BlogAuthor = dataModel.BlogAuthor,
			BlogContent = dataModel.BlogContent,
		};
	}

	#endregion

}
