using System;

namespace VendingMachineSimulation
{
    // Snack class inheriting from the abstract Product class
    public class Snack : Product
    {
        // Constructor to set the name of the product to "Snack"
        public Snack()
        {
            Name = "Snack";
        }

        // Implementation of the abstract Dispense method
        public override void Dispense()
        {
            Console.WriteLine("Dispensing a snack...");
        }
    }
}
