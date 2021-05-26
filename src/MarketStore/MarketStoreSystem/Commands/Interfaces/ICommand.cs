namespace MarketStore.MarketStoreSystem.Commands.Interfaces
{
    using MarketStore.MarketStoreSystem.Interfaces;

    public interface ICommand
    {
        string Execute(IMarket market, params string[] arguments);
    }
}
