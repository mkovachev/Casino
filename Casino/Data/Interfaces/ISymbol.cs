using Casino.Data.Enums;

namespace Casino.Data.Interfaces
{
    public interface ISymbol
    {
        public string Name { get; }

        public SymbolType Type { get; }

        public double Coefficient { get; }

        public double Probability { get; }
    }
}
