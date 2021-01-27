using Casino.Infrastructure.Interfaces;
using System;

namespace Casino.Infrastructure
{
    public class RandomProvider : IRandom
    {
        public double NextDouble() => new Random().NextDouble();
    }
}
