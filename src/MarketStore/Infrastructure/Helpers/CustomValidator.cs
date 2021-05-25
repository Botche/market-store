namespace MarketStore.Infrastructure.Helpers
{
    public static class CustomValidator
    { 
        public static bool IsStringLengthLowerOrEqualTo(string value, int lengthToCkeck)
        {
            bool isValid = value.Length <= lengthToCkeck;

            return isValid;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsBelowZero(double value)
        {
            return value < 0;
        }
    }
}
