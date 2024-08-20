using System;

namespace VendingMachineSimulation
{
    // Beverage class inheriting from the abstract Product class
    public class Beverage : Product
    {
        // Constructor to set the name of the product to "Beverage"
        public Beverage()
        {
            Name = "Beverage";
        }

        // Implementation of the abstract Dispense method
        public override void Dispense()
        {
            Console.WriteLine("Dispensing a beverage...");
        }
    }
}
