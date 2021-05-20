using CommandsWebApi.Models;
using System.Collections.Generic;

namespace CommandsWebApi.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
