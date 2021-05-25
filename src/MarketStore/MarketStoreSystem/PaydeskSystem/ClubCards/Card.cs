namespace MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards
{
    using System;
    using System.Collections.Generic;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Helpers;
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Interfaces;
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public abstract class Card : ICard
    {
        private double discountRate;

        public Card(double discountRate = 0)
        {
            this.DiscountRate = discountRate;

            this.CardHolders = new HashSet<Client>();
        }

        public double DiscountRate
        {
            get => this.discountRate;
            protected set
            {
                if (CustomValidator.IsBelowZero(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(this.DiscountRate), ExceptionMessageConstants.DiscountRateBelowZeroMessage);
                }

                this.discountRate = value;
            }
        }

        public ICollection<Client> CardHolders { get; protected set; }
    }
}
