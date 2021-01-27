using Casino.Data.Interfaces;

namespace Casino.Factories
{
    public interface ISymbolFactory
    {
        ISymbol CreateApple();

        ISymbol CreateBanana();

        ISymbol CreatePineapple();

        ISymbol CreateWildcard();
    }
}
