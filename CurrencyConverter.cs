using System;

namespace CurrencyConverterLibrary
{
    // The CurrencyConverter class encapsulates the logic for converting currencies
    public class CurrencyConverter
    {
        // Properties to hold the currencies and the exchange rate
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public double ExchangeRate { get; set; }

        // Static member to track the total number of conversions
        private static int ConversionCount = 0;

        // Constructor to initialize the properties
        public CurrencyConverter(string fromCurrency, string toCurrency, double exchangeRate)
        {
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
            ExchangeRate = exchangeRate;
        }

        // Method to convert the amount using the default exchange rate
        public double ConvertAmount(double amount)
        {
            // Increment the conversion count
            IncrementConversionCount();

            // Perform the conversion and return the result
            return amount * ExchangeRate;
        }

        // Overloaded method to convert the amount using a custom exchange rate
        public double ConvertAmount(double amount, double customRate)
        {
            // Increment the conversion count
            IncrementConversionCount();

            // Perform the conversion with the custom rate and return the result
            return amount * customRate;
        }

        // Static method to increment the conversion count
        private static void IncrementConversionCount()
        {
            ConversionCount++;
        }

        // Static method to display the total number of conversions
        public static void ShowConversionCount()
        {
            Console.WriteLine($"Total Conversions: {ConversionCount}");
        }
    }
}
