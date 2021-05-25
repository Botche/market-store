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
        }

        public double DiscountRate
        {
            get => this.discountRate;
            protected set
            {
                if (CustomValidator.IsBelowZero(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(this.DiscountRate), ExceptionMessageConstants.DiscountRateBelowZeroExceptionMessage);
                }

                this.discountRate = value;
            }
        }
    }
}
