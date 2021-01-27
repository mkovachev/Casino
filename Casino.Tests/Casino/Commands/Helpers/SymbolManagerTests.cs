using Casino.Commands.Helpers;
using Casino.Data.Enums;
using Casino.Data.Interfaces;
using Casino.Data.Models;
using Casino.Infrastructure.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Casino.Tests.Casino.Commands.Helpers
{
    public class SymbolManagerTests
    {
        private readonly Mock<IRandom> random;
        private readonly Mock<IWriter> writer;

        public SymbolManagerTests()
        {
            this.random = new Mock<IRandom>();
            this.writer = new Mock<IWriter>();
        }

        [Fact]
        public void CreateRandomSymbol_Should_Return_Symbol_AssignableFrom_ISymbol()
        {
            var symbolManager = new SymbolManager(random.Object, writer.Object);

            random.Setup(r => r.NextDouble()).Returns(0.1);

            var slotData = new List<ISymbol>()
            {
                { new Apple() },
                { new Banana() },
                { new Pineapple() },
                { new Wildcard() }
            };

            var result = symbolManager.CreateRandomSymbol(slotData);

            Assert.IsAssignableFrom<ISymbol>(result);
        }

        [Fact]
        public void CreateRandomSymbol_Should_Return_Correct_SymbolType()
        {
            var symbolManager = new SymbolManager(random.Object, writer.Object);

            random.Setup(r => r.NextDouble()).Returns(0.1);

            var slotData = new List<ISymbol>()
            {
                { new Apple() },
                { new Banana() },
                { new Pineapple() },
                { new Wildcard() }
            };

            var result = symbolManager.CreateRandomSymbol(slotData);

            Assert.True(result.Type == SymbolType.Apple);
        }
    }
}
