namespace MarketStore.MarketStoreSystem.Commands
{
    using System;

    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class PrintInfoCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            return market.ToString();
        }
    }
}