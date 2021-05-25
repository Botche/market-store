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
        private readonly ClientsPortal clientsPortal;
        private readonly Paydesk paydesk;

        private string name;

        private Market(string name)
        {
            this.Name = name;
            this.clientsPortal = new ClientsPortal();
            this.paydesk = new Paydesk();
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

        public static Market ChangeName(string newName)
        {
            CheckIfInstanceIsCreated();

            instance.Name = newName;
            return instance;
        }

        public static Market GetInstance()
        {
            CheckIfInstanceIsCreated();

            return instance;
        }

        public bool RegistrateClient(string name)
        {
            this.clientsPortal.RegistrateClient(name);

            return true;
        }

        public bool RemoveClient(string name)
        {
            bool isRemoved = this.clientsPortal.RemoveClient(name);

            if (isRemoved == false)
            {
                string errorMessage = string.Format(ExceptionMessageConstants.ClientDoesNotExistsExceptionMessage, name);
                throw new ArgumentException(errorMessage);
            }

            return true;
        }

        public bool AssigneeDiscountCardToClient(string cardType, string clientName)
        {
            Client client = this.clientsPortal.FindClient(clientName);
            this.CheckIfClientIsNull(client, clientName);

            this.paydesk.AssigneeDiscountCardToClient(cardType, client);

            return true;
        }

        public bool RemoveDiscountCardFromClient(string clientName)
        {
            Client client = this.clientsPortal.FindClient(clientName);
            this.CheckIfClientIsNull(client, clientName);

            this.paydesk.RemoveDiscountCardFromClient(client);

            return true;
        }

        public bool ChangeDiscountCard(string cardType, string clientName)
        {
            Client client = this.clientsPortal.FindClient(clientName);
            this.CheckIfClientIsNull(client, clientName);

            this.paydesk.ChangeDiscountCard(cardType, client);

            return true;
        }

        public double MakePurchase(double sumToPay, string clientName)
        {
            Client client = this.clientsPortal.FindClient(clientName);
            this.CheckIfClientIsNull(client, clientName);

            double discountedSum = client.MakePurchase(sumToPay);

            return discountedSum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string startingMessageLine = string.Format(STARTING_MESSAGE_LINE, this.Name);
            stringBuilder.AppendLine(startingMessageLine);
            stringBuilder.AppendLine(this.clientsPortal.ToString());

            return stringBuilder.ToString().Trim();
        }

        private void CheckIfClientIsNull(Client client, string clientName)
        {
            bool isClientNull = client == null;
            if (isClientNull)
            {
                string errorMessage = string.Format(ExceptionMessageConstants.ClientDoesNotExistsExceptionMessage, clientName);
                throw new ArgumentException(errorMessage);
            }
        }

        private static void CheckIfInstanceIsCreated()
        {
            bool isNull = instance == null;
            if (isNull)
            {
                throw new NotCreatedException(ExceptionMessageConstants.NotCreatedMarketExceptionMessage);
            }
        }
    }
}
