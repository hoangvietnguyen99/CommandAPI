//this folder configure the mapping of our Model to our DTO
using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Profiles
{
  public class CommandsProfile : Profile //inherits from Automapper.Profile
  {
    public CommandsProfile()
    {
			CreateMap<Command, CommandReadDto>(); //method to map source object (Command) to target object (CommandReadDto)

      CreateMap<CommandCreateDto, Command>(); //method to map source object (CommandCreateDto) to target object (Command)

      CreateMap<CommandUpdateDto, Command>(); //method to map source object (CommandUpdateDto) to target object (Command)

      CreateMap<Command, CommandUpdateDto>(); //method to map source object (Command) to target object (CommandUpdateDto)
    }
  }
}