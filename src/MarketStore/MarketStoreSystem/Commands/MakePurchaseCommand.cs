namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class MakePurchaseCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            double sumToPay = double.Parse(arguments[1]);

            double sumWithDiscount = market.MakePurchase(sumToPay, clientName);

            string messageToReturn = string.Format(CommandsMessagesConstants.SUCCESSFULLY_MAKE_PURCHASE, sumWithDiscount);
            return messageToReturn;
        }
    }
}
