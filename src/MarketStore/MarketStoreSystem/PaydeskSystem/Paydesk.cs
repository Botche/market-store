namespace MarketStore.MarketStoreSystem
{
    using System;

    using MarketStore.Constants;
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Interfaces;
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Variantions;
    using MarketStore.MarketStoreSystem.PaydeskSystem.Interfaces;
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public class Paydesk : IPaydesk
    {
        public bool AssigneeDiscountCardToClient(string cardType, Client client)
        {
            string cardTypeToLower = cardType.ToLower();
            ICard discountCard = null;
            switch (cardTypeToLower)
            {
                case GlobalConstants.BronzeCardName:
                    discountCard = new BronzeCard();
                    break;
                case GlobalConstants.SilverCardName:
                    discountCard = new SilverCard();
                    break;
                case GlobalConstants.GoldCardName:
                    discountCard = new GoldCard();
                    break;

                default:
                    throw new ArgumentException(ExceptionMessageConstants.InvalidaCardTypeExceptionMessage);
            }

            client.DiscountCard = discountCard;

            return true;
        }

        public bool ChangeDiscountCard(string cardType, Client client)
        {
            bool isSuccessful = this.RemoveDiscountCardFromClient(client);
            isSuccessful &= this.AssigneeDiscountCardToClient(cardType, client);

            return isSuccessful;
        }

        public bool RemoveDiscountCardFromClient(Client client)
        {
            client.DiscountCard = null;
            return true;
        }
    }
}
