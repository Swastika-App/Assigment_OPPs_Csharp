using System;

namespace VendingMachineSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the VendingMachine
            VendingMachine vendingMachine = new VendingMachine();

            // Create instances of Snack and Beverage
            Product snack = new Snack();
            Product beverage = new Beverage();

            // Use the SelectProduct method to select and dispense a snack
            vendingMachine.SelectProduct(snack);

            // Use the SelectProduct method to select and dispense a beverage
            vendingMachine.SelectProduct(beverage);
        }
    }
}
