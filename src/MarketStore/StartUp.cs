namespace MarketStore
{
    using System;

    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.MarketStoreSystem;

    public class StartUp
    {
        public static void Main()
        {
            Market market = null;

            while (true)
            {
                try
                {
                    Market.CreateMarket("Ivona");
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
            }
        }
    }
}
