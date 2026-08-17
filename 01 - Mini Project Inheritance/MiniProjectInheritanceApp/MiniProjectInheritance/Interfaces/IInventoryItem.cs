namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public interface IInventoryItem
        {
            string ProductName { get; set; }
            int QuantityInStocky { get; set; }

        }
    }
}
