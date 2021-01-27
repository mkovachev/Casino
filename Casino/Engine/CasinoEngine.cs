using Casino.Commands.Helpers.Interfaces;
using Casino.Infrastructure.Interfaces;
using System;
using System.Threading;

namespace Casino.Engine
{
    public class CasinoEngine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandManager commandManager;
        private readonly IBalanceManager balanceManager;
        private readonly IMath mathProvider;

        public CasinoEngine(IReader reader, IWriter writer, ICommandManager commandManager, IBalanceManager balanceManager, IMath mathProvider)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandManager = commandManager;
            this.balanceManager = balanceManager;
            this.mathProvider = mathProvider;
        }

        public void Start()
        {
            this.writer.Write("Enter you inital money balance: ");
            var totalBalance = this.mathProvider.Round(decimal.Parse(this.reader.ReadLine()), 2);
            if (totalBalance <= 0)
            {
                this.writer.WriteLine("Your deposit muss be greater than zero");
                this.writer.Write("Enter your inital money balance: ");
                totalBalance = this.mathProvider.Round(decimal.Parse(this.reader.ReadLine()), 2);
            }

            while (totalBalance >= 0)
            {
                try
                {
                    // Input
                    this.writer.Write("Place your bet: ");
                    var betAmount = decimal.Parse(this.reader.ReadLine());

                    while (betAmount <= 0 || betAmount > totalBalance)
                    {
                        this.writer.WriteLine("Insufficient balance or negative value provided. Correct you input.");
                        this.writer.Write("Place your bet: ");
                        betAmount = decimal.Parse(this.reader.ReadLine());
                    }

                    // Play
                    var totalCoefficient = commandManager.Handle();

                    // Calc balance
                    totalBalance = this.mathProvider.Round(this.balanceManager.Handle(totalCoefficient, betAmount, totalBalance), 2);

                    // Output
                    this.writer.WriteLine($"Current bet: {betAmount}, total balance left: {totalBalance}");

                    if (totalBalance <= 0)
                    {
                        this.writer.WriteLine("------------------------------------");
                        this.writer.WriteLine("Sorry you don't have enough funds to continue. Closing game...");
                        Thread.Sleep(5000);
                        return;
                    }
                    else
                    {
                        this.writer.WriteLine("------------------------------------");
                    }

                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
