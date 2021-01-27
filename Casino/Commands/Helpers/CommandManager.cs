using Casino.Commands.Helpers.Interfaces;

namespace Casino.Commands.Helpers
{
    public class CommandManager : ICommandManager
    {
        private readonly ICommand playSlot;
        public CommandManager(ICommand playSlot)
        {
            this.playSlot = playSlot;
        }

        public decimal Handle() => this.playSlot.Execute();
    }
}
