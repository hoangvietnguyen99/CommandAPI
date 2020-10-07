using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
  [Route("api/{controller}")]
  [ApiController]
  public class CommandsController : ControllerBase //Có thể dùng Controller, nhưng Controller có hỗ trợ view, API thì k cần view nên dùng ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "this", "is", "hard", "coded" };
    }
  }
}