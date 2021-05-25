namespace MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Interfaces
{
    using System.Collections.Generic;

    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface ICard
    {
        double DiscountRate { get; }

        ICollection<Client> CardHolders { get; }
    }
}
