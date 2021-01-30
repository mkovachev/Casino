using Casino.Commands.Helpers.Interfaces;

namespace Casino.Commands.Helpers
{
    public class CommandManager : ICommandManager
    {
        public decimal ExecuteCommand(ICommand command) => command.Execute();
    }
}
