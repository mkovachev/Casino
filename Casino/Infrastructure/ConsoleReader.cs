using Casino.Infrastructure.Interfaces;
using System;

namespace Casino.Infrastructure
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
