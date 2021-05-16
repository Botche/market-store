namespace MarketStore.Infrastructure.Exceptions
{
    using System;

    public class NotCreatedException : Exception
    {
        public NotCreatedException() { }
        public NotCreatedException(string message) : base(message) { }
    }
}
