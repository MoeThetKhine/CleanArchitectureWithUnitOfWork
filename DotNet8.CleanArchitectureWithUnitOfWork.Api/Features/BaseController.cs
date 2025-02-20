using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Api.Features;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{

	#region Content

	protected IActionResult Content(object obj)
	{
		return Ok(JsonConvert.SerializeObject(obj));
	}

	#endregion

	protected IActionResult InternalServerError(Exception ex)
	{
		return StatusCode(500, ex.Message);
	}
}
