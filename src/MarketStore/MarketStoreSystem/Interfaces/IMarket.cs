namespace MarketStore.MarketStoreSystem.Interfaces
{
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface IMarket
    {
        string Name { get; }
        
        RegistrationDesk RegistrationDesk { get; }
    }
}
