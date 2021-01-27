using Casino.Data.Interfaces;
using Casino.Factories;
using Casino.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Casino.Data.Models
{
    public class Slot : ISlot
    {
        private readonly ISymbolFactory symbolFactory;

        public Slot(ISymbolFactory symbolFactory)
        {
            this.symbolFactory = symbolFactory;
        }

        private const int ColsSize = 3;
        private const int RowsSize = 4;

        private readonly IDictionary<double, ISymbol> Symbols = new SortedDictionary<double, ISymbol>(new DescendingComparer<double>());

        public int Cols { get => ColsSize; }

        public int Rows { get => RowsSize; }

        public IReadOnlyList<ISymbol> SlotData { get => this.Symbols.Values.ToList().AsReadOnly(); }

        public void PopulateSymbols()
        {
            var apple = this.symbolFactory.CreateApple();
            var banana = this.symbolFactory.CreateBanana();
            var pineApple = this.symbolFactory.CreatePineapple();
            var wildCard = this.symbolFactory.CreateWildcard();

            this.Symbols.Add(apple.Probability, apple);
            this.Symbols.Add(banana.Probability, banana);
            this.Symbols.Add(pineApple.Probability, pineApple);
            this.Symbols.Add(wildCard.Probability, wildCard);
        }
    }
}
