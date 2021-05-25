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

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exit")
            {
                try
                {
                    // market.RemoveClient("Not exist");
                    // market.RegistrateClient("Mike");
                    // market.AssigneeDiscountCardToClient("purple", "Mike");
                    // market.AssigneeDiscountCardToClient("gold", "Not exist");
                    // market.ChangeDiscountCard("purple", "Mike");
                    // market.ChangeDiscountCard("silver", "Not exist");
                    // market.RemoveDiscountCardFromClient("Mike");
                    // market.RemoveDiscountCardFromClient("Not exist");
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
