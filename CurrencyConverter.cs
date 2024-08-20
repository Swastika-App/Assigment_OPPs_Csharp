using System;

namespace CurrencyConverterLibrary
{
    public class CurrencyConverter
    {
        // Properties to hold the currencies and the exchange rate as mentioned
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

        
        public double ConvertAmount(double amount)
        {
           
            IncrementConversionCount();

            //conversion
            return amount * ExchangeRate;
        }

       //Overloaded method
        public double ConvertAmount(double amount, double customRate)
        {
            
            IncrementConversionCount();

            //conversion
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
