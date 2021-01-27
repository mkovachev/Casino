using Casino.Commands.Helpers.Interfaces;
using Casino.Data.Enums;
using Casino.Data.Interfaces;
using Casino.Factories;
using Casino.Infrastructure.Interfaces;

namespace Casino.Commands
{
    public class PlaySlotCommand : ICommand
    {
        private readonly ISymbolManager symbolManager;
        private readonly ISlotFactory slotFactory;
        private readonly IWriter writer;
        private readonly IMath mathProvider;

        public PlaySlotCommand(ISymbolManager symbolManager, IWriter writer, ISlotFactory slotFactory, IMath mathProvider)
        {
            this.symbolManager = symbolManager;
            this.writer = writer;
            this.slotFactory = slotFactory;
            this.mathProvider = mathProvider;
        }

        public decimal Execute()
        {
            var slot = this.slotFactory.CreateSlot();
            slot.PopulateSymbols();

            var totalCoefficient = 0.0M;

            for (int i = 0; i < slot.Rows; i++)
            {
                ISymbol initalSymbol = null;
                var counterSymbols = 1;
                var counterWildcards = 0;

                for (int j = 0; j < slot.Cols; j++)
                {
                    var currentSymbol = this.symbolManager.CreateRandomSymbol(slot.SlotData);
                    this.writer.Write($"{currentSymbol.Name} | ");

                    if (j == 0)
                    {
                        initalSymbol = currentSymbol;
                    }
                    else
                    {
                        if (initalSymbol.Type == currentSymbol.Type)
                        {
                            counterSymbols++;
                        }
                        else if (currentSymbol.Type == SymbolType.Wildcard)
                        {
                            counterWildcards++;
                        }
                    }

                    if (counterSymbols + counterWildcards == slot.Cols)
                    {
                        totalCoefficient += this.mathProvider.Round((decimal)initalSymbol.Coefficient * counterSymbols, 2);
                    }
                }

                this.writer.WriteLine("");
            }

            return totalCoefficient;
        }
    }
}
