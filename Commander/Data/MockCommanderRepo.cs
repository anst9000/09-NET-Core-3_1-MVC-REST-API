using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boil an egg", Line = "boil water", Platform = "Kettle and pan" },
                new Command { Id = 2, HowTo = "Cut bread", Line = "get a knife", Platform = "Knife and chopping board" },
                new Command { Id = 3, HowTo = "Make cup of tea", Line = "place teabag in cup", Platform = "Kettle and cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = id, HowTo = "Boil an egg", Line = "boil water", Platform = "Kettle and pan" };
        }
    }
}