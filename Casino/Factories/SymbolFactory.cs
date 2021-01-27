using Casino.Data.Interfaces;
using Casino.Data.Models;

namespace Casino.Factories
{
    public class SymbolFactory : ISymbolFactory
    {
        public ISymbol CreateApple() => new Apple();

        public ISymbol CreateBanana() => new Banana();

        public ISymbol CreatePineapple() => new Pineapple();

        public ISymbol CreateWildcard() => new Wildcard();
    }
}
