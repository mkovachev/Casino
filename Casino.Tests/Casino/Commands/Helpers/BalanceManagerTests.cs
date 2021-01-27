using Casino.Commands.Helpers;
using Xunit;

namespace Casino.Tests.Casino.Commands.Helpers
{
    public class BalanceManagerTests
    {

        [Fact]
        public void Hanlde_Should_Return_TotalBalance_Of_Type_Decimal()
        {
            var balanceManager = new BalanceManager();

            var result = balanceManager.Handle(1, 1, 1);

            Assert.IsType<decimal>(result);
        }

        [Fact]
        public void Hanlde_Should_Calculated_TotalBalance_Correctly()
        {
            var balanceManager = new BalanceManager();

            var result = balanceManager.Handle(1, 1, 1);

            Assert.Equal(1, result);
        }
    }
}
