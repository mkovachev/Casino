using System.Collections.Generic;

namespace Casino.Data.Interfaces
{
    public interface ISlot
    {
        int Cols { get; }

        int Rows { get; }

        IReadOnlyList<ISymbol> SlotData { get; }

        void PopulateSymbols();
    }
}
