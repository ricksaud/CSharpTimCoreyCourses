using System;

namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public class BookModel : InventoryItemModel, IPurchasable
        {

            public int NumberOfPages { get; set; }

            public void Purchase()
            {
                QuantityInStocky -= 1;
                Console.WriteLine("This book has been purchased");
            }
        }
    }
}
