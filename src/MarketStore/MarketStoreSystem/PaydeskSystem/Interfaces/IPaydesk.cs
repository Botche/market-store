namespace MarketStore.MarketStoreSystem.PaydeskSystem.Interfaces
{
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface IPaydesk
    {
        bool AssigneeDiscountCardToClient(string cardType, Client client);

        bool RemoveDiscountCardFromClient(Client client);

        bool ChangeDiscountCard(string cardType, Client client);
    }
}
