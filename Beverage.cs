using System;

namespace VendingMachineSimulation
{
    // inheritance from abstract product class
    public class Beverage : Product
    {
        public Beverage()
        {
            Name = "Beverage";
        }

        public override void Dispense()
        {
            Console.WriteLine("Dispensing a beverage...");
        }
    }
}
