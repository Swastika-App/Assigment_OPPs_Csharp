using System;

namespace VendingMachineSimulation
{
    // Abstract class Product representing products in the vending machine
    public abstract class Product
    {
        public string Name { get; protected set; }

        // Abstract method for dispensing
        public abstract void Dispense();
    }
}
