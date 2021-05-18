using CommandsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsWebApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Design the api", Line = "Plan on how to build the api", Platform = "DevJob" },
                new Command { Id = 1, HowTo = "Devlop the api", Line = "Code the api", Platform = "A coding machine" },
                new Command { Id = 2, HowTo = "Deploy the api", Line = "Ship the api on some hosting service", Platform = "Hoster" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Design the api", Line = "Plan on how to build the api", Platform = "DevJob" };
        }
    }
}
