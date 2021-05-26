namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class RemoveCardCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];

            market.RemoveDiscountCardFromClient(clientName);
        }
    }
}
