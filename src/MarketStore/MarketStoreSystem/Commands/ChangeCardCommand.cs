namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class ChangeCardCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            string cardType = arguments[1];

            market.ChangeDiscountCard(cardType, clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_CHANGED_CARD_FOR_CLIENT, cardType, clientName);
            return messageToReturn;
        }
    }
}
