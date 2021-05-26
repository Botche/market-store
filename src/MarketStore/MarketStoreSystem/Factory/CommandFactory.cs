namespace MarketStore.MarketStoreSystem.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;

    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Factory.Interfaces;

    public class CommandFactory : IFactory<ICommand>
    {
        private const string COMMAND_SUFFIX = "command";

        public ICommand Create(params string[] tokens)
        {
            string commandName = tokens[0].ToLower() + COMMAND_SUFFIX;

            Assembly callingAssembly = Assembly.GetCallingAssembly();
            Type commandType = callingAssembly.GetTypes()
                .Where(type => typeof(ICommand).IsAssignableFrom(type))
                .FirstOrDefault(type => type.Name.ToLower() == commandName);

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            return command;
        }
    }
}
