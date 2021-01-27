using Casino.Data.Models;
using Casino.Factories;
using Moq;
using Xunit;

namespace Casino.Tests.Casino.Data.Models
{
    public class SlotTests
    {
        private readonly Mock<ISymbolFactory> symbolFactory;

        public SlotTests()
        {
            this.symbolFactory = new Mock<ISymbolFactory>();
        }

        [Fact]
        public void SlotData_Should_Not_Be_Empty()
        {
            var slot = new Slot(this.symbolFactory.Object);

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            var slotData = slot.SlotData;

            Assert.NotNull(slotData);
        }

        [Fact]
        public void PopulateSymbols_Should_Add_Four_Symbols()
        {
            var slot = new Slot(this.symbolFactory.Object);

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            slot.PopulateSymbols();

            Assert.True(slot.SlotData.Count == 4);
        }

        [Fact]
        public void PopulateSymbols_Should_Contains_Exact_Four_Symbols()
        {
            var slot = new Slot(this.symbolFactory.Object);

            var apple = this.symbolFactory.Setup(sf => sf.CreateApple()).Returns(new Apple());
            var banana = this.symbolFactory.Setup(sf => sf.CreateBanana()).Returns(new Banana());
            var pineApple = this.symbolFactory.Setup(sf => sf.CreatePineapple()).Returns(new Pineapple());
            var wildCard = this.symbolFactory.Setup(sf => sf.CreateWildcard()).Returns(new Wildcard());

            slot.PopulateSymbols();

            Assert.Collection(slot.SlotData,
                                s => s.Name.Contains("Apple"),
                                s => s.Name.Contains("Banana"),
                                s => s.Name.Contains("Pineapple"),
                                s => s.Name.Contains("Wildcard"));
        }
    }
}
