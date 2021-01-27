namespace Casino.Commands.Helpers.Interfaces
{
    public interface IBalanceManager
    {
        decimal Handle(decimal totalCoefficients, decimal betAmont, decimal totalBalance);
    }
}
