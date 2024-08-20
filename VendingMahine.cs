using System;

namespace VendingMachineSimulation
{
    // VendingMachine class implementing the IVendingMachine interface
    public class VendingMachine : IVendingMachine
    {
        // Implementation of the SelectProduct method
        public void SelectProduct(Product product)
        {
            // Display the selected product's name
            Console.WriteLine($"Selected product: {product.Name}");

            // Call the Dispense method to dispense the product
            product.Dispense();
        }
    }
}
