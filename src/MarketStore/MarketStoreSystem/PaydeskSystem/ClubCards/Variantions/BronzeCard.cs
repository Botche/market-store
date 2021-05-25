namespace MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Variantions
{
    public class BronzeCard : Card
    {
        private const double BRONZE_CARD_DISCOUNT_RATE = 2;

        public BronzeCard()
            : base(BRONZE_CARD_DISCOUNT_RATE)
        {

        }
    }
}
