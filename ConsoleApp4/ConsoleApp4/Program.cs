using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Products firstProducts = new Products();
            Products secondProducts = new Products("Coca-Cola");
            Products thirdProducts = new Products("Fanta", 3);

            double retail = firstProducts.retailPrice();

            //Print a product, its unit of measure, its wholesale price and its retail price.

            Console.WriteLine($"We have {firstProducts.Quantity} {firstProducts.UnitOfMeasure} of {firstProducts.ProductName}");
            Console.WriteLine($"The wholesale is {firstProducts.WholesalePrice}" +
                $" and the retail prices is {retail}");

            Console.WriteLine($"We have {secondProducts.Quantity} {secondProducts.UnitOfMeasure} of {secondProducts.ProductName}");
            Console.WriteLine($"The wholesale is {secondProducts.WholesalePrice}" +
                $" and the retail prices is {retail}");


            Console.WriteLine($"We have {thirdProducts.Quantity} {thirdProducts.UnitOfMeasure} of {thirdProducts.ProductName}");
            Console.WriteLine($"The wholesale is {thirdProducts.WholesalePrice}" +
                $" and the retail prices is {retail}");



        }
    }
}
