namespace MarketStore.MarketStoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MarketStore.GlobalConstants;
    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.Infrastructure.Helpers;
    using MarketStore.MarketStoreSystem.Interfaces;
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public class Market : IMarket
    {
        private const int MINIMUM_MARKET_NAME_LENGTH = 3;

        private static Market instance;
        private static readonly object syncLock = new object();

        private string name;
        private readonly ICollection<Client> clients;

        private Market(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (CustomValidator.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessageConstants.MarketNameNullOrWhiteSpaceExceptionMessage);
                }

                if (CustomValidator.IsStringLengthLowerOrEqualTo(value, MINIMUM_MARKET_NAME_LENGTH))
                {
                    string exceptionMessage = string.Format(ExceptionMessageConstants.MinimumMarketNameLengthExceptionMessage, MINIMUM_MARKET_NAME_LENGTH);
                    throw new ArgumentException(exceptionMessage);
                }

                name = value;
            }
        }

        public static Market CreateMarket(string name)
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new Market(name);

                        return instance;
                    }
                }
            }

            string errorMessage = string.Format(ExceptionMessageConstants.AlreadyCreatedMarketExceptionMessage, instance.Name);
            throw new AlreadyCreatedException(errorMessage);
        }

        public static Market GetMarket()
        {
            bool isNull = instance == null;
            if (isNull)
            {
                throw new NotCreatedException(ExceptionMessageConstants.NotCreatedMarketExceptionMessage);
            }

            return instance;
        }

        public static bool DeleteMarket()
        {
            bool isNull = instance == null;
            if (isNull)
            {
                throw new NotCreatedException(ExceptionMessageConstants.NotCreatedMarketExceptionMessage);
            }

            instance = null;
            return true;
        }

        public void RegisterClientInSystem(string name)
        {
            throw new NotImplementedException();
        }
    }
}
