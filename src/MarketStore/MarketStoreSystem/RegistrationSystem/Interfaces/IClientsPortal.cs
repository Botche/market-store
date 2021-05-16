namespace MarketStore.MarketStoreSystem.RegistrationSystem.Interfaces
{
    public interface IClientsPortal
    {
        Client RegistrateClient(string name);

        Client FindClient(string name);

        bool RemoveClient(string name);
    }
}
