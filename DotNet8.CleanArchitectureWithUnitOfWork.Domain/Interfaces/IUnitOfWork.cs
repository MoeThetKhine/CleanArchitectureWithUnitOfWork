namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

public interface IUnitOfWork
{
	IBlogRepository BlogRepository { get; }
}
