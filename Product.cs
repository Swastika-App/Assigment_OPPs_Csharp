using System;

namespace VendingMachineSimulation
{
    // Abstract class Product representing a general product in the vending machine
    public abstract class Product
    {
        // Property to store the product's name
        public string Name { get; protected set; }

        // Abstract method to be implemented by derived classes for dispensing the product
        public abstract void Dispense();
    }
}
