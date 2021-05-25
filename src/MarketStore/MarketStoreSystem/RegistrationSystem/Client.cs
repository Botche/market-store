﻿namespace MarketStore.MarketStoreSystem.RegistrationSystem
{
    using System;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Helpers;
    using MarketStore.MarketStoreSystem.PaydeskSystem.ClubCards.Interfaces;

    public class Client
    {
        private const int CLIENT_NAME_MIN_LENGTH = 3;

        private string name;

        public Client(string name)
        {
            this.Name = name;
            this.DiscountCard = null;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (CustomValidator.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name), ExceptionMessageConstants.ClientNameNullOrWhiteSpaceExceptionMessage);
                }

                if (CustomValidator.IsStringLengthLowerOrEqualTo(value, CLIENT_NAME_MIN_LENGTH))
                {
                    string errorMessage = string.Format(ExceptionMessageConstants.MinimumClientNameLengthExceptionMessage, CLIENT_NAME_MIN_LENGTH);
                    throw new ArgumentException(errorMessage);
                }

                name = value;
            }
        }

        public ICard DiscountCard { get; set; }

        public double SpentMoney { get; private set; }

        public override string ToString()
        {
            string toStringMessage = $"-- Client name: {this.Name}";

            return toStringMessage;
        }

        public double MakePurchase(double spentMoney)
        {
            if (CustomValidator.IsBelowZero(spentMoney))
            {
                throw new ArgumentOutOfRangeException(nameof(spentMoney), ExceptionMessageConstants.SpentSumBelowZeroExceptionMessage);
            }

            double discountRate = this.DiscountCard == null ? 0 : this.DiscountCard.DiscountRate;
            double discountMultiplier = 1 - (discountRate / 100);
            double sumWithDiscount = spentMoney * discountMultiplier;
            this.SpentMoney += sumWithDiscount;
            return sumWithDiscount;
        }
    }
}
