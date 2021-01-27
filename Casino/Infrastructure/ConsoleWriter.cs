using Casino.Infrastructure.Interfaces;
using System;

namespace Casino.Infrastructure
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message) => Console.WriteLine(message);

        public void Write(string message) => Console.Write(message);
    }
}
