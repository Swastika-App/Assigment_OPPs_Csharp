using System;

namespace VendingMachineSimulation
{
    // VendingMachine class implementing the IVendingMachine interface
    public class VendingMachine : IVendingMachine
    {
        // Implementation of the SelectProduct method
        public void SelectProduct(Product product)
        {
            Console.WriteLine($"Selected product: {product.Name}");
            product.Dispense();
        }
    }
}
