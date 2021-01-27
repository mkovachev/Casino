using Casino.Commands;
using Casino.Commands.Helpers.Interfaces;
using Casino.Data.Interfaces;
using Casino.Data.Models;
using Casino.Factories;
using Casino.Infrastructure.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Casino.Tests.Casino.Commands
{
    public class PlaySlotCommandTests
    {
        private readonly Mock<ISymbolFactory> symbolFactory;
        private readonly Mock<ISlot> slot;
        private readonly Mock<ISlotFactory> slotFactory;
        private readonly Mock<ISymbolManager> symbolManager;
        private readonly Mock<IWriter> writer;
        private readonly Mock<IMath> mathProvider;

        public PlaySlotCommandTests()
        {
            this.slot = new Mock<ISlot>();
            this.symbolFactory = new Mock<ISymbolFactory>();
            this.slotFactory = new Mock<ISlotFactory>();
            this.symbolManager = new Mock<ISymbolManager>();
            this.writer = new Mock<IWriter>();
            this.mathProvider = new Mock<IMath>();
        }

        [Fact]
        public void Command_Should_Call_CreateSlot_Once()
        {
            var playSlotCommand = new PlaySlotCommand(this.symbolManager.Object, this.writer.Object, this.slotFactory.Object, this.mathProvider.Object);

            slotFactory.Setup(sf => sf.CreateSlot()).Returns(new Slot(this.symbolFactory.Object));

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            symbolManager.Setup(sm => sm.CreateRandomSymbol(It.IsAny<IReadOnlyList<ISymbol>>()))
                .Returns(new Apple());

            var result = playSlotCommand.Execute();

            slotFactory.Verify(sf => sf.CreateSlot(), Times.Once);
        }

        [Fact]
        public void Command_Should_Call_CreateRandomSymbol_Twelve_Times_Exactly()
        {
            var playSlotCommand = new PlaySlotCommand(this.symbolManager.Object, this.writer.Object, this.slotFactory.Object, this.mathProvider.Object);

            slotFactory.Setup(sf => sf.CreateSlot()).Returns(new Slot(this.symbolFactory.Object));

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            symbolManager.Setup(sm => sm.CreateRandomSymbol(It.IsAny<IReadOnlyList<ISymbol>>()))
                .Returns(new Apple());

            var result = playSlotCommand.Execute();

            symbolManager.Verify(sm => sm.CreateRandomSymbol(It.IsAny<IReadOnlyList<ISymbol>>()), Times.Exactly(12));
        }

        [Fact]
        public void Command_Should_Call_PopulateSymbols()
        {
            var playSlotCommand = new PlaySlotCommand(this.symbolManager.Object, this.writer.Object, this.slotFactory.Object, this.mathProvider.Object);

            slotFactory.Setup(sf => sf.CreateSlot()).Returns(new Slot(this.symbolFactory.Object));

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            symbolManager.Setup(sm => sm.CreateRandomSymbol(It.IsAny<IReadOnlyList<ISymbol>>()))
                .Returns(new Apple());

            var result = playSlotCommand.Execute();

            slot.Setup(s => s.PopulateSymbols()).Verifiable();
        }

        [Fact]
        public void Command_Should_Return_TotalCoefficient_Type_Of_Decimal()
        {
            var playSlotCommand = new PlaySlotCommand(this.symbolManager.Object, this.writer.Object, this.slotFactory.Object, this.mathProvider.Object);

            slotFactory.Setup(sf => sf.CreateSlot()).Returns(new Slot(this.symbolFactory.Object));

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            symbolManager.Setup(sm => sm.CreateRandomSymbol(It.IsAny<IReadOnlyList<ISymbol>>()))
                .Returns(new Apple());

            var result = playSlotCommand.Execute();

            slot.Setup(s => s.PopulateSymbols()).Verifiable();

            Assert.IsType<decimal>(result);
        }
    }
}
