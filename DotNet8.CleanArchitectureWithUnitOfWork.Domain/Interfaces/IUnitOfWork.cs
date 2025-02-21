namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

#region IUnitOfWork

public interface IUnitOfWork
{
	IBlogRepository BlogRepository { get; }
}

#endregion