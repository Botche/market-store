namespace MarketStore.Infrastructure.Exceptions
{
    using System;

    public class AlreadyCreatedException: Exception
    {
        public AlreadyCreatedException() { }
        public AlreadyCreatedException(string message) : base(message) { }
    }
}
