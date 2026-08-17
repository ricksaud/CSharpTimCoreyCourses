using System;

namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
        {
            public int DealerFee { get; set; }

            public void Purchase()
            {
                QuantityInStocky -= 1;
                Console.WriteLine("This vehicle has been purchased");
            }

            public void Rent()
            {
                QuantityInStocky -= 1;
                Console.WriteLine("This vehicle has been rented");
            }

            public void ReturnRenatl()
            {
                QuantityInStocky += 1;
                Console.WriteLine("This vehicle has been returned");
            }
        }
    }
}
