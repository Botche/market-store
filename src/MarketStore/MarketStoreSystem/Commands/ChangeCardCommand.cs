namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class ChangeCardCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            string cardType = arguments[1];

            market.ChangeDiscountCard(cardType, clientName);
        }
    }
}
