namespace MarketStore.MarketStoreSystem
{
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Interfaces;
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Variantions;
    using MarketStore.MarketStoreSystem.PaydeskSystem.Interfaces;

    public class Paydesk : IPaydesk
    {
        private readonly ICard bronzeCard;
        private readonly ICard silverCard;
        private readonly ICard goldCard;

        public Paydesk()
        {
            this.bronzeCard = new BronzeCard();
            this.silverCard = new SilverCard();
            this.goldCard = new GoldCard();
        }
    }
}
