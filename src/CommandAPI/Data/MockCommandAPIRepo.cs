using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
  public class MockCommandAPIRepo : ICommandAPIRepo
  {
    public void CreateCommand(Command command)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCommand(Command command)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>()
      {
        new Command()
        {
          Id = 0, HowTo = "How to generate a migration", CommandLine = "dotnet ef migrations add <Name of the migration>", Platform = ".Net Core EF"
        },
        new Command()
        {
          Id = 1, HowTo = "Run migration", CommandLine = "dotnet ef database update", Platform = ".Net Core EF"
        },
        new Command()
        {
          Id = 2, HowTo = "List active migrations", CommandLine = "dotnet ef migrations list", Platform = ".Net Core EF"
        }
      };
      return commands;
    }

    public Command GetCommandById(int commandId)
    {
      return new Command()
      {
        Id = 0,
        HowTo = "How to generate a migration",
        CommandLine = "dotnet ef migrations add <Name of the migration>",
        Platform = ".Net Core EF"
      };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command command)
    {
      throw new System.NotImplementedException();
    }
  }
}