namespace MarketStore.MarketStoreSystem.PaydeskSystem.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public interface IPaydesk
    {
        bool AssigneeDiscountCardToClient(string cardType, Client client);

        bool RemoveDiscountCardFromClient(Client client);

        bool ChangeDiscountCard(string cardType, Client client);
    }
}
