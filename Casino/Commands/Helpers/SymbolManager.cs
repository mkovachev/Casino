using Casino.Commands.Helpers.Interfaces;
using Casino.Data.Interfaces;
using Casino.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Casino.Commands.Helpers
{
    public class SymbolManager : ISymbolManager
    {
        private readonly IRandom random;
        private readonly IWriter writer;

        public SymbolManager(IRandom random, IWriter consoleWriter)
        {
            this.random = random;
            this.writer = consoleWriter;
        }

        public ISymbol CreateRandomSymbol(IReadOnlyList<ISymbol> slotData)
        {
            var totalWeight = slotData.Sum(s => s.Probability);

            double index = this.random.NextDouble() * totalWeight;

            var accumulatedWeight = 0.0;

            foreach (var symbol in slotData)
            {
                accumulatedWeight += symbol.Probability;

                if (accumulatedWeight >= index)
                {
                    return symbol;
                }
            }

            this.writer.WriteLine("Please pick up your favorite symbols and add them to the spin generator");
            return null;
        }
    }
}
