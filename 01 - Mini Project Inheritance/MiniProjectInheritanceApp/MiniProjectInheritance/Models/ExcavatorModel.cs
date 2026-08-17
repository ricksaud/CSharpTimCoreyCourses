using System;

namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public class ExcavatorModel : InventoryItemModel, IRentable
        {
            public void Did()
            {
                Console.WriteLine("I am digging");

            }

            public void Rent()
            {
                QuantityInStocky -= 1;
                Console.WriteLine("This excavator has been rented");
            }

            public void ReturnRenatl()
            {
                QuantityInStocky += 1;
                Console.WriteLine("This excavator has been returned");
            }
        }
    }
}
