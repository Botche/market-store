namespace MarketStore.MarketStoreSystem.RegistrationSystem
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.MarketStoreSystem.RegistrationSystem.Interfaces;

    public class ClientsPortal : IRegistrationDesk
    {
        private const string STARTING_MESSAGE_LINE_TO_STRING = "Clients in the market:";

        private readonly ICollection<Client> clients;

        public ClientsPortal()
        {
            this.clients = new HashSet<Client>();
        }

        public Client RegistrateClient(string name)
        {
            Client clientWithSameName = this.FindClient(name);

            bool isNull = clientWithSameName == null;
            if (isNull == false)
            {
                string errorMessage = string.Format(ExceptionMessageConstants.AlreadyCreatedClientExceptionMessage, name);
                throw new AlreadyCreatedException(errorMessage);
            }

            Client newClient = new Client(name);

            this.clients.Add(newClient);

            return newClient;
        }

        public Client FindClient(string name)
        {
            Client client = this.clients
                .FirstOrDefault(c => c.Name == name);

            return client;
        }

        public bool RemoveClient(string name)
        {
            Client clientToRemove = this.clients
                .FirstOrDefault(c => c.Name == name);

            bool isRemoved = this.clients
                .Remove(clientToRemove);

            return isRemoved;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(STARTING_MESSAGE_LINE_TO_STRING);
            foreach (Client client in this.clients)
            {
                stringBuilder.AppendLine(client.ToString());
            }
            stringBuilder.AppendLine(GlobalConstants.LineSeparator);

            return stringBuilder.ToString().Trim();
        }
    }
}
