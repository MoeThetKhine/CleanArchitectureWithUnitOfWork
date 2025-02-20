using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Enums;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain;

public class Result<T>
{
	public T Data { get; set; }
	public bool IsSuccess { get; set; }
	public bool IsError { get { return !IsSuccess; } }
	public string Message { get; set; }
	public EnumStatusCode StatusCode { get; set; }
}
