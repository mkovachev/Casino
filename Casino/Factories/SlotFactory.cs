using Casino.Data.Interfaces;
using Casino.Data.Models;

namespace Casino.Factories
{
    public class SlotFactory : ISlotFactory
    {
        private readonly ISymbolFactory symbolFactory;

        public SlotFactory(ISymbolFactory symbolFactory)
        {
            this.symbolFactory = symbolFactory;
        }

        public ISlot CreateSlot() => new Slot(this.symbolFactory);
    }
}
