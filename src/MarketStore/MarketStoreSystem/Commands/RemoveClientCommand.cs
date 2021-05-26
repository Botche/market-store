namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class RemoveClientCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];

            market.RemoveClient(clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_REMOVED_CLIENT, clientName);
            return messageToReturn;
        }
    }
}
