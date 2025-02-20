using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Enums;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain;

public class Result<T>
{
	public T Data { get; set; }
	public bool IsSuccess { get; set; }
	public bool IsError { get { return !IsSuccess; } }
	public string Message { get; set; }
	public EnumStatusCode StatusCode { get; set; }

	public static Result<T> SuccessResult(string message = "Success.", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}
}
