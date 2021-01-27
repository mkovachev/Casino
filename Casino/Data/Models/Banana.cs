using Casino.Data.Enums;
using Casino.Data.Interfaces;

namespace Casino.Data.Models
{
    public class Banana : ISymbol
    {
        private const double CoefficientWon = 0.4;
        private const double ProbabilityInProcent = 35;

        public string Name { get; } = "Banana";

        public SymbolType Type => SymbolType.Banana;

        public double Coefficient { get => CoefficientWon; }

        public double Probability { get => ProbabilityInProcent; }

    }
}
