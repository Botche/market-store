namespace MarketStore.MarketStoreSystem.RegistrationSystem.Interfaces
{
    public interface IClientsPortal
    {
        Client RegisterClient(string name);

        Client FindClient(string name);

        bool RemoveClient(string name);
    }
}
