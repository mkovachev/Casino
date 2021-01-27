using Casino.Infrastructure.Interfaces;
using System;

namespace Casino.Infrastructure
{
    public class MathProvider : IMath
    {
        public decimal Round(decimal input, int decimals) => Math.Round(input, decimals);
    }
}
