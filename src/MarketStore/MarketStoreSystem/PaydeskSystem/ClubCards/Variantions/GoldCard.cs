namespace MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Variantions
{
    public class GoldCard : Card
    {
        private const double GOLD_CARD_DISCOUNT_RATE = 10;

        public GoldCard()
            : base(GOLD_CARD_DISCOUNT_RATE)
        {

        }
    }
}
