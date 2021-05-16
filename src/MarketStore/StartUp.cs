namespace MarketStore
{
    using System;

    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.MarketStoreSystem;
    using MarketStore.MarketStoreSystem.RegistrationSystem;

    public class StartUp
    {
        public static void Main()
        {
            Market market = null;

            while (true)
            {
                try
                {
                    Market.CreateInstance("Ivona");
                    market = Market.GetInstance();

                    Client mike = market.ClientsPortal.RegistrateClient("Mike");
                    market.ClientsPortal.RegistrateClient("Gosho");
                    market.ClientsPortal.RegistrateClient("Ivan");

                    Console.WriteLine(mike);
                    Console.WriteLine(market.ClientsPortal);
                    Console.WriteLine(market);
                }
                catch (AlreadyCreatedException ace)
                {
                    Console.WriteLine(ace.Message);
                }
                catch (NotCreatedException nce)
                {
                    Console.WriteLine(nce.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.ReadKey();
            }
        }
    }
}
