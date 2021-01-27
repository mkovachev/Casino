using Casino.Data.Enums;
using Casino.Data.Interfaces;

namespace Casino.Data.Models
{
    public class Wildcard : ISymbol
    {
        private const double CoefficientWon = 0;
        private const double ProbabilityInProcent = 5;

        public string Name { get; } = "Wildcard";

        public SymbolType Type => SymbolType.Wildcard;

        public double Coefficient { get => CoefficientWon; }

        public double Probability { get => ProbabilityInProcent; }

    }
}
