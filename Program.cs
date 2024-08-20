using System;
using CurrencyConverterLibrary;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of CurrencyConverter for two different currency pairs
            CurrencyConverter usdToInr = new CurrencyConverter("USD", "INR", 74.85);
            CurrencyConverter eurToUsd = new CurrencyConverter("EUR", "USD", 1.12);

            // Perform conversions using the default exchange rate
            double usdToInrConverted = usdToInr.ConvertAmount(100);
            Console.WriteLine($"100 USD to INR at default rate: {usdToInrConverted} INR");

            double eurToUsdConverted = eurToUsd.ConvertAmount(50);
            Console.WriteLine($"50 EUR to USD at default rate: {eurToUsdConverted} USD");

            // Perform conversions using a custom exchange rate
            usdToInrConverted = usdToInr.ConvertAmount(100, 75.50);
            Console.WriteLine($"100 USD to INR at custom rate: {usdToInrConverted} INR");

            eurToUsdConverted = eurToUsd.ConvertAmount(50, 1.15);
            Console.WriteLine($"50 EUR to USD at custom rate: {eurToUsdConverted} USD");

            // Display the total number of conversions performed
            CurrencyConverter.ShowConversionCount();
        }
    }
}
