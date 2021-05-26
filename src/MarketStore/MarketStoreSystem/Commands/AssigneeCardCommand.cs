namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class AssigneeCardCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            string cardType = arguments[1];

            market.AssigneeDiscountCardToClient(cardType, clientName);
        }
    }
}
