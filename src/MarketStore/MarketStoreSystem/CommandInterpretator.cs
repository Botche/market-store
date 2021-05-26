namespace MarketStore.MarketStoreSystem
{
    using System;
    using System.Linq;

    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Factory;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class CommandInterpretator
    {
        private readonly IMarket market; 
        private readonly CommandFactory commandFactory;

        public CommandInterpretator(IMarket market)
        {
            this.market = market;
            this.commandFactory = new CommandFactory();
        }

        public void ProcessCommand(string input)
        {
            string[] tokens = input.Split(' ').ToArray();
            string commandTypeFirstParam = tokens.First();
            string commandTypeSecondParam = tokens.Skip(1).First();
            string[] arguments = tokens.Skip(2).ToArray();

            string commandType = commandTypeFirstParam + commandTypeSecondParam;
            ICommand command = this.commandFactory.Create(commandType);

            Console.WriteLine(command.Execute(this.market, arguments));
        }
    }
}
