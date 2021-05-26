namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class RemoveClientCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];

            market.RemoveClient(clientName);
        }
    }
}
