using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
  [Route("api/{controller}")]
  [ApiController]
  public class CommandsController : ControllerBase //Có thể dùng Controller, nhưng Controller có hỗ trợ view, API thì k cần view nên dùng ControllerBase
  {
    private readonly ICommandAPIRepo _repository;

    public CommandsController(ICommandAPIRepo repository) //Constructor dependency injection
    {
      _repository = repository;
    }

    // [HttpGet]
    // public ActionResult<IEnumerable<string>> Get()
    // {
    //   return new string[] { "this", "is", "hard", "coded" };
    // }
    [HttpGet]
    public ActionResult<IEnumerable<Command>> Get()
    {
      var commands = _repository.GetAllCommands();

      return Ok(commands);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var command = _repository.GetCommandById(id);

      if (command == null)
      {
        return NotFound();
      }

      return Ok(command);
    }
  }
}