namespace MarketStore.GlobalConstants
{
    public static class ExceptionMessageConstants
    {
        public const string NotCreatedMarketExceptionMessage = "Market is not created yet. Please create the market before continue...";
        public const string MinimumMarketNameLengthExceptionMessage = "The market name length must be more than {0} symbols.";
        public const string MarketNameNullOrWhiteSpaceExceptionMessage = "Market name can not be empty or white space!";
        public const string AlreadyCreatedMarketExceptionMessage = "Market already is created with the name {0}";
    }
}
