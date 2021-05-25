namespace MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Variantions
{
    public class SilverCard : Card
    {
        private const double SILVER_CARD_DISCOUNT_RATE = 5;

        public SilverCard()
            : base(SILVER_CARD_DISCOUNT_RATE)
        {

        }
    }
}
