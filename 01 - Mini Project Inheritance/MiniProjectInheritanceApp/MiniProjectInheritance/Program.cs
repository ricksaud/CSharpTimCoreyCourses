using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectInheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {


            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = (new BookModel
            {
                ProductName = "A tale of Two Cities",
                NumberOfPages = 350
            });

            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStocky = 2 };


            rentables.Add(vehicle);
            rentables.Add(excavator);


            purchables.Add(book);
            purchables.Add(vehicle);



            Console.Write("Do you want to rent or purschase something: (rent, purchase) ");
            string rentalDecision = Console.ReadLine();


            if(rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();


                    if(wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }


                    Console.Write("Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();


                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRenatl();
                    }

                }
            }else
            {
                foreach (var item in purchables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();



                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }

                }
            }

            Console.WriteLine("We are done!");


            Console.ReadLine();
        }
    }
}
