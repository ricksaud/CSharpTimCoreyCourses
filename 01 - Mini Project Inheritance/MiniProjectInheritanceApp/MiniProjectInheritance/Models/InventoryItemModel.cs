namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public class InventoryItemModel : IInventoryItem
        {

            public string ProductName { get; set; }
            public int QuantityInStocky { get; set; }


        }
    }
}
