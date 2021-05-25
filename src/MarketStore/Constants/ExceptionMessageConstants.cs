namespace MarketStore.Constants
{
    public static class ExceptionMessageConstants
    {
        // Market
        public const string NotCreatedMarketExceptionMessage = "Market is not created yet. Please create the market before continue...";
        public const string MinimumMarketNameLengthExceptionMessage = "The market name length must be more than \"{0}\" symbols.";
        public const string MarketNameNullOrWhiteSpaceExceptionMessage = "Market name can not be empty or white space!";
        public const string AlreadyCreatedMarketExceptionMessage = "Market already is created with the name \"{0}\"";
        public const string ClientDoesNotExistsExceptionMessage = "Client with name \"{0}\" does not exists.";

        // Client
        public const string MinimumClientNameLengthExceptionMessage = "Client name length must be more than \"{0}\" symbols.";
        public const string ClientNameNullOrWhiteSpaceExceptionMessage = "Client name can not be empty or white space!";
        public const string AlreadyCreatedClientExceptionMessage = "Client already is created with the name \"{0}\"";
        public const string SpentSumBelowZeroExceptionMessage = "Spent sum can not be under zero.";

        // Card
        public const string DiscountRateBelowZeroExceptionMessage = "Discount rate can not be under zero.";
        public const string InvalidaCardTypeExceptionMessage = "Such a card type does not exists.";
    }
}
