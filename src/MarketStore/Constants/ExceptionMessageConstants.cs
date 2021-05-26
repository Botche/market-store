namespace MarketStore.Constants
{
    public static class ExceptionMessageConstants
    {
        // Market
        public const string NOT_CREATED_MARKET_EXCEPTION_MESSAGE = "Market is not created yet. Please create the market before continue...";
        public const string MINIMUM_MARKET_NAME_LENGTH_EXCEPTION_MESSAGE = "The market name length must be more than \"{0}\" symbols.";
        public const string MARKET_NAME_NULL_OR_WHITE_SPACE_EXCEPTION_MESSAGE = "Market name can not be empty or white space!";
        public const string ALREADY_CREATED_MARKET_EXCEPTION_MESSAGE = "Market already is created with the name \"{0}\"";
        public const string CLIENT_DOES_NOT_EXISTS_EXCEPTION_MESSAGE = "Client with name \"{0}\" does not exists.";

        // Client
        public const string MINIMUM_CLIENT_NAME_LENGTH_EXCEPTION_MESSAGE = "Client name length must be more than \"{0}\" symbols.";
        public const string CLIENT_NAME_NULL_OR_WHITE_SPACE_EXCEPTION_MESSAGE = "Client name can not be empty or white space!";
        public const string ALREADY_CREATED_CLIENT_EXCEPTION_MESSAGE = "Client already is created with the name \"{0}\"";
        public const string SPENT_SUM_BELOW_ZERO_EXCEPTION_MESSAGE = "Spent sum can not be under zero.";

        // Card
        public const string DISCOUNT_RATE_BELOW_ZERO_EXCEPTION_MESSAGE = "Discount rate can not be under zero.";
        public const string INVALID_CARD_TYPE_EXCEPTION_MESSAGE = "Such a card type does not exists.";

        // StartUp
        public const string INVALID_NUMBER_OF_ARGUMENTS_EXCEPTION_MESSAGE = "Invalid number of arguments";
    }
}
