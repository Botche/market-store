namespace MarketStore.MarketStoreSystem.RegistrationSystem.Interfaces
{
    public interface IRegistrationDesk
    {
        Client RegistrateClient(string name);

        Client FindClient(string name);

        bool RemoveClient(string name);
    }
}
