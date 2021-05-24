using AutoMapper;
using CommandsWebApi.Dtos;
using CommandsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsWebApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // our command model object -> the target command dto object
            CreateMap<Command, CommandReadDto>();

            // The recieved command object -> to the command model object
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
