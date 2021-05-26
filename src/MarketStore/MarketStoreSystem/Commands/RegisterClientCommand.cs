namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    class RegisterClientCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            market.RegisterClient(clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_REGISTERED_CLIENT, clientName);
            return messageToReturn;
        }
    }
}
