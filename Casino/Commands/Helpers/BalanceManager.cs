using Casino.Commands.Helpers.Interfaces;

namespace Casino.Commands.Helpers
{
    public class BalanceManager : IBalanceManager
    {
        public decimal Handle(decimal totalCoefficients, decimal betAmont, decimal totalBalance)
            => (totalBalance - betAmont) + (betAmont * totalCoefficients);
    }
}
