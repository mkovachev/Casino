using Casino.Commands;
using Casino.Commands.Helpers;
using Moq;
using Xunit;

namespace Casino.Tests.Casino.Commands.Helpers
{
    public class CommandManagerTests
    {
        private readonly Mock<ICommand> playSlot;

        public CommandManagerTests()
        {
            this.playSlot = new Mock<ICommand>();
        }

        [Fact]
        public void Handle_Calls_PlaySlot_Handle_Once()
        {
            var commandManager = new CommandManager();

            var result = commandManager.ExecuteCommand(this.playSlot.Object);

            playSlot.Verify(ps => ps.Execute(), Times.Once);
        }

        [Fact]
        public void Handle_Calls_PlaySlot_Handle_And_Returns_Decimal()
        {
            var commandManager = new CommandManager();

            var result = commandManager.ExecuteCommand(this.playSlot.Object);

            playSlot.Verify(ps => ps.Execute(), Times.Once);
            Assert.IsType<decimal>(result);
        }
    }
}
