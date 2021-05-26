namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class AssigneeCardCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            string cardType = arguments[1];

            market.AssigneeDiscountCardToClient(cardType, clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_ASSIGNEE_CARD_TO_CLIENT, cardType, clientName);
            return messageToReturn;
        }
    }
}
