namespace MarketStore.MarketStoreSystem.Interfaces
{
    using System.Collections.Generic;

    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface IMarket
    {
        string Name { get; }

        void RegisterClientInSystem(string name);
    }
}
