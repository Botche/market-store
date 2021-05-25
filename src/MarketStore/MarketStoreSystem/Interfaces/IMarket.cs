namespace MarketStore.MarketStoreSystem.Interfaces
{
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface IMarket
    {
        string Name { get; }

        double MakePurchase(double sumToPay, string clientName);

        bool RegistrateClient(string name);

        bool RemoveClient(string name);

        bool AssigneeDiscountCardToClient(string cardType, string clientName);

        bool RemoveDiscountCardFromClient(string clientName);

        bool ChangeDiscountCard(string cardType, string clientName);
    }
}
