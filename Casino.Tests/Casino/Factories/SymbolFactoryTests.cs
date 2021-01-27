using Casino.Data.Interfaces;
using Casino.Factories;
using Xunit;

namespace Casino.Tests.Casino.Factories
{
    public class SymbolFactoryTests
    {
        [Fact]
        public void CreateApple_Should_Be_AssignableFrom_ISymbol_Interface()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateApple();

            Assert.IsAssignableFrom<ISymbol>(result);
        }

        [Fact]
        public void CreateApple_Should_Not_Be_Null()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateApple();

            Assert.NotNull(result);
        }

        [Fact]
        public void CreateBanana_Should_Be_AssignableFrom_ISymbol_Interface()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateBanana();

            Assert.IsAssignableFrom<ISymbol>(result);
        }

        [Fact]
        public void CreateBanana_Should_Not_Be_Null()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateBanana();

            Assert.NotNull(result);
        }

        [Fact]
        public void CreatePineapple_Should_Be_AssignableFrom_ISymbol_Interface()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreatePineapple();

            Assert.IsAssignableFrom<ISymbol>(result);
        }

        [Fact]
        public void CreatePineapple_Should_Not_Be_Null()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreatePineapple();

            Assert.NotNull(result);
        }

        [Fact]
        public void CreateWildcard_Should_Be_AssignableFrom_ISymbol_Interface()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateWildcard();

            Assert.IsAssignableFrom<ISymbol>(result);
        }

        [Fact]
        public void CreateWildcard_Should_Not_Be_Null()
        {
            var symbolFactory = new SymbolFactory();

            var result = symbolFactory.CreateWildcard();

            Assert.NotNull(result);
        }
    }
}
