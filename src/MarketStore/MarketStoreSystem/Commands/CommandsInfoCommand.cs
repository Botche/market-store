namespace MarketStore.MarketStoreSystem.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    using MarketStore.MarketStoreSystem.Commands.Interfaces;
    using MarketStore.MarketStoreSystem.Interfaces;

    public class CommandsInfoCommand : ICommand
    {
        public string Execute(IMarket market, params string[] arguments)
        {
            Assembly callingAssembly = Assembly.GetCallingAssembly();
            ICollection<Type> commandsTypes = callingAssembly.GetTypes()
                .Where(type => typeof(ICommand).IsAssignableFrom(type) && type.IsInterface == false)
                .ToList();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (Type commandType in commandsTypes)
            {
                stringBuilder.AppendLine($"-- {this.GenerateCommandName(commandType.Name)}");
            }

            return stringBuilder.ToString().Trim();
        }

        private string GenerateCommandName(string typeName)
        {
            Regex pattern = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            List<string> listOfArguments = pattern.Replace(typeName, " ")
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Take(2)
                .ToList();
            string commandName = string.Join(' ', listOfArguments)
                .ToLower();

            return commandName;
        }
    }
}
