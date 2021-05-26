namespace MarketStore.MarketStoreSystem.Commands
{
    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class MakePurchaseCommand : ICommand
    {
        public void Execute(IMarket market, params string[] arguments)
        {
            string clientName = arguments[0];
            double sumToPay = double.Parse(arguments[1]);

            market.MakePurchase(sumToPay, clientName);
        }
    }
}
