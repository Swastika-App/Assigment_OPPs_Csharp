using System;

namespace VendingMachineSimulation
{
    // inheritance from the abstract Product class
    public class Snack : Product
    {
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
