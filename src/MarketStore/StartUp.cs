namespace MarketStore
{
    using System;

    using MarketStore.Constants;
    using MarketStore.Infrastructure.Exceptions;
    using MarketStore.MarketStoreSystem;

    public class StartUp
    {
        public static void Main()
        {
            Market.CreateInstance("Ivona");
            Market market =  Market.GetInstance();
            CommandInterpretator commandInterpreter = new CommandInterpretator(market);

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exit")
            {
                try
                {
                    commandInterpreter.ProcessCommand(command);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(ExceptionMessageConstants.INVALID_NUMBER_OF_ARGUMENTS_EXCEPTION_MESSAGE);
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
