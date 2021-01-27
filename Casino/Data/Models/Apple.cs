using Casino.Data.Enums;
using Casino.Data.Interfaces;

namespace Casino.Data.Models
{
    public class Apple : ISymbol
    {
        private const double CoefficientWon = 0.2;
        private const double ProbabilityInProcent = 45;
        public string Name { get; } = "Apple";

        public SymbolType Type => SymbolType.Apple;

        public double Coefficient { get => CoefficientWon; }

        public double Probability { get => ProbabilityInProcent; }
    }
}
