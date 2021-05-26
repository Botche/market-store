namespace MarketStore.MarketStoreSystem.Commands
{
    using System;

    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class PrintInfoCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            Console.WriteLine(market);
        }
    }
}