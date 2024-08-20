namespace VendingMachineSimulation
{
    // Interface representing the operations of a vending machine
    public interface IVendingMachine
    {
        // Method to select a product and initiate the dispensing process
        void SelectProduct(Product product);
    }
}
