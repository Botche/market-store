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
                case GlobalConstants.BRONZE_CARD_NAME:
                    discountCard = new BronzeCard();
                    break;
                case GlobalConstants.SILVER_CARD_NAME:
                    discountCard = new SilverCard();
                    break;
                case GlobalConstants.GOLD_CARD_NAME:
                    discountCard = new GoldCard();
                    break;

                default:
                    throw new ArgumentException(ExceptionMessageConstants.INVALID_CARD_TYPE_EXCEPTION_MESSAGE);
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
