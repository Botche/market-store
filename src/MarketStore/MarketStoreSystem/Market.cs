namespace MarketStore.MarketStoreSystem
{
    using System;
    using System.Text;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.Infrastructure.Helpers;
    using MarketStore.MarketStoreSystem.Interfaces;
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public class Market : IMarket
    {
        private const string STARTING_MESSAGE_LINE = "This is market \"{0}\"...";
        private const int MINIMUM_MARKET_NAME_LENGTH = 3;

        private static Market instance;
        private static readonly object syncLock = new object();

        private string name;

        private Market(string name)
        {
            this.Name = name;
            this.RegistrationDesk = new RegistrationDesk();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (CustomValidator.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name), ExceptionMessageConstants.MarketNameNullOrWhiteSpaceExceptionMessage);
                }

                if (CustomValidator.IsStringLengthLowerOrEqualTo(value, MINIMUM_MARKET_NAME_LENGTH))
                {
                    string exceptionMessage = string.Format(ExceptionMessageConstants.MinimumMarketNameLengthExceptionMessage, MINIMUM_MARKET_NAME_LENGTH);
                    throw new ArgumentException(exceptionMessage);
                }

                name = value;
            }
        }

        public RegistrationDesk RegistrationDesk { get; }

        public static Market CreateInstance(string name)
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

        public static Market GetInstance()
        {
            bool isNull = instance == null;
            if (isNull)
            {
                throw new NotCreatedException(ExceptionMessageConstants.NotCreatedMarketExceptionMessage);
            }

            return instance;
        }

        public static bool DeleteInstance()
        {
            bool isNull = instance == null;
            if (isNull)
            {
                throw new NotCreatedException(ExceptionMessageConstants.NotCreatedMarketExceptionMessage);
            }

            instance = null;
            return true;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string startingMessageLine = string.Format(STARTING_MESSAGE_LINE, this.Name);
            stringBuilder.AppendLine(startingMessageLine);
            stringBuilder.AppendLine(this.RegistrationDesk.ToString());

            return stringBuilder.ToString().Trim();
        }
    }
}
