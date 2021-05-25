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
            Market.CreateInstance("Ivona");
            Market market =  Market.GetInstance();

            market.RegistrateClient("Mike");
            market.RegistrateClient("Gosho");
            market.RegistrateClient("Ivan");

            Console.WriteLine(market.MakePurchase(200, "Mike"));
            market.AssigneeDiscountCardToClient("Bronze", "Mike");
            Console.WriteLine(market.MakePurchase(200, "Mike"));
            market.ChangeDiscountCard("Silver", "Mike");
            Console.WriteLine(market.MakePurchase(200, "Mike"));
            market.ChangeDiscountCard("Gold", "Mike");
            Console.WriteLine(market.MakePurchase(200, "Mike"));
            market.RemoveDiscountCardFromClient("Mike");
            Console.WriteLine(market.MakePurchase(200, "Mike"));

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine(market);
            //    }
            //    catch (AlreadyCreatedException ace)
            //    {
            //        Console.WriteLine(ace.Message);
            //    }
            //    catch (NotCreatedException nce)
            //    {
            //        Console.WriteLine(nce.Message);
            //    }
            //    catch (ArgumentException ae)
            //    {
            //        Console.WriteLine(ae.Message);
            //    }

            //    Console.ReadKey();
            //}
        }
    }
}
