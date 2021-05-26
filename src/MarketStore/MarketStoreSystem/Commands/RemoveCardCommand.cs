namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class RemoveCardCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];

            market.RemoveDiscountCardFromClient(clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_REMOVED_CARD_FROM_CLIENT, clientName);
            return messageToReturn;
        }
    }
}
