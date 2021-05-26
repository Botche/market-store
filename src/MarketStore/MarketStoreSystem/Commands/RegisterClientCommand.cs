namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    class RegisterClientCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            market.RegisterClient(arguments[0]);
        }
    }
}
