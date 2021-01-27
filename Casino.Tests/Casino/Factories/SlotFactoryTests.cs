using Casino.Data.Interfaces;
using Casino.Data.Models;
using Casino.Factories;
using Moq;
using Xunit;

namespace Casino.Tests.Casino.Factories
{
    public class SlotFactoryTests
    {
        [Fact]
        public void CreateSlot_Should_Be_AssignableFrom_ISlot_Interface()
        {
            var symbolFactory = new Mock<ISymbolFactory>().Object;
            var slotFactory = new SlotFactory(symbolFactory);

            var result = slotFactory.CreateSlot();

            Assert.IsAssignableFrom<ISlot>(result);
        }

        [Fact]
        public void CreateSloty_Should_Return_Object_Of_Type_Slot()
        {
            var symbolFactory = new Mock<ISymbolFactory>().Object;
            var slotFactory = new SlotFactory(symbolFactory);

            var result = slotFactory.CreateSlot();

            Assert.IsType<Slot>(result);
        }

        [Fact]
        public void CreateSlot_Should_Not_Be_Null()
        {
            var symbolFactory = new Mock<ISymbolFactory>().Object;
            var slotFactory = new SlotFactory(symbolFactory);

            var result = slotFactory.CreateSlot();

            Assert.NotNull(result);
        }

    }
}
