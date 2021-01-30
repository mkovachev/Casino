namespace Casino.Commands.Helpers.Interfaces
{
    public interface ICommandManager
    {
        decimal ExecuteCommand(ICommand command);
    }
}