namespace MarketStore.MarketStoreSystem.Commands.Interfaces
{
    using MarketStore.MarketStoreSystem.Interfaces;

    public interface ICommand
    {
        void Execute(IMarket market, params string[] arguments);
    }
}
