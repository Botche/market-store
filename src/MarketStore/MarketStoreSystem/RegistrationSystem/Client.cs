namespace MarketStore.MarketStoreSystem.RegistrationSystem
{
    using System;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Helpers;

    public class Client
    {
        private const int CLIENT_NAME_MIN_LENGTH = 3;

        private string name;

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

        public Client(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            string toStringMessage = $"-- Client name: {this.Name}";

            return toStringMessage;
        }
    }
}
