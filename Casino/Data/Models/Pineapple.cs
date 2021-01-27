using Casino.Data.Enums;
using Casino.Data.Interfaces;

namespace Casino.Data.Models
{
    public class Pineapple : ISymbol
    {
        private const double CoefficientWon = 0.6;
        private const double ProbabilityInProcent = 15;

        public string Name { get; } = "Pineapple";

        public SymbolType Type => SymbolType.Pineapple;

        public double Coefficient { get => CoefficientWon; }

        public double Probability { get => ProbabilityInProcent; }

    }
}
