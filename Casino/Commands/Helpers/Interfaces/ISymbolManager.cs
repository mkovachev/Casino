using Casino.Data.Interfaces;
using System.Collections.Generic;

namespace Casino.Commands.Helpers.Interfaces
{
    public interface ISymbolManager
    {
        ISymbol CreateRandomSymbol(IReadOnlyList<ISymbol> list);
    }
}